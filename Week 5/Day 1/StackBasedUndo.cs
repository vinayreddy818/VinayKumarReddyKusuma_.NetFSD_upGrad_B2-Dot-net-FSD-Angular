using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleWeek5Day1
{
    internal class StackBasedUndo
    {
        public static void Main()
        {
            List<string> li = new List<string>();
            li.Add("Type A");
            li.Add("Type B");
            li.Add("Type C");
            //Undo Operations
            Undo(li);
            Undo(li);
            Console.WriteLine("Current State After Operations:");
            foreach (var x in li)
            {
                Console.WriteLine(x);
            }
        }
        public static void Undo(List<string> li)
        {
            int length = li.Count;
            if (length > 0) 
            { 
                li.RemoveAt(length - 1);
            }
            else
            {
                Console.WriteLine("Nothing to undo!");
            }
        }

    }
}
