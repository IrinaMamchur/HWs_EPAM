using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Progression
{
    class Program
    {
        public static int MultiArethProgression(int a1, int t, int n)
        {
            if (n == 0) return 1;

            return a1 * MultiArethProgression(a1 + t, t, n - 1);
        }

        public static double MultiGeomProgression(double a1, double t, int n)
        {
            if (n == 0) return 0;

            if (n == 1) return a1;

            int ratio = n - 1;

            return (a1 / t) * MultiGeomProgression(a1, t, ratio);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("(2) Задача\n" + "Подзадача №1");

            InitializeArethProgression(out int A1, out int N, out int T);
            Console.WriteLine("Произведение n элементов: " + MultiArethProgression(A1, T, N));

            Console.ReadKey(true);
            Console.Clear();

            InitializeGeomProgression(out int first, out int A_n, out int q);
            Console.WriteLine("Произведение n элементов: " + MultiGeomProgression(first, A_n, q));
        }

        private static void InitializeArethProgression(out int A1, out int N, out int T)
        {
            Console.Write("Введите первый элемент ариф. прогрессии: ");
            A1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число элементов ариф. прогрессии: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Введите шаг ариф. прогрессии: ");
            T = int.Parse(Console.ReadLine());
        }

        private static void InitializeGeomProgression(out int first, out int A_n, out int q)
        {
            Console.Write("Введите первый элемент геометр. прогрессии: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Введите число элементов геометр. прогрессии: ");
            A_n = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель (шаг) прогрессии: ");
            q = int.Parse(Console.ReadLine());
        }
    }
}