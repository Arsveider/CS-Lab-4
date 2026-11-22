using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        int z = 0;
        do
        {
            Console.WriteLine("Лабораторная работа #4 Бужлаков Арсений 6102-020302D");
            Console.WriteLine("Выберите желаемую программу: ");
            Console.WriteLine("1.Десятичный счётчик");
            Console.WriteLine("2.Многочлен");
            Console.WriteLine("3.Выход из программы");
            Console.Write("Введите число (1,2,3): ");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("Задание 1 - Десятичный счётчик");
                        Console.Write("Введите минимальную границу: ");
                        int minz = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите максимальную границу: ");
                        int maxd = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите текущее значение(в пределах границы): ");
                        int current = Convert.ToInt32(Console.ReadLine());
                        Counter c1 = new Counter(minz, maxd, current);
                        int q = 0;
                        while (q != 1)
                        {
                            Console.WriteLine("Выберите операцию для счётчика: ");
                            Console.WriteLine("1.Прибавление единицы");
                            Console.WriteLine("2.Вычитание единицы");
                            Console.WriteLine("3.Закончить вычисления");
                            Console.Write("Введите число (1,2,3): ");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                c1.Plus();
                                Console.WriteLine($"Результат вычисления {c1.CurrentValue}");
                            }
                            else if (choice == 2)
                            {
                                c1.Minus();
                                Console.WriteLine($"Результат вычисления {c1.CurrentValue}");
                            }
                            else if (choice == 3)
                            {
                                q = 1;
                                Console.WriteLine("Заканчиваю вычилсения");
                            }
                            else
                                Console.WriteLine("Ошибка ввода");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Задание 2 - Многочлен");
                        Console.WriteLine("Многочлен вида ax^2 + bx + c");
                        Console.Write("Введите коэффициент а для многочлена: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите коэффициент b для многочлена: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите коэффициент c для многочлена: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Polynomial num = new Polynomial(a, b, c);
                        Console.WriteLine(num.Solve());
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Выполнен выход из программы");
                        z = z + 1;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка ввода");
                        break;
                    }
            }
        } while (z != 1);
    }
}
