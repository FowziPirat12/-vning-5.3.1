using System;
namespace Övning_5._3._1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] frågor = {"Vem är den bästa fotboll spelaren i världen?", "Vad heter Somalias huvudstad?", "Vad heter den största djuret i världen?", "Vad för bil har Andrew Tate?" };
            string[] svar = { "Lionel Messi", "Moqadisho", "Blå val", "Bugatti" };
            bool spela = true;

            while(spela = true)
            {
                Console.WriteLine();
                Console.Write("Välj frågor mellan 1-4:");
                int val =int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(frågor[val - 1]);
                string val2 = Console.ReadLine();

                if (val2 == svar[val - 1])
                {
                    Console.WriteLine("Rättt svar!!!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Fel svar!!!");
                }

                Console.WriteLine("Vill du fortsätta y/n?");
                string fortsätta =Console.ReadLine();
                
                if(fortsätta == "y")
                {
                    
                }
                else
                {
                    break;
                }

            }
            spela = false;
        }
    }
}