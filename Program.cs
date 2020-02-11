using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "РЕШЕНИЕ КВАДРАТНЫХ УРАВНЕНИЙ";

            Equation someEquation = new Equation();

            try
            {
                someEquation.GetEquation();
            }
            catch (Exception someExeption)
            {
                Console.WriteLine(someExeption);
            }


            Console.WriteLine("Press bay key =(");
            Console.ReadKey();
        }
    }
}
