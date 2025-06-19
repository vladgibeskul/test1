using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 1
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}={x + y}");
            //Console.ReadKey();

            ////Task 2
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("z=");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}+{z}={x + y + z}");
            //Console.ReadKey();

            ////Task 3
            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //double y = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}*{y}={x * y:f2}");
            //Console.ReadKey();

            ////Task 4
            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //double y = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}/{y}={x / y:f3}");
            //Console.ReadKey();

            ////Task 5
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}={y}+{x}");
            //Console.ReadKey();

            ////Task6
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write($"a+b={a}+{b}={a + b}\ta-b={a - b}\ta*b={a * b}");
            //Console.ReadKey();

            ////Task 7
            //Console.Write("Как тебя зовут?");
            //string name = Console.ReadLine();
            //Console.Write("Сколько тебе лет?");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{name},ты родился в {2025 - y} ");
            //Console.ReadKey();

            ////Task 8
            //Console.Write("Номенал купюры ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Количество купюр ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Сумма денег = {x * y:f2}");
            //Console.ReadKey();

            ////Task 9

            //Console.Write("Сторона квадрата = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write($"P={a * 4}");
            //Console.ReadKey();

            ////Task 10
            //Console.Write("Сторона a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Сторона b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"P={2 * (a + b)}");
            //Console.ReadKey();

            ////Task 11
            //Console.WriteLine("Вычисление длины окружности");
            //Console.Write("Введите длину радиуса = ");
            //string x = Console.ReadLine();
            //if (double.TryParse(x, out double rad))
            //{
            //    if (rad >= 0)
            //    {
            //        double p = 2 * Math.PI * rad;
            //        Console.WriteLine($"Длина окружности с радиусом {x} равна: {p}");

            //    }
            //    else
            //    {
            //        Console.Write("Радиус не может быть отрицательным");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Некоретный ввод ");
            //}
            //Console.ReadKey();

            ////Task 12
            //Console.Write("Введите сколько гб. пфмяти на фашей флешке =");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write($"{1000*x/820:f2} файлов размером в 820 Мб помещается на флэшку.");
            //Console.ReadKey();

            //////Task 13
            //Console.Write("Введите 2-х значное число ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Десятки = {x / 10}\tЕдиницы = {x % 10}");
            //Console.ReadKey();

            ////task_14
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //double y;
            //if (x < 0)
            //{
            //    y = 6 - x * x;
            //}
            //else
            //{ 
            //    y= Math.Sqrt(x)+2*Math.Sin(x);
            //}
            //Console.WriteLine($"y={y:f2}");
            //Console.ReadKey();

            ////task15
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //double y;
            //if (x <= -5)
            //{
            //    y = Math.Pow(x, 2) + 15 * x;
            //}
            //else if (x >= 5)
            //{
            //    y = (3 * x + 1) / 5;
            //}
            //else
            //{
            //    y = Math.Sqrt(13 + x);
            //}
            //Console.WriteLine($"y={y:f2}");
            //Console.ReadKey();

            ////Task 16 
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //double z;
            //if ( x>=0 )
            //{
            //    z = 2+3*Math.Sqrt(x);
            //}
            //else
            //{
            //    z = 1 - 2 * x * x;
            //}
            //Console.WriteLine($"z={z:f2}");
            //Console.ReadKey();

            //Task17
            //Console.Write("x=");
            //double x = double.Parse(Console.ReadLine());
            //double y=0;
            //if (x <= -5)
            //{
            //    y = Math.Sqrt(13 - x);
            //}
            //else if (x > -5 && x < 5)
            //{
            //    y = Math.Abs(4 * x - 5);
            //}
            //else if (x >=5 )
            //{
            //    y = 3 * Math.Pow(x, 2) - 5 * x;
            //}
            //Console.WriteLine($"y={y}");
            //Console.ReadKey();

            ////task18
            //Console.Write("x=");
            //int x= int.Parse(Console.ReadLine());
            //int y = (x > 0) ? ++x : x -= 2;
            //Console.WriteLine($"Ответ: {y}");
            //Console.ReadLine();

            ////task19
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());

            //if (x > 0)
            //{
            //    x += 1;
            //}
            //if (x < 0)
            //{
            //    x -= 2;
            //}
            //else if (x == 0)
            //{
            //    x += 10;

            //}
            //Console.WriteLine($"x={x}");
            //Console.ReadKey();

            ////Task 20
            //Console.Write("Введите число = ");
            //double x = double.Parse(Console.ReadLine());
            //if (x > 0)
            //{
            //    Console.WriteLine($"Положительное число- {x}");
            //}
            //if (x == 0)
            //{
            //    Console.Write($"Число являеться нулевым - {x}");
            //}
            //else if (x < 0)
            //{
            //    Console.Write($"Число отрицательное {x}");
            //}
            //Console.ReadKey();

            //Task 21 
            //Console.Write("Введите сторону a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите сторону b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Введите сторону с= ");
            //int c = int.Parse(Console.ReadLine());
            //if (a == b&&b==c)
            //{
            //    Console.Write($"Триугольник равностороний т.к. {a}={b}={c}");

            //}

            //else
            //{
            //    Console.Write("Треугольник не являетьтся равносторонним");
            //}
            //Console.ReadKey();

            ////Task 22
            //Console.Write("x=");
            //int x= int.Parse(Console.ReadLine());
            //if (3 % x == 0)
            //{
            //    Console.Write($"{x}-делитель 3");

            //}
            //else
            //{
            //    Console.Write($"{x}-не делитель 3");

            //}
            //Console.ReadKey();

            ////Task 23
            //Random random = new Random(); 
            //for (int i = 0; i < 10; i++) 
            //{
            //    int number = random.Next(-30, 31);
            //    Console.WriteLine($"Число: {number} - {(number < 0 ? "отрицательное" : "положительное")}");
            //}
            //Console.ReadKey();

            ////task24
            //Random random = new Random();
            //for (int i = 0; i < 8; i++)
            //{
            //    int number = random.Next(-20, 31);
            //    string x = (number % 2 == 0) ? "четное" : "нечетное";    
            //    Console.WriteLine($"Число: {number} - {x}");
            //}
            //Console.ReadKey();

            ////task25
            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int number = random.Next(-20,21);
            //    if (number > 0)
            //    {
            //        string x = (number % 2 == 0) ? "четное" : "нечетное";
            //        Console.WriteLine($"Число: {number} - {x}");

            //    }
            //}
            //Console.ReadKey();

            ////Task26
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.Write($"{a}>{b}");
            //}
            //if (b > a)
            //{
            //    Console.Write($"{b}>{a}");
            //}
            //Console.ReadKey();

            //task27

            //Console.WriteLine("Ведите число указывающее номер дня недели от 1 до 7");

            //int day;
            //if (int.TryParse(Console.ReadLine(), out day))
            //{
            //    switch (day)
            //    {
            //        case 1:
            //            Console.Write("День недели: Понедельник");
            //            break;
            //        case 2:
            //            Console.Write("День недели: Вторник");
            //            break;
            //        case 3:
            //            Console.Write("День недели: Среда");
            //            break;
            //        case 4:
            //            Console.Write("День недели: Четверг");
            //            break;
            //        case 5:
            //            Console.Write("День недели: Пятница");
            //            break;
            //        case 6:
            //            Console.Write("День недели: Суббота");
            //            break;
            //        case 7:
            //            Console.Write("День недели: Воскресенье");
            //            break;
            //    }


            //}
            //else
            //{
            //    Console.Write("Ошибка");
            //}
            //Console.ReadKey();

            ////task28 
            //Console.WriteLine("Все четные двузначные числа:");
            //for (int i = 10; i <= 99; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            ////task29
            //Console.WriteLine("Все нечетные двузначные числа:");
            //for (int i = 11; i <= 99; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            ////task30
            //Console.WriteLine("Ввывод в столбик десять раз слово Привет!");
            //for (int i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine("Привет!");
            //}
            //Console.ReadKey();

            ////task31
            //Console.Write("Введите количество выводов= ");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine("Информатика!");
            //}
            //Console.ReadKey();

            ////task32
            //Console.WriteLine("Первые пять натуральных чисел");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.ReadKey();

            //task33
            //Console.WriteLine("Вывод 18 символ в горизантальную строку");
            //for (int i = 1; i <= 18; i++)
            //{
            //    Console.Write("#");
            //}
            //Console.ReadKey();

            ////task34
            //Console.WriteLine("Ввывод 10 натуральных чисел в обратном порядке");
            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine($"{i} ");
            //}
            //Console.ReadKey();

            ////task35
            //Console.WriteLine("Вывод 18 символ в горизантальную строку");
            //for (int i = 1; i <= 18; i++)
            //{
            //    Console.Write("#");
            //}
            //Console.ReadKey();

            //task 36
            //int y;
            //for (int i = 1; i <= 20; i += 2)
            //{
            //    y = 5 * i - 2;
            //    if (i == 1)
            //    {
            //        Console.WriteLine("x\ty\n-----------");
            //    }
            //    Console.WriteLine($"{i}\t{y}");
            //}
            //Console.ReadKey();

            //task 37
            //int y;
            //for (int x = 1; x <= 30; x += 3)
            //{
            //    y = 4 * x - 5;
            //    if (x == 1)
            //    {
            //        Console.WriteLine("x\ty\n-----------");
            //    }
            //    Console.WriteLine($"{x}\t{y}");
            //}
            //Console.ReadKey();

            //task38
            //int y;
            //for (int x = -5; x <= 5; x += 2)
            //{
            //    y = 5*x*x-2*x+1;
            //    if (x == -5)
            //    {
            //        Console.WriteLine("x\ty\n-----------");
            //    }
            //    Console.WriteLine($"{x}\t{y}");
            //}
            //Console.ReadKey();

            ////task39
            //int y;
            //for (int x = -9; x <= 9; x += 3)
            //{
            //    y = 4*x*x+5*x-10;
            //    if (x == -9)
            //    {
            //        Console.WriteLine("x\ty\n-----------");
            //    }
            //    Console.WriteLine($"{x}\t{y}");
            //}
            //Console.ReadKey();

            ////task40
            //Console.WriteLine("Вывести на экран в строку следующие числа 1   5   7   9   11");
            //int[] ints = { 1, 5, 7, 9, 11 };
            //foreach (int number in ints)
            //{
            //    Console.Write($"{number} ");
            //}
            //Console.ReadKey();

            ////task41
            //Console.WriteLine("Вывести на экран в строку следующие числа  4 8 12 16 20");
            //for (int i = 4; i <= 20; i += 4)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.ReadKey();

            ////task42
            ////Console.WriteLine("Вывести на экран в строку следующие числа 1   5   7   9   11");
            ////int[] ints = { 1, 5, 7, 9, 11 };
            ////foreach (int number in ints)
            ////{
            ////    Console.Write($"{number} ");
            ////}
            ////Console.ReadKey();\

            ////task43
            //Console.WriteLine("--- Вывод двузначных натуральных чисел, кратных 10 ---");
            //Console.WriteLine("Числа, кратные 10, в диапазоне от 10 до 99:");
            //for (int i = 10; i <= 99; i += 10)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.ReadKey();/

            //Task44
            //Console.WriteLine("--- Вывод целых чисел от 100 до 200, кратных трем ---");
            //int x = 0;
            //for (int i = 100; i <= 200; i++)

            //{
            //    if (i % 3==0)
            //    {

            //        Console.Write($"{i} ");
            //        x++;
            //        if (x % 10 == 0)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}

            //Console.ReadKey();

            //task 45 
            //double x = 20.4;
            //int maxQuantity = 20;

            //Console.WriteLine("--- Таблица стоимости товара ---");
            //Console.WriteLine("Количество (шт.)\t| Стоимость (руб.)");
            //Console.WriteLine("----------------------------------");

            //for (int i = 2; i <= maxQuantity; i++)
            //{
            //    double totalCost = x * i;
            //    Console.WriteLine($"{i,16}\t| {totalCost,16:F2}");
            //}

            //Console.WriteLine("\nНажмите любую клавишу для выхода...");
            //Console.ReadKey();



            ////task46
            //Console.WriteLine("Ввывод числа 20 в горизантальную строку");
            //for (int i = 0; i <= 10; i++)
            //{ 
            // Console.Write($"{20} ");
            //}
            //Console.ReadKey();

            ////task47
            //Console.Write("Введите курс доллара ");
            //double x = double.Parse(Console.ReadLine());
            //int maxQuantity = 20;

            //Console.WriteLine("--- Таблица стоимости товара ---");
            //Console.WriteLine("Количество (шт.)\t| Стоимость (руб.)");
            //Console.WriteLine("----------------------------------");

            //for (int i = 2; i <= maxQuantity; i++)
            //{
            //    double y = x * i;
            //    Console.WriteLine($"{i,16}\t| {y,16:F2}");
            //}

            //Console.WriteLine("\nНажмите любую клавишу для выхода...");
            //Console.ReadKey();

            //task48
            //Console.WriteLine("Ввывод целых чисел от 0 до 1000 кратные 5");
            //int x=0;
            //for (int i = 0; i < 1000; i += 5)
            //{
            //    if (i % 5==0)
            //    {
            //        Console.Write($"{i} ");
            //        x++;
            //        if (x % 10 == 0)
            //        { 
            //         Console.WriteLine();
            //        }
            //    }
            //}
            //Console.ReadKey();

            //task49
            //Console.WriteLine("Ввывод числа 20 в горизантальную строку");
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write($"{10} ");
            //}
            //Console.ReadKey();

            ////task50
            //Console.WriteLine("--- Вывод двузначных натуральных чисел, кратных 11 ---");
            //Console.WriteLine("Числа, кратные 11, в диапазоне от 11 до 99:");
            //for (int i = 11; i <= 99; i += 11)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.ReadKey();

            
        }
    }
}
