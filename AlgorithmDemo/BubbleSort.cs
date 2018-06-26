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
            // i表示需要比较的轮数
            for (int i = 0; i < arry.Length - 1; i++)
            {
                //(arry.Length - 1 - i)表示该轮比较后，得出的最大数所存放的位置
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
