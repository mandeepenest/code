// -----------------------------------------------------------------------
// <copyright file="DivBySevenEventArgs.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    /// <summary>
    /// Create delegate
    /// </summary>
    /// <param name="o"></param>
    /// <param name="args"></param>
    public delegate void DivBySevenEventHandler(object o,DivBySevenEventArgs args);
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DivBySevenEventArgs:EventArgs
    {
        public readonly int theNumber;
        public DivBySevenEventArgs(int num)
        {
            this.theNumber = num;
        }
    }

    public class DivBySevenListener
    {
        public void ShowOnScreen(object o, DivBySevenEventArgs e)
        {
            Console.WriteLine("The DivBySeven Event has been rasied: the guily party is:{0}",e.theNumber);
        }
    }

}
