using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static int CountRange() 
        {
            Console.Write("Введите первоначальное значение N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение M: ");
            int M = int.Parse(Console.ReadLine());

            if (N < M)
            {
                int summ = 0, count = M - N;

                for (int i = N; i <= M; i++)
                    summ += i;

                return summ / count;
            }

            Console.WriteLine("Начальное значение должно быть строго меньше конечного значения! ");
            return 0;
        }

        public static int CountEven_0() // точка входа в функцию, которая считает сумму четных чисел от 0 до N ( Подзадача №2 )
        {

            Console.WriteLine("Введите диапазон от 0 до N");
            Console.Write("N: ");
            int N1 = int.Parse(Console.ReadLine());

            if (N1 > 0)
            {
                int summ = 0;

                for (int i = 0; i <= N1; i += 2)
                    summ += i;

                return summ;
            }

            Console.WriteLine("Значение N должно быть больше 0 !");
            return 0;
        }

        public static int CountEven_NM() // точка входа в функцию, которая считает сумму четных чисел от N до M ( Подзадача №3 )
        {

            Console.WriteLine("Введите диапазон от N до M");
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("M: ");
            int M = int.Parse(Console.ReadLine());

            int summ = 0;

            for (int i = N; i <= M; i++)
            {

                if (i % 2 != 0)
                    continue;
                else
                    summ += i; 
            }

            return summ;
        }

        static void Main(string[] args) 
        {
            Console.WriteLine("(1) Задача\n" + "Подзадача №1\n");
            Console.WriteLine("Среднее арифметическое в этом диапазоне: " + CountRange() + "\n"); 

            _ = Console.ReadKey(true); 
            Console.Clear(); // 

            Console.WriteLine("Подзадача №2\n");
            Console.WriteLine("Сумма всех четных чисел в этом диапазоне: " + CountEven_0() + "\n");

            _ = Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Подзадача №3\n");
            Console.WriteLine("Сумма всех четных чисел в этом диапазоне: " + CountEven_NM() + "\n");

            _ = Console.ReadKey(true);
        }
    }
}