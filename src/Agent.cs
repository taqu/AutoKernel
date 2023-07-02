using AutoKernels.Skills;
using AutoKernels.Skills.Web;
using AutoKernels.Skills.Web.Google;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Memory;
using Microsoft.SemanticKernel.Orchestration;
using Microsoft.SemanticKernel.Planning;
using Microsoft.SemanticKernel.SkillDefinition;
using Microsoft.SemanticKernel.Skills.Core;
using Microsoft.SemanticKernel.Skills.Web;
using Microsoft.SemanticKernel.Skills.Web.Google;

namespace AutoKernels
{
    public class Agent
    {
        private IKernel kernel_;
        private VolatileMemoryStore volatileMemoryStore_;
        private ChatAgent chatAgent_;

        public IKernel Kenel { get { return kernel_; } }
        public IReadOnlySkillCollection Skills { get { return kernel_.Skills; } }
        public ChatAgent ChatAgent { get { return chatAgent_; } }

        public Agent(Config config, ILogger? logger)
        {
            volatileMemoryStore_ = new VolatileMemoryStore();

            KernelBuilder kernelBuilder = Kernel.Builder
                   .WithOpenAITextCompletionService(config.Model, config.ApiKey)
                   .WithOpenAIChatCompletionService(config.Model, config.ApiKey)
                   .WithOpenAITextEmbeddingGenerationService(config.Embedding, config.ApiKey)
                   .WithMemoryStorage(volatileMemoryStore_);
            if(null != logger)
            {
                kernelBuilder.WithLogger(logger);
            }
            kernel_ = kernelBuilder.Build();

            if (!string.IsNullOrEmpty(config.GoogleAPIKey))
            {
                kernel_.ImportSkill(new WebSearchEngineSkillJp(new GoogleConnectorJp(config.GoogleAPIKey, config.GoogleEngineId)), "Google");
            }
            kernel_.ImportSkill(new ConversationSummarySkill(kernel_), "Summary");
            kernel_.ImportSkill(new TextMemorySkill(), "TextMemory");
            kernel_.ImportSkill(new TimeSkill(), "Time");
            kernel_.ImportSkill(new TextSkill(), "Text");
            string skillBasePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "skills");
            //kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "CalendarSkill");
            kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "ChatSkill");
            kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "ClassificationSkill");
            kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "GroundingSkill");
            kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "IntentDetectionSkill");
            kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "MiscSkill");
            //kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "QASkill");
            kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "SummarizeSkill");
            //kernel_.ImportSemanticSkillFromDirectory(skillBasePath, "WriterSkill");

            chatAgent_ = new ChatAgent(this);
        }

        public SequentialPlanner CreateSequentialPlanner()
        {
            return new SequentialPlanner(kernel_);
        }

        public Task<SKContext> Run(params ISKFunction[] pipeline)
        {
            return kernel_.RunAsync(pipeline);
        }

        public Task<SKContext> Run(string input, params ISKFunction[] pipeline)
        {
            return kernel_.RunAsync(input, pipeline);
        }
    }
}

