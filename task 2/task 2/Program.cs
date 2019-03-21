using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
            //I am Dan. Welcome to my program


        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Please pick a character/symbol.");
            string charac = Console.ReadLine();
            Console.WriteLine("Please select the amount of times you want the character/symbol to be displayed");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i <= num; i++)
            {
                Console.WriteLine(charac);
            }
            Console.ReadLine();
        }
    }
}
