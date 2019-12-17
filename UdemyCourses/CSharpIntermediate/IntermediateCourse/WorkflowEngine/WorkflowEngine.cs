using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        private IList<IActivity> _activities { get; set; }

        public WorkflowEngine()
        {
            _activities = new List<IActivity>();
        }

        // list of activities is private so we use public method to add activities from outside
        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public string Run()
        {
            var allExecutionMessages = "";

            foreach (var activity in _activities)
                allExecutionMessages = $"{allExecutionMessages}\n {activity.Execute()}";

            return allExecutionMessages;            
        }
    }
}
