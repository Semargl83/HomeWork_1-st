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
            // Task7();
            // 8. Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете 12 - гранный кубик.Если выпадают значения от 1 до 5, пользователь
            //проиграл.Если выпадают значения от 6 до 8, пользователь получает свою ставку обратно.Если выпало от 9 до 11, пользователь получает
            //двойную ставку, а если выпало 12 - ставку умноженную на 10.После окончания игры покажите пользователю, сколько он выиграл.
            // Task8();

            //9. Сделать программу перевода валют. Вводится сумма, потом выбирается вид валюты – гривны или доллары или евро, программа
            //переводит в две другие валюты. Текущий курс валюты считать известным.

            //10.Вывести на экран таблицу умножения на N от 1 до 20 где N число введенное пользователем 2.Пользователь вводит число вывести на
            //экран количество разрядов в этом числе
            //Task10();
            //11.Программа загадывает число от 1 до 146. Пользователь пытается его угадать.В случае неверного ответа программа дает подсказку
            //«больше» или «меньше»
            // Task11();
            //12.Выведите все точные квадраты натуральных чисел, которые (квадраты)
            //меньше заданного числа N. (натуральные - это числа, которые мы используем при счете: 1, 2, 3 и т.д.)
            //Task12();
            // 13. Прочитать с клавиатуры 5 целых чисел, подсчитать их среднее арифметическое и сообщить его пользователю
            //14.Создать 5 случайных целых чисел, подсчитать их среднее арифметическое и сообщить его пользователю
            // Task14();
            // 15. У гусей и кроликов вместе 64 лапы. Сколько может быть кроликов и гусей (указать все сочетания)?
            //Task15();
            //16. Напишите программу, которая будет «спрашивать» правильный пароль, до тех пор, пока он не будет введен. Правильный пароль пусть
            // будет «root». Если пароль не верный, программа должна сказать "Неверный пароль!"
           // Task16();
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
Console.WriteLine("{0}", (x == '1' ? "хорошо" : "плохо"));
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
    Console.WriteLine("Сумма к оплате: {0} грн.", (20 + Math.Abs(wait)));
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
static public void Task8()
{
            Console.Write("Сделайте вашу ставку!!! Минимальная ставка 100,00 грн: ");
            int bet = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Вы сделали ставку в {bet} грн");
            Random rnd = new Random();           
            int gameCub = rnd.Next(1, 13);
            Console.WriteLine($"Брасаем кубик и получвем число-'{gameCub}'");
            switch (gameCub)
            {
                case (1):
                case (2):
                case (3):
                case (4):
                case (5): bet = 0; { Console.WriteLine("Вы проиграли"); }
                    break;
                case (6):
                case (7):
                case (8): { Console.WriteLine("Заберите вашу ставку"); }
                    break;
                case (9):
                case (10):
                case (11):
                    { bet *= 2; Console.WriteLine("Ваша ставка удвоилась"); }
                    break;
                case (12):
                    { bet *= 10; Console.WriteLine("Ваша ставка увеличилась в 10 раз"); }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Bы получаете {bet} грн!!!");
            Task8();
}
static public void Task9(){ }//доделать
static public void Task10()
        {
            Console.Write("Введите целое число: ");
            int number = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}*{1}={2}",number,i, number*i);
            }
        }
static public void Task11()
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 147);
            Console.WriteLine("Попробуй-ка угадать задуманное мной число от 1 до 146 :)");
            int myNumber;
            do
            {
                Console.Write("Введите число: ");
                myNumber = Int32.Parse(Console.ReadLine());
                if (myNumber > secretNumber)
                { Console.WriteLine("Задуманное число меньше"); }
                if (myNumber < secretNumber)
                { Console.WriteLine("Задуманное число больше"); }
            }
            while (secretNumber != myNumber);
            Console.WriteLine("Поздравляю Вы угадали задуманное мной число {0}",secretNumber);
        }
static public void Task12()
        {
            Console.Write("Введите целое число: ");
            int number = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine($"{i} * {i} = { i* i}");
            }
        }
static public void Task13()
        {
        }//доделать
static public void Task14()
        {
            long sum = 0;
            Random rnd = new Random();
            for (int i = 0; i <5; i++)
            {
                sum += rnd.Next();                
            }
            Console.WriteLine("Среднее арифметическое 5-ти невероятных чисел равняется: {0}", sum/5 );  
        }
static public void Task15()
        {
            const int rabbitPaws = 4;
            const int goosePaws = 2;
            int ollPaws = 64;
            int rabbit, goose;
            for (int i=0; i < ollPaws/rabbitPaws; i++)
            {
                rabbit = (ollPaws-i*rabbitPaws) / rabbitPaws;
                goose = (ollPaws-rabbit*rabbitPaws) / goosePaws;
                Console.WriteLine("Кроликов = {0}, Гусей = {1}", rabbit,goose);
            }

        }
static public void Task16()
        {
            bool flag = true;
            string password = "root";
            do
            {
                Console.WriteLine("Введите пароль");
                string word = Console.ReadLine();
                if (password == word)
                { flag = false; }
                else
                    Console.WriteLine("Неверный пароль!");
            }
            while (flag);
            Console.WriteLine("Пароль введен верно!");
        }
    }
}
 