using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия_2
{
    class Program
    {
        static void Conv(string check, ref int num)
        {
            if (check != "")
            {
                if (check[0] == '1' | check[0] == '0')
                {
                    num = num * 2 + (check[0] == '1' ? 1 : 0);
                    check = check.Substring(1);
                    Conv(check, ref num);
                }
                else
                {
                    Console.WriteLine("Вы ввели не двоичное");
                }
            }
            else
            {
                Console.WriteLine("Результат: " + num);
            }
        }
        static void Main(string[] args)
        {
            int num=0, c;
            string check;
            do
            {
                try
                {
                    Console.Write("Введите число для перевода: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    check = Convert.ToString(c);
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                }
            } while (true);
            Conv(check, ref num);

        }
    }
}
