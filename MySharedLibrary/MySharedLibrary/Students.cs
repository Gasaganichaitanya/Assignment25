using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Grade { get; set; }
        public void AddStudent()
        {

            Console.WriteLine("Enter Student Id");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The student Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Grade of the Student");
            Grade = char.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Id of Employee:\t" + Id);
            Console.WriteLine("Name of Employee:\t" + Name);
            Console.WriteLine("Salary:\t" + Grade);

        }
    }
}
