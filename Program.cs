using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Пользователь вводит два числа. Вывести на экран большее
            //   Task1();

            // 2. Пользователь вводит слово «мяу» или слово «гав» если слово
            //введенное пользователем «мяу» вывести на экран «Покорми кота»
            //иначе «Погуляй с собакой»
            //  Task2();

            // 3. Пользователь вводит номер месяца если месяц 1,2,12 вывести на экран
            //«Зима»; 3,4,5 – «Весна»; 6 - 8 – «Лето»; 9 - 11 – «Осень». В любом другом
            //случае «На этой планете такого месяца нет»
            //   Task3();

            // 4. Пользователь вводит число 1 или 0 с помощью одной строки кода
            // вывести на экран «Хорошо» если пользователь ввел 1 или            
            // «Плохо» если пользователь ввел 0
            //   Task4();

            //5. Вывести название дня недели по его номеру (1 - понедельник, 7 - воскресенье)
            //   Task5();

            //6. Служба такси заказала вам программу, которая спрашивает количество километров и количество минут простоя, а дальше считает так: первые
            //   5 километров(или до 5 км) 20 гривен, каждый следующий километр 3 гривны, плюс простой 1 грн за 1 минуту.Программа должна посчитать
            //   и сказать общую сумму оплаты за поездку.
            //  Task6();
            // 7.Дано натуральное число. Выяснить, является ли оно простым, т.е. делится только на 1 и на само себя.
            Task7();

            Console.ReadLine();
        }


       static public void Task1()
        {
            Console.Write("Введите первое число: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Int32.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine($"Число {b} большее");
            }
            else if (a > b)
            {
                Console.WriteLine($"Число {a} большее");
            }
            else
            {
                Console.WriteLine("ВВеденные числа одинаковые");
            }
        }
        static public void Task2()
        {
            Console.WriteLine("Введите слово «мяу» или слово «гав»");
            string word = Console.ReadLine().ToLower();
            if (word == "гав")
            {
                Console.WriteLine("Погуляй с собакой!");
            }
            else if (word == "мяу")
            {
                Console.WriteLine("Покорми кота!"); 
            }
            else
            {
                Console.WriteLine("Не корректное слово!");
                Task2();
            }
        }
        static public void Task3()
        {


        } //доделать
        static public void Task4()
        {
           Console.WriteLine("Введите число '1' или '0'!");
            char x = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}", (x=='1'?"хорошо":"плохо"));
        }
        static public void Task5()
        {
            Console.Write("\nВведите день недели по его номеру (1 - понедельник..., 7 - воскресенье): ");
            int day = Int32.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресение");
                    break;
                default:
                     Console.WriteLine("Не корректное значение");
                    break;
            }            
        }
        static public void Task6()
        {            
            Console.Write("\nВведите расстояния до пункта назначения (в киломметрах): ");
            int distance = Int32.Parse(Console.ReadLine());
            Console.Write("Введите время простоя автомобиля (в минутах): ");
            int wait = Int32.Parse(Console.ReadLine());
            int tariff = 5;
            if ((distance - tariff) > 0)
            {
                Console.WriteLine("Сумма к оплате: {0} грн.", (distance - tariff) * 3 + 20 + Math.Abs(wait));
            }
            else
                Console.WriteLine("Сумма к оплате: {0} грн.", (20+ Math.Abs(wait)));           
        }
        static public void Task7()
        {           
             bool prost = true;
            Console.WriteLine("Введите число: ");
            int number_2 = int.Parse(Console.ReadLine());
            if (number_2 > 0)
            {
                for (int i = 2; i <= number_2 / 2; i++)
                {
                    if (number_2 % i == 0)
                    {
                        prost = false;
                        break;
                    }
                }
            }
            if (prost)
            {
                Console.WriteLine("Число простое\n");
            }
            else
            {
                Console.WriteLine("Число не простое\n");
            }
        }
    }
}
