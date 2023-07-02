
using Microsoft.SemanticKernel.Orchestration;
using Microsoft.SemanticKernel.SkillDefinition;
using System.Collections.Generic;
using System.Text;

namespace AutoKernels.Skills;

public class ChatAgent
{
    public const int MaxTokens = 2048;
    public const string User = "Human";
    public const string Bot = "AI";

    private struct History
    {
        public int tokens_;
        public string input_;
        public List<string> response_;
    };
    private Agent agent_;
    private ISKFunction chatSkill_;
    private SKContext context_;
    private List<History> histories_ = new List<History>(32);
    private StringBuilder histroyBuilder_ = new StringBuilder(1024);

    public ChatAgent(Agent agent)
    {
        agent_ = agent;
        chatSkill_ = agent_.Kenel.Skills.GetFunction("ChatSkill", "Chat");
        context_ = agent_.Kenel.CreateNewContext();
        context_["user"] = User;
        context_["bot"] = Bot;
    }

    public async Task<SKContext> Run(string input)
    {
        context_["input"] = input;
        context_["history"] = GetHistory();
        int prevTokens = GetPromptTokens(context_);
        SKContext next = await chatSkill_.InvokeAsync(context_);
        if (!string.IsNullOrEmpty(next.Result))
        {
            int inputTokens = GetPromptTokens(next) - prevTokens;
            AddHistory(input, inputTokens, next.ModelResults);
            TrimHistories();
            context_ = next;
        }
        return context_;
    }

    private static int GetPromptTokens(SKContext context)
    {
        Diagnostics.Verify.NotNull(context);
        int promptTokens = 0;
        foreach (ModelResult modelResult in context.ModelResults)
        {
            object rawResult = modelResult.GetRawResult();
            if (rawResult is Azure.AI.OpenAI.ChatCompletions)
            {
                promptTokens += (rawResult as Azure.AI.OpenAI.ChatCompletions).Usage.PromptTokens;
            }
        }
        return promptTokens;
    }

    private void AddHistory(string input, int inputTokens, IReadOnlyCollection<ModelResult> modelResults)
    {
        History history = new History();
        history.input_ = string.Format("{0}", input);
        history.tokens_ = inputTokens;
        history.response_ = new List<string>(1);
        foreach (ModelResult modelResult in modelResults){
            object rawResult = modelResult.GetRawResult();
            if(rawResult is Azure.AI.OpenAI.ChatCompletions)
            {
                Azure.AI.OpenAI.ChatCompletions completions = rawResult as Azure.AI.OpenAI.ChatCompletions;
                for (int i=0; i<completions.Choices.Count; ++i)
                {
                    history.response_.Add(string.Format("{0}", completions.Choices[i].Message.Content));
                }
            }
        }
        if(0< history.tokens_)
        {
            histories_.Add(history);
        }
    }

    private void TrimHistories()
    {
        int total = 0;
        for(int i = 0; i < histories_.Count; ++i)
        {
            total += histories_[i].tokens_;
        }
        while(0< histories_.Count)
        {
            if(total<MaxTokens)
            {
                break;
            }
            total -= histories_[0].tokens_;
            histories_.RemoveAt(0);
        }
    }

    private string GetHistory()
    {
        histroyBuilder_.Length = 0;
        for (int i = 0; i < histories_.Count; ++i)
        {
            histroyBuilder_.Append(histories_[i].input_);
            histroyBuilder_.Append('\n');
            for(int j = 0; j < histories_[i].response_.Count; ++j)
            {
                histroyBuilder_.Append(histories_[i].response_[j]);
                histroyBuilder_.Append('\n');
            }
        }
        return histroyBuilder_.ToString();
    }
}

