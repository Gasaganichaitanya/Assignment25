using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class principal
    {
        public char Secname { get; private set; }
        public int Strength { get; set; }

        public void AddClass()
        {
            Console.WriteLine("Enter the section name");
            Secname = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter strength");
            Strength = int.Parse(Console.ReadLine());
        }
        public void DisplayClass()
        {
            Console.WriteLine("Section Name:\t" + Secname);
            Console.WriteLine("Strength:\t" + Strength);
        }
    }
}
