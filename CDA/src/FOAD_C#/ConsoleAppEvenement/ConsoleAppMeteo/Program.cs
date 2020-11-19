using ClassLibraryTemp;
using System;

namespace ConsoleAppMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();

            t.Gel += T_Gel;

            for (int i = 0; i < 40; i++)
            {
                t.Diminuer();

            }
            Console.ReadLine();
        }

        private static void T_Gel()
        {
            Console.WriteLine("Je dois rentrer les fleurs, il gel");
        }
    }
}
