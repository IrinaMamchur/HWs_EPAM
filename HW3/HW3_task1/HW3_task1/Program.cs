using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Func
{
    class Program
    {
        public enum TypeSortingArray // Объявление типа
                                     // "перечисление" для выбора типа сортировки
        {
            descending = 0,
            increase = 1
        }

        static void Main(string[] args)
        {
            Console.WriteLine("(1) Задача\n" + "Подзадача №1");

            Console.Write("Введите размер массива: ");
            int kol = int.Parse(Console.ReadLine());

            int[] Array = new int[kol];
            InitializeArray(ref Array, kol);
            ShowArray(ref Array, kol);

            Console.WriteLine("\nВыберите тип сортировки массива\n"
                              + "1) По возрастанию значений массива\n"
                              + "2) По убыванию значений массива");
            Console.Write("Ваш выбор: ");
            int chooice = int.Parse(Console.ReadLine());

            ChooiceSort(ref Array, chooice, kol);
            ChCheckSort(ref Array, chooice);

            _ = Console.ReadKey(true);
        }

        /* Собственная функция дополнение для swap-а элементов массива */
        public static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        /* Стандартные функции для работы с массивом */
        public static void InitializeArray(ref int[] ptrArr, int kol)
        {
            Random rd = new Random();

            for (int i = 0; i < kol; i++)
            {
                ptrArr[i] = rd.Next(1, 11);
            }
        }
        public static void ShowArray(ref int[] ptrArr, int kol)
        {
            for (int i = 0; i < kol; i++)
            {
                Console.Write(ptrArr[i] + " ");
            }
            Console.WriteLine();
        }

        /* Функции для подзадачи №1 - по условию возрастание и убывание массива */
        public static void SortingArray(ref int[] ptrArr, TypeSortingArray type)
        {
            switch (type)
            {
                case TypeSortingArray.descending:
                    for (int i = 0; i < ptrArr.Length; i++)
                    {
                        for (int j = 0; j < ptrArr.Length; j++)
                        {
                            if (ptrArr[i] > ptrArr[j])
                                Swap(ref ptrArr[i], ref ptrArr[j]);
                        }
                    }
                    break;

                case TypeSortingArray.increase:
                    for (int i = 0; i < ptrArr.Length; i++)
                    {
                        for (int j = 0; j < ptrArr.Length; j++)
                        {
                            if (ptrArr[i] < ptrArr[j])
                                Swap(ref ptrArr[i], ref ptrArr[j]);
                        }
                    }
                    break;

                default:
                    break;
            }

        }
        public static bool CheckSorting(ref int[] ptrArr, TypeSortingArray type)
        {
            switch (type)
            {
                case TypeSortingArray.descending:
                    for (int i = 0; i < ptrArr.Length - 1; i++)
                    {
                        if (ptrArr[i] < ptrArr[i + 1])
                            return false;
                    }
                    break;

                case TypeSortingArray.increase:
                    for (int i = 0; i < ptrArr.Length - 1; i++)
                    {
                        if (ptrArr[i] > ptrArr[i + 1])
                            return false;
                    }
                    break;

                default:
                    break;
            }
            return true;
        }

        /* Функции выбора типа сортировки массива + проверка на сортировку массива (возвращает True / False) */
        public static void ChooiceSort(ref int[] ptrArr, int chSort, int kol)
        {
            switch (chSort)
            {
                case 1:
                    SortingArray(ref ptrArr, TypeSortingArray.increase);
                    ShowArray(ref ptrArr, kol);
                    break;
                case 2:
                    SortingArray(ref ptrArr, TypeSortingArray.descending);
                    ShowArray(ref ptrArr, kol);
                    break;
                default:
                    Console.WriteLine("Вы ввели не верный тип сортировки попробуйте еще раз!");
                    break;
            }
        }
        public static void ChCheckSort(ref int[] ptrArr, int chSort)
        {
            switch (chSort)
            {
                case 1:
                    Console.WriteLine("\nОтсортирован ли массив значений в заданном порядке: " + CheckSorting(ref ptrArr, TypeSortingArray.increase));
                    break;
                case 2:
                    Console.WriteLine("\nОтсортирован ли массив значений в заданном порядке: " + CheckSorting(ref ptrArr, TypeSortingArray.descending));
                    break;
                default:
                    break;
            }
        }
    }
}