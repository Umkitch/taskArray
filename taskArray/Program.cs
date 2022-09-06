using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("M1.1. Заполнить массив из восьми элементов следующими значениями: " +
                "первый элемент массива равен 37, второй — 0, третий — 50," +
                "четвертый — 46, пятый — 34, шестой — 46," +
                "седьмой — 0, восьмой —13.");
            var array = new[] { 37, 0, 50, 46, 34, 46, 0, 13 };
            Console.Write("Решение: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.2. Заполнить массив из десяти элементов значениями, вводимыми с клавиатуры в ходе выполнения программы.");
            var enteredArray = new int[10];
            Console.WriteLine("Введите значение для индекса: ");
            for (int i = 0; i < enteredArray.Length; i++)
            {
                enteredArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in enteredArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            ///НЕ РЕШЕНО
            //Console.WriteLine();
            //Console.WriteLine("М1.3. Заполнить массив из пятнадцати элементов случайным образом:" +
            //    "\r\nа) вещественными значениями, лежащими в диапазоне от 0 до 1;" +
            //    "\r\nб) вещественными значениями х (22 <= х < 23);" +
            //    "\r\nв) вещественными значениями х (0 <= х < 10);" +
            //    "\r\nг) вещественными значениями х (–50 <= х < 50);" +
            //    "\r\nд) целыми значениями, лежащими в диапазоне от 0 до 10 включительно.");
            //var randomNumbers = new double[15];

            //Console.Write("a) ");
            //for (double i = 0; i < randomNumbers.Length; i++) randomNumbers[i] = random.NextDouble();//?????????
            //foreach (double item in randomNumbers) Console.WriteLine(item);

            //Console.Write("б) ");

            Console.WriteLine();
            Console.WriteLine("М1.4. Массив предназначен для хранения значений роста двенадцати человек." +
                "С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.");
            var mansLength = new int[12];
            for (int i = 0; i < mansLength.Length; i++) mansLength[i] = random.Next(163, 191);
            foreach (var item in mansLength) Console.Write($"{item} ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.5. Массив предназначен для хранения значений весов двадцати человек." +
                "С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 50 до 100 включительно.");
            var mansWidth = new int[20];
            for (int i = 0; i < mansWidth.Length; i++) mansWidth[i] = random.Next(50, 101);
            foreach (var item in mansWidth) Console.Write($"{item} ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.6. Заполнить массив из двенадцати элементов так: 1 2 … 12.");
            var elements = new int[12];
            for (int i = 0; i < elements.Length; i++) elements[i] = i + 1;
            foreach (var item in elements) Console.Write($"{item} ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.7. Заполнить массив из двадцати элементов так:  20 19 … 1.");
            var elements1 = new int[20];
            for (int i = 0; i < elements1.Length; i++) elements1[i] = 20 - i;
            foreach (var item in elements1) Console.Write($"{item} ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.8. Заполнить массив из восьми элементов таким образом," +
                "\nчтобы значения элементов при просмотре массива слева направо образовывали:" +
                "\r\nа) убывающую последовательность;\r\nб) возрастающую последовательность." +
                "\r\nВарианты, представленные в задачах" +
                "М1.6 и М1.7, не использовать.");
            var arrayDiffPrevious = new int[8];
            for (int i = 0; i < arrayDiffPrevious.Length; i++)
            {
                arrayDiffPrevious[i] = random.Next(0, 25);
            }
            Array.Sort(arrayDiffPrevious);
            Array.Reverse(arrayDiffPrevious);
            foreach (var item in arrayDiffPrevious) Console.Write($"{item} ");
            Console.WriteLine();
            Array.Reverse(arrayDiffPrevious);
            foreach (var item in arrayDiffPrevious) Console.Write($"{item} ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.9. Заполнить массив:\r\nа) десятью первыми членами арифметической" +
                "прогрессии с известным первым членом прогрессии а и ее разностью р;" +
                "\r\nб) двадцатью первыми членами геометрической прогрессии с известным первым членом" +
                "прогрессии а и ее знаменателем z;" +
                "\r\nв) двенадцатью первыми членами последовательности Фибоначчи (последовательности," +
                "в которой первые два члена равны 1," +
                "\nа каждый следующий равен сумме двух предыдущих).");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.10. Дано натуральное число n (n <= 999999). Заполнить массив его цифрами," +
                "расположенными в обратном порядке" +
                "(первый элемент равен последней цифре, второй — предпоследней и т. д.)." +
                "Незаполненные элементы массива должны быть равны нулю." +
                "Элементы массива, являющиеся цифрами числа n, вывести на экран.");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.11. Используя датчик случайных чисел, заполнить массив из двадцати элементов" +
                "не повторяющимися числами.");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.12. Заполнить массив:" +
                "\r\nа) двадцатью первыми натуральными числами, делящимися нацело на 13 или на 17 и находящимися" +
                "в интервале, левая граница которого равна 300;" +
                "\r\nб) тридцатью первыми простыми числами (простым называется натуральное число," +
                "большее 1, не имеющее других делителей, кроме единицы и самого себя).");
            var arrayNaturalNum = new int[20];
            var value = 299;
            for (int i = 0; i < arrayNaturalNum.Length; i++)
            {
                value++;
                do
                {
                    if (value % 13 == 0 || value % 17 == 0) arrayNaturalNum[i] = value;
                    else value++;
                } while (arrayNaturalNum[i] != value);
            }
            foreach (var item in arrayNaturalNum) Console.Write($"{item} ");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.13. Составить программу вывода на экран любого элемента массива по его индексу.");
            var arrayAnyIndex = new int[10];
            for (int i = 0; i < arrayAnyIndex.Length; i++) arrayAnyIndex[i] = random.Next(0, 101);
            var result = arrayAnyIndex[int.Parse(Console.ReadLine())];
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("М1.14. Вывести элементы массива на экран в обратном порядке.");
            var reverseArray = new int[7];
            for (int i = 0; i < reverseArray.Length; i++) reverseArray[i] = random.Next(0, 2784);
            foreach (var item in reverseArray) Console.Write($"{item} ");
            Console.WriteLine();

            Array.Reverse(reverseArray);
            foreach (var item in reverseArray) Console.Write($"{item} ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
