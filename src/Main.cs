using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel.Orchestration;
using Microsoft.SemanticKernel.Planning;
using Microsoft.SemanticKernel.SkillDefinition;
using System.Text;

namespace AutoKernels
{
    public partial class Main : Form
    {
        private StringBuilder stringBuilder = new StringBuilder(1024);

        public Main()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Context.Initialize(textBoxLog);
            ListViewItem item = new ListViewItem();
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Context.Terminate();
        }

        private async void OnClickPlan(object sender, EventArgs e)
        {
            string goal = textBoxPlan.Text.Trim();
            if (string.IsNullOrEmpty(goal))
            {
                return;
            }
            textBoxPlanStatus.Clear();
            try
            {
                SequentialPlanner planner = Context.Agent.CreateSequentialPlanner();
                Plan plan = await planner.CreatePlanAsync(goal);
                listViewStep.Items.Clear();
                foreach (Plan step in plan.Steps)
                {
                    listViewStep.Items.Add(new ListViewItemStep(step));
                }
                Context.Instance.Plan = plan;
                textBoxPlanStatus.Text = "Succeeded";
            }
            catch (PlanningException exception)
            {
                Context.Logger.LogError(exception.Message);
                textBoxPlanStatus.Text = exception.Message;
            }
        }

        private async void OnClickRun(object sender, EventArgs e)
        {
            if (null == Context.Instance.Plan || Context.Instance.Plan.Steps.Count <= 0)
            {
                return;
            }
            SKContext context = await Context.Agent.Run(Context.Instance.Plan);
            richTextBoxResult.Clear();
            richTextBoxResult.Text = context.Result;
        }

        private async void OnClickChatSend(object sender, EventArgs e)
        {
            string input = textBoxChatInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                return;
            }
            textBoxChatInput.Clear();
            try
            {
                SKContext context = await Context.Agent.ChatAgent.Run(input);
                stringBuilder.Length = 0;
                stringBuilder.Append("[*]:");
                stringBuilder.Append(context.Result);
                stringBuilder.Append(System.Environment.NewLine);
                textBoxChatOutput.AppendText(stringBuilder.ToString());
            }
            catch
            {
            }
        }
    }
}
