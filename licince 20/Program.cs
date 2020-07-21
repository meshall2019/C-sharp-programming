using System;

namespace licince_20
{
    class Program
    {
        static void Main(string[] args)
        {

            String pass;

            for (int i=0; i < 3; i++)
            {
                Console.Write("Enter the pass: ");
                pass = Console.ReadLine();

                if (pass.Equals("1234"))
                {
                    Console.WriteLine("The pass in correct");
                    break;
                }

            }


        }
    }
}
