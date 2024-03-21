using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;


namespace cs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ResourceManager rm = new ResourceManager("CarResources", typeof(Program).Assembly);
                Console.WriteLine(rm.GetString("Title"));
                Console.WriteLine(rm.GetString("HeaderString1"));
                Console.WriteLine(rm.GetString("HeaderString2"));
                Console.WriteLine(rm.GetString("HeaderString3"));
                Console.WriteLine(rm.GetString("HeaderString4"));
                Console.WriteLine(rm.GetString("HeaderString5"));
                

            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message); 
                Console.ResetColor();
            }
            Console.ReadKey();

            
        }
    }
}
