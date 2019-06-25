using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Class
{
    class ArithmeticProgression
    {
        private readonly int A_first;
        private readonly int A_d;
        private readonly int A_n;

        public ArithmeticProgression(int Ar1 = 0, int d = 0, int n = 0)
        {
            A_first = Ar1;
            A_d = d;
            A_n = n;
        }

        public void GetInfo() => Console.WriteLine("Первый член прогресси: " + A_first + "Разница прогресси: " + A_d + "N-ый член прогресси: " + A_n);

        public int Avarage_APSum()
        {
            return A_n * ((2 * A_first) + ((A_n - 1) * A_d)) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(2) Задача");
            InitializeProgression(out int A_1, out int D, out int A_N);

            ArithmeticProgression obj = new ArithmeticProgression(A_1, D, A_N);

            ResultProgression(A_N, obj);
        }

        private static void DelayScreen()
        {
            Console.ReadKey(true);
            Console.Clear();
        }

        private static void InitializeProgression(out int A_1, out int D, out int A_N)
        {
            Console.Write("Введите первый член прогресии: ");
            A_1 = int.Parse(Console.ReadLine());
            Console.Write("Введите разницу прогресии: ");
            D = int.Parse(Console.ReadLine());
            Console.Write("Введите n-ый член прогресии: ");
            A_N = int.Parse(Console.ReadLine());
        }

        private static void ResultProgression(int A_N, ArithmeticProgression obj)
        {
            Console.WriteLine($"\nСреднее арифметическое первых членов: {obj.Avarage_APSum() / A_N}");
            Console.WriteLine($"Сумма первых n членов прогрессии: {obj.Avarage_APSum()}");
        }
    }
}
