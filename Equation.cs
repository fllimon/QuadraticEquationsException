using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsDemo
{
    class Equation
    {
        public void GetEquation()
        {
            bool condition = true;

            do
            {
                try
                {
                    Console.Write("Введите значение <a>: ");
                    double a = double.Parse(Console.ReadLine());

                    if (a == 0)
                    {
                        throw new ZerroArgumentExeption("Старший коэфициент не может быть равен нулю");
                    }

                    Console.Write("Введите значение <b>: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Введите значение <c>: ");
                    double c = double.Parse(Console.ReadLine());

                    GetDiscriminant(a, b, c);

                    condition = true;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Старший коэфициент <a> не может быть равен нулю");
                    condition = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введенное значение не является числом");
                    condition = false;
                }
            } while (!condition);
        }

        private void GetDiscriminant(double a, double b, double c)
        {
            double result = Math.Pow(b, 2) - 4 * a * c;

            if (result < 0)
            {
                throw new NoRootExeption("Результат дискриминанта меньше нуля, корней нет!");
            }
            else
            {
                if (result == 0)
                {
                    double firstRoot = -b / (2 * a);

                    Console.WriteLine($"Результат вычисления единственного корня: {firstRoot}");
                }
                else
                {
                    double firstRoot = (-b - Math.Sqrt(result)) / (2 * a);
                    double secondRoot = (-b + Math.Sqrt(result)) / (2 * a);

                    Console.WriteLine($"Результат вычисления двух корней:" +
                            $" <1-й корень = {firstRoot}> <2-й корень = {secondRoot}>");
                }
            }
        }
    }
}
