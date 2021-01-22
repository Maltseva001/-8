using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операторы_выбора
{
    class Program
    {
        static void Main(string[] args)
        {
            int q;
            int d;
            Console.WriteLine("Введите номер темы (1, 2, 3) :");
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите номер варианта (а, b, с) :");
            d = int.Parse(Console.ReadLine());
            switch (q)
            {
                case 1:
                    Console.WriteLine("новогодние,");
                    switch (d)
                    {
                        case a:
                            Console.WriteLine("вариант а");
                            break;
                        case b:
                            Console.WriteLine("вариант b");
                            break;
                        case c:
                            Console.WriteLine("вариант с");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("С днем рождения,");
                    switch (d)
                    {
                        case a:
                            Console.WriteLine("вариант а");
                            break;
                        case b:
                            Console.WriteLine("вариант b");
                            break;
                        case c:
                            Console.WriteLine("вариант с");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("С днем защитника отечества,");
                    switch (d)
                    {
                        case a:
                            Console.WriteLine("вариант а");
                            break;
                        case b:
                            Console.WriteLine("вариант b");
                            break;
                        case c:
                            Console.WriteLine("вариант с");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();
        }
    }
}
