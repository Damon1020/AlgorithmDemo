using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDemo
{
    class BubbleSort
    {
        public void bubbleSort(int[] arry)
        {
            int x = 0; //用于交换的容器
            for (int i = 0; i < arry.Length - 1; i++)
            {
                for (int j = 0; j < arry.Length - 1 - i;j++)
                {
                    if (arry[j] > arry[j + 1])
                    {
                        x = arry[j];
                        arry[j] = arry[j + 1];
                        arry[j + 1] = x;
                    }
                }
            }
        }
    }
}
