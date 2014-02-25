using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// Event can be declared using Delegates
        /// </summary>
        public static event DivBySevenEventHandler EventSeven;
        public static void Main()
        {
            DivBySevenListener dbsl = new DivBySevenListener();
          //  EventSeven += new DivBySevenEventHandler(dbsl.ShowOnScreen);
            EventSeven+=new DivBySevenEventHandler(dbsl.ShowOnScreen);
            GenNumbers();
            Console.ReadLine();
           
        }

        public static void OnEventSeven(DivBySevenEventArgs e)
        {
            if (EventSeven != null)
                EventSeven(new object(), e);
        }

        public static void GenNumbers()
        {
            for (int i = 0; i < 99; i++)
            {
                if (i % 7 == 0)
                {
                    DivBySevenEventArgs e1 = new DivBySevenEventArgs(i);
                    OnEventSeven(e1);
                }
            }
        }
    }
}
