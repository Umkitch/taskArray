﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_For_Processing_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //Console.WriteLine();
            //Console.WriteLine("M2.1. Дан массив. Составить программу:" +
            //    "\r\nа) расчета квадратного корня из любого элемента массива;" +
            //    "\r\nб) расчета среднего арифметического двух любых элементов массива");
            //var array = new double[5];
            //for (int i = 0; i < array.Length; i++) array[i] = random.Next(1, 1080);
            //foreach (var item in array) Console.Write($"{item} ");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.Write("б) \nВведите индекс от 0 до 4: ");
            //var firstValue = array[int.Parse(Console.ReadLine())];
            //Console.Write("Введите индекс от 0 до 4: ");
            //var secondValue = array[int.Parse(Console.ReadLine())];
            //Console.WriteLine($"{firstValue}, {secondValue}");
            //Console.WriteLine();
            //var resultValue = (firstValue + secondValue) / 2;
            //Console.WriteLine(resultValue);
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.2. Дан массив целых чисел. Выяснить:" +
            //    "\r\nа) является ли s-й элемент массива положительным числом;" +
            //    "\r\nб) является ли k-й элемент массива четным числом;" +
            //    "\r\nв) какой элемент массива больше: k-й или s-й.");
            //var arrayInts = new double[2];
            //Console.Write("Введите число 's': ");
            //arrayInts[0] = double.Parse(Console.ReadLine());

            //if (arrayInts[0] > 0) Console.WriteLine("s-й элемент массива - положительное число.");
            //else Console.WriteLine("s-й элемент массива - отрицательное число.");
            //Console.WriteLine();

            //Console.WriteLine("Введите число 'k': ");
            //arrayInts[1] = double.Parse(Console.ReadLine());

            //if (arrayInts[1] % 2 == 0) Console.WriteLine("k-й элемент массива - четное число");
            //else Console.WriteLine("k-й элемент массива - нечетное число");
            //Console.WriteLine();

            //if (arrayInts[0] > arrayInts[1]) Console.WriteLine("'s' элемент массива больше");
            //else Console.WriteLine("'k' элемент массива больше");
            //Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("M2.3. Дан массив. Все его элементы:" +
                "\r\nа) увеличить в 2 раза;" +
                "\r\nб) уменьшить на число А;" +
                "\r\nв) разделить на первый элемент.");
            var allElements = new int[10];
            Console.WriteLine();

            Console.WriteLine("a) ");
            for (int i = 0; i < allElements.Length; i++)
            {
                allElements[i] = random.Next(1, 255);
                Console.Write($"{allElements[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in allElements)
            {
                var result = item * 2;
                Console.Write($"{result} ");
            }
            Console.WriteLine();
            //or
            var allElements1 = new int[10];
            Console.WriteLine();

            for (int i = 0; i < allElements1.Length; i++)
            {
                var result = random.Next(1, 255);
                allElements1[i] = result;
                result *= 2;
                Console.WriteLine($"{allElements1[i]}, {result}");
            }
            Console.WriteLine();
            

            //Console.WriteLine();
            //Console.WriteLine("M2.4.  Дан массив. Все его элементы:" +
            //    "\r\nа) уменьшить на 20;" +
            //    "\r\nб) умножить на последний элемент;" +
            //    "\r\nв) увеличить на число В.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.5. Определить:" +
            //    "\r\nа) сумму всех элементов массива;" +
            //    "\r\nб) произведение всех элементов массива;" +
            //    "\r\nв) сумму квадратов всех элементов массива;" +
            //    "\r\nг) сумму шести первых элементов массива;" +
            //    "\r\nд) сумму элементов массива с k1-го по k2-й" +
            //    "(значения k1 и k2 вводятся с клавиатуры; k2 > k1);" +
            //    "\r\nе) среднее арифметическое всех элементов массива;" +
            //    "\r\nж) среднее арифметическое элементов массива с s1-го по s2-й" +
            //    "(значения s1 и s2 вводятся с клавиатуры; s2 > s1).");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.6. Дан массив a. Определить знакопеременную сумму" +
            //    "a[1] — a[2] + a[3] — a[4] …\r\nУсловный оператор и операцию возведения в степень не использовать.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.7. В массиве хранятся сведения о количестве осадков," +
            //    "выпавших за каждый день января. Определить общее количество осадков за январь.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.8. В массиве хранятся сведения о стоимости 12 различных предметов." +
            //    "Определить общую стоимость всех предметов.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.9. В массиве хранится информация о сопротивлении каждого из 20 элементов" +
            //    "электрической цепи. Все элементы соединены последовательно. Определить общее сопротивление цепи.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.10. В массиве хранится информация о сопротивлении каждого из 20 элементов" +
            //    "электрической цепи. Все элементы соединены параллельно. Определить общее сопротивление цепи.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.11. В массиве хранятся сведения о количестве осадков," +
            //    "выпавших за каждый день июня. Определить общее количество осадков, выпавших за каждую декаду этого месяца.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.12. В массиве хранятся сведения о количестве осадков, выпавших за каждый день февраля." +
            //    "Определить среднедневное количество осадков в этом месяце.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.13.В массиве хранятся сведения о количестве осадков," +
            //    "выпавших за каждый день сентября. Определить, сколько осадков выпадало в среднем за один день в первую," +
            //    "вторую и третью декады этого месяца.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.14.Выяснить, верно ли, что сумма элементов массива есть неотрицательное число.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.15. Дан массив целых чисел. Выяснить:" +
            //    "\r\nа) верно ли, что сумма элементов массива есть четное число;" +
            //    "\r\nб) верно ли, что сумма квадратов элементов массива есть пятизначное число.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.16. В массиве хранится информация о численности учеников в каждом" +
            //    "из 42 классов школы. Выяснить, верно ли, что общее число учеников в школе есть четырехзначное число.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.17. В массиве хранится информация о численности книг в каждом из" +
            //    "35 разделов библиотеки. Выяснить, верно ли, что общее число книг в библиотеке есть шестизначное число.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.18. В массиве хранится информация о массе каждого из 30 предметов," +
            //    "загружаемых в грузовой автомобиль, грузоподъемность которого известна. Определить," +
            //    "не превышает ли общая масса всех предметов грузоподъемность автомобиля.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.19. В массиве хранится информация о баллах, полученных" +
            //    "спортсменом-десятиборцем в каждом из десяти видов спорта. Для выхода в следующий" +
            //    "этап соревнований общая сумма баллов должна превысить некоторое известное значение." +
            //    "Определить, вышел ли данный спортсмен в следующий этап соревнований.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.20.В массиве хранятся сведения о количестве осадков," +
            //    "выпавших за каждый день июня. Определить:" +
            //    "\r\nа) в какой период выпало больше осадков: в первую половину июня или во вторую;" +
            //    "\r\nб) в какую декаду месяца выпало больше всего осадков.");
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("M2.21. Оценки, полученные спортсменом в соревнованиях по" +
            //    "фигурному катанию (в баллах), хранятся в массиве из 12 элементов." +
            //    "В первых шести элементах записаны оценки по  короткой программе;" +
            //    "в остальных — по произвольной программе. Выяснить, по какому виду программы" +
            //    "спортсмен показал лучший результат.");
            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}
