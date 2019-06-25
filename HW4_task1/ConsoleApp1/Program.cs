using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Class
{
    class Square
    {
        private int sqSide;
        public int SqSide
        {
            get => sqSide;
            set
            {
                if (value > 0)
                {
                    sqSide = value;
                    SqDiag = sqSide * Math.Sqrt(2);
                }
            }
        }

        public double SqDiag { get; private set; }
        public double SqCount
        {
            get
            {
                double Area = Math.Pow(sqSide, 2);
                return Area;
            }
        }
        public double PerCount
        {
            get
            {
                double Per = 4 * sqSide;
                return Per;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Задача");
            Console.Write("Введите сторону квадрата: ");

            Square SqObj = new Square
            {
                SqSide = int.Parse(Console.ReadLine())
            };

            ResultSquare(SqObj);

            DelayScreen();
        }

        private static void DelayScreen()
        {
            Console.ReadKey(true);
            Console.Clear();
        }

        private static void ResultSquare(Square SqObj)
        {
            Console.WriteLine("Диагональ квадрата: " + SqObj.SqDiag);
            Console.WriteLine("Площадь квадрата: " + SqObj.SqCount);
            Console.WriteLine("Периметр квадрата: " + SqObj.PerCount);
        }
    }
}
