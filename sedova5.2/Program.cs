using System;

namespace sedova5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4; //количество строк
            int m = 6; //количество столбцов
            int[,] matr = new int[n, m]; //исходная матрица
            int[] array = new int[m]; //массив для мин эл в столбцах
            Random r = new Random();
            Console.WriteLine("Исходная матрица:");
            //заполним матрицу случайными числами и выведем ее на дисплей
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = r.Next(-10, 11); //заполняем числами в диапазоне от -10 до 10
                    Console.Write(matr[i, j].ToString() + "\t"); //выводим

                }
                Console.WriteLine();
            }
            //найдем мин эл в столбцах и добавим их в новый массив
            Console.WriteLine("Массив из минимальных элементов в каждом столбце:");
            for (int j = 0; j < m; j++) //просматриваем массив "по столбцам"
            {
                int min = int.MaxValue; //начальное значение мин элемента столбца
                for (int i = 0; i < n; i++)
                {
                    //ищем мин элемент в столбце
                    if (matr[i, j] < min)
                    {
                        min = matr[i, j];
                    }
                }
                array[j] = min; //добавляем элемент в массив
                Console.Write(array[j].ToString() + "\t"); //выводим
            }
            Console.ReadLine();
        }
    }
}
