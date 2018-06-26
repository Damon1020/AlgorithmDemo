using System;

namespace AlgorithmDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 4, 3, 5, 1, 6, 2 };
            Console.WriteLine("冒泡排序前的数组：");
            foreach (int n in arry)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();

            BubbleSort bs = new BubbleSort();
            bs.bubbleSort(arry);
            Console.WriteLine("冒泡排序后的数组：");
            foreach (int n in arry)
            {
                Console.Write($"{n} ");
            }

            Console.ReadKey();
        }
    }
}
