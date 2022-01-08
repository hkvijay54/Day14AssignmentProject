using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day14AssignmentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            ListAddClass list = new ListAddClass();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("****Program End***\n");
        }
    }
}