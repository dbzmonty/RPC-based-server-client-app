using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ServerPort = ConfigurationManager.AppSettings["ServerPort"];
            string ServerUrl = "tcp://localhost:" + ServerPort + "/what";

            ICalculator.ICalculator calc = (ICalculator.ICalculator)Activator.GetObject(
                typeof(ICalculator.ICalculator), ServerUrl);

            if (calc == null)
                Console.WriteLine("Something's wrong");
            else
                Console.WriteLine("Calculator object received");

            Console.WriteLine();

            Console.WriteLine("2 + 8");            
            int res = calc.Addition(2, 8);
            Console.WriteLine("Result is: {0}", res);

            Console.WriteLine();

            Console.WriteLine("22 - 33");
            res = calc.Subtraction(22, 33);
            Console.WriteLine("Result is: {0}", res);

            Console.ReadLine();
        }
    }
}
