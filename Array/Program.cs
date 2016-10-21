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

            /*
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
            */

            //Övn 3
            int mellan = 0; 
            int[] numbArray = new int[] { 12, 5, 6, 1, 2, 3, -2, -7, 0 };
            for (int i = 0; i < numbArray.Length; i++)
            {
                for (int x = i + 1; x < numbArray.Length; x++)
                {
                    if (numbArray[i] > numbArray[x])
                    {
                        mellan = numbArray[x];
                        numbArray[x] = numbArray[i];
                        numbArray[i] = mellan;
                    }
                }
                Console.WriteLine(numbArray[i]);
            
            }
            
                



        }
    }
}
