using Microsoft.SemanticKernel.Planning;

namespace AutoKernels
{
    public class ListViewItemStep : ListViewItem
    {
        private Plan plan_;
        public ListViewItemStep(Plan plan)
        {
            plan_ = plan;
            Text = plan_.SkillName;
            SubItems.Add(plan_.Description);
        }
    }
}
