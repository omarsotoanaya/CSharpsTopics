using System;

namespace InterfacesExercice
{
    public class SMSNotification : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("SMS Notification");
        }
    }
}