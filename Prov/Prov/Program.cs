
using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {

            string HP = "[=====]";
            int HP1 = 5;
            while (HP1 > 0)
            {
                Console.WriteLine(HP);
                Console.WriteLine("Hur mycket skada från 1-2 vill du förlora?");
                string Fight1 = "";
                Console.ReadLine();
                if (Fight1 != "1")
                {
                    HP1 = -1;
                    Console.WriteLine("Du förlorade 1 HP");
                }
                else if (Fight1 != "2")
                {
                    HP1 = -2;
                    Console.WriteLine("Du förlorade 2 HP");
                }
                else
                {
                    Console.WriteLine("Försök igen!");
                }

            }


            Console.ReadLine();
        }
    }
}
