using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Övn 1
            string[] namn = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Mata in ett namn: ");
                namn[i] = Console.ReadLine();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(namn[i]);
            }
            */

            //Övn 2
            int[] tal = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Mata in ett tal: ");
                tal[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(tal[i]);
            }



        }
    }
}
