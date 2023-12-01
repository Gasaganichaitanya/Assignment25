using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation you want to perform");
            Console.WriteLine("1.Add student 2.Add class");
            int op = int.Parse(Console.ReadLine());
            Students obj = new Students();
            principal school = new principal();
            switch (op)
            {
                case 1:
                    {
                        obj.AddStudent();
                        obj.Display();
                        break;
                    }
                case 2:
                    {
                        school.AddClass();
                        school.DisplayClass();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}