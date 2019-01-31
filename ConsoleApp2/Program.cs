using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                
                Console.WriteLine("Hello User Please Enter your NAME!!");

                string UserInput = null;
                UserInput = (Console.ReadLine());
                Console.WriteLine("Hello " + UserInput);


            }

            catch
            {
                Console.WriteLine("Please TRy another Set Of Values");
                Console.ReadKey(true);
            }


        }
    }
}
