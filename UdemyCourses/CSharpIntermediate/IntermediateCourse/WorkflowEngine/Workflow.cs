using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow
    {
        private IList<IActivity> _activities { get; set; }

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        // list of activities is private so we use public method to add activities from outside
        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
