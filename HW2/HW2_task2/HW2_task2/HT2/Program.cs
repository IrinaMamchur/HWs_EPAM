using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static unsafe void SwapArray(int[] pArray, int pKol) // реализация небезопасной функции (для работы с указателями), которая меняет местами элементы (Параметры: указатель на массив, кол-во элем.)
        {
            int check_Kol = pKol / 2; // переменная разделения массива пополам
            int temp; // переменная замены чисел в массиве

            // Цикл со своим алгоритмом замены чисел
            for (int i = 0; i < check_Kol; i++)
            {
                temp = pArray[pKol - i];
                pArray[pKol - i] = pArray[i];
                pArray[i] = temp;
            }

            // Вызов функции для показа массива
            ShowArray(pArray, pKol + 1);
        }

        public static unsafe void ShowArray(int[] pArray, int pKol) // реализация небезопасной функции (для работы с указателями), которая выводит массив (Параметры: указатель на массив, кол-во элем.)
        {
            // Цикличный вывод массива
            for (int i = 0; i < pKol; i++)
            {
                Console.Write(pArray[i] + "  ");
            }
            Console.WriteLine();
        }

        public static void InitializeArray() // реализация функции, которая инициализурует массив
        {
            // Ввод данных для массива
            Console.Write("Введите кол-то элементов в массиве: ");
            int kol = int.Parse(Console.ReadLine());

            // Выделение памяти для произвольного массива
            int[] Arr = new int[kol];

            // Создание объекта класса Random - использование рандомных чисел в массиве далее..
            Random rd = new Random();

            // Цикличное заполнение массива с помощью рандомных чисел
            for (int i = 0; i < kol; i++)
                Arr[i] = rd.Next(0, 9);

            // Вызов функции показа всего массива
            ShowArray(Arr, kol);

            // Вызов функции FindMax_Arr и возврат результата по задаче
            Console.WriteLine("Расстояние между вхождением максимального значения: " + FindMax_Array(Arr, kol) + "\n");

            // Вызов функции для замены чисел в массиве ( по условию задачи )
            SwapArray(Arr, kol - 1);
        }

        public static unsafe int FindMax_Array(int[] pArray, int pKol) // реализация небезопасной функции (для работы с указателями), которая возвращает расстояние между значениями
        {
            // Присваиваем max - первый элемент для дальнейшей проверки | в переменной safeInI - будет сохранен индекс i по условию | в переменной safeInJ - будет сохранен индекс j по условию
            int max = pArray[0], safeInI = 0, safeInJ = 0;

            // Цикличная структура с специальным ветвлением
            for (int i = 0; i < pKol; i++)
            {
                // Если нашли новое максимальное число - записываем его в max + сохраняем его индекс в safeInI
                if (max < pArray[i])
                {
                    max = pArray[i];
                    safeInI = i;
                }

                // Внутренний цикл, который проверяет первое число со всеми остальными
                for (int j = 0; j < pKol; j++)
                {
                    // Если нет вхождения в текущее число - пропускаем далее
                    if (max != pArray[j])
                        continue;

                    // Либо сохраняем его индекс в safeInJ
                    safeInJ = j;
                }
            }

            // Возврат функцией производится с помощью условного оператора
            // Если индекс i == 0, либо индексы равны - то результат - 0 \ иначе выводим расстояние между индексами
            return safeInI == 0 ? 0 : safeInJ == safeInI ? 0 : safeInJ - safeInI - 1;
        }

        static void Main(string[] args) // точка входа в главную программу
        {
            Console.WriteLine("(2) Задача\n" + "Подзадача №1");

            // Вызов функции инициализации массива
            InitializeArray();

            // Задержка консоли - до нажатия любой кнопки
            _ = Console.ReadKey(true);
        }
    }
}