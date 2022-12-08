using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия_1
{
    class Program
    {

        static double calc(int n, double x, int res = 1)
        {
            if (res > n) return x;
            return x / (res + calc(n, x, res + 1));
        }

        static void Main(string[] args)
        {
            int n;
            double x;
            do
            {
                try
                {
                    Console.Write("Введите n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0) Console.WriteLine("Вы ввели n менье 0");
                    else
                    {
                        Console.Write("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }
            } while (true);

            Console.WriteLine("Результат: " + calc(n, x));

        }
    }
}
