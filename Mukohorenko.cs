using System;
// 6. Знищити всі елементи з парними індексами
namespace mukohorenko
{
    public class Task6
    {
        public static int[] Run(int[] arr)
        {
            RemoveEvenIndices(ref arr);
            return arr;
        }
        static void RemoveEvenIndices(ref int[] arr)
        {
            int newSize = arr.Length / 2;
            int[] newArr = new int[newSize];
            for (int i = 1, j = 0; i < arr.Length; i += 2)
            {
                newArr[j++] = arr[i];
            }
            arr = newArr;
        }
    }
}