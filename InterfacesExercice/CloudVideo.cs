using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercice
{
    public class CloudVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Cloud stream Notification");
        }
    }
}
