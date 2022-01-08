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

            //uc2
            ListAddClass list2 = new ListAddClass();
            list2.Add(70);
            int a = list2.Search(70);
            Console.WriteLine("index position of 70 is : " + a);
            list2.InsertNthPosition(a + 1, 30);
            list2.InsertNthPosition(a + 1, 56);
            list2.Display();
            Console.WriteLine("****Program End***\n");

            //uc3
            ListAddClass list3 = new ListAddClass();
            list3.Add(56);
            list3.InsertAfter(30, 56);
            list3.InsertAfter(70, 30);
            Console.WriteLine("List after appending 30 and 70");
            list3.Display();
            Console.WriteLine("****Program End***\n");

            //uc4
            ListAddClass list4 = new ListAddClass();
            list4.Add(56);
            list4.Add(70);
            int a2 = list4.Search(70);
            Console.WriteLine("index position of 70 is : " + a2);
            list4.InsertNthPosition(a2 + 1, 30);
            list4.Display();
            Console.WriteLine("****Program End***\n");
        }
    }
}