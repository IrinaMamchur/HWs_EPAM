using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void InitializeMatrix() // реализация функции инициализации матрицы
        {
            // Ввод данных для установки значения матрицы
            Console.Write("Введите размер квадратной матрицы: ");
            int sizeMatrix = int.Parse(Console.ReadLine());

            // объявление объекта класса Random - для использования рандомных чисел
            Random rd = new Random();

            // Создание матрицы и адреса на нее
            int[,] Matrix = new int[sizeMatrix, sizeMatrix];

            // Заполнение матрицы цикличной структурой - с использованием рандомных чисел
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    Matrix[i, j] = rd.Next(2, 9); // рандомные числа от 2 до 9
                }
            }

            // Вызов функции вывода матрицы + вызов функции изменения матрицы по условию задачи (0 - слева, 1 - справа от главной диагонали)
            ShowMatrix(Matrix, sizeMatrix);
            EditMatrix(Matrix, sizeMatrix);

            // Снова вызов функции вывода матрицы, чтобы посмотреть уже измененную матрицу после действий
            Console.WriteLine("\n --- Измененная матрица ---\n");
            ShowMatrix(Matrix, sizeMatrix);
        }

        public static unsafe void EditMatrix(int[,] pArray, int size) // реализация небезопасной функции (для работы с указателями) изменения матрицы
        {
            // Циклическая структура - которая проходит по матрице (каждый элемент)
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // первое условие - если элементы стоят правее диагонали - ставим 1
                    if (i < j)
                        pArray[i, j] = 1;
                    // если элементы равны - то пропускаем шаг цикла (это главная диагональ)
                    else if (i == j)
                        continue;
                    // иначе меняем на нуль значения элементов (те которые останутся слева)
                    else
                        pArray[i, j] = 0;
                }
            }
        }

        public static unsafe void ShowMatrix(int[,] pArray, int size) // реализация небезопасной функции (для работы с указателями) вывода всей матрицы
        {
            // Цикличная структура для вывода значенйи элементов матрицы
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(pArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args) // точка входа в главную программу
        {
            Console.WriteLine("(3) Задача");

            // Вызов функции для инициализации массива и дальнейший действий
            InitializeMatrix();

            // Считывание любой клавиши, чтобы задержать консоль
            _ = Console.ReadKey(true);
        }
    }
}
