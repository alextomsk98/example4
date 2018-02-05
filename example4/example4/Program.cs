using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Class Types*****\n");
            Car chuck = new Car();

            Car mary = new Car("Mary");

            Car daisy = new Car("Daisy", 75);
            Console.ReadLine();
        }
    }
}
