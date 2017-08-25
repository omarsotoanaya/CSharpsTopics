using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercice
{
    class WorkFlow
    {
        private readonly List<IActivity> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Run()
        {
            foreach(var activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}
