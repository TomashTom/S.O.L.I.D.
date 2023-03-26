using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class EventHandlerNoArgsExample
    {
        public event EventHandler EventHandlerNoArgsEvent;

        public void InvokeEventHandlerNoArgs()
        {
            Console.WriteLine("Invoking Event Handler No Args Example");

            if (EventHandlerNoArgsEvent != null)
            {
                EventHandlerNoArgsEvent(this, EventArgs.Empty);
            }
        }
    }
}
