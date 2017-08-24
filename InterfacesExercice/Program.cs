using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow wf = new WorkFlow();
            wf.Add(new SendNotification());
            wf.Add(new SMSNotification());
            wf.Add(new CloudVideo());
            wf.Run();

            Console.ReadLine();

        }
    }
}
