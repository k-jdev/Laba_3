using System;
//16. Вставити перед кожним парним елементом елемент із значенням 1

namespace shulzhenko
{
    public class Task16
    {
        public static int[] Run(int[] arr)
        {
            
            int[] newArr = OneBeforeEven(arr);
            return newArr;
        }

        private static int[] OneBeforeEven(int[] arr)
        {
            int n = arr.Length;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    cnt++;
                }
            }


            int[] arrPlusOne = new int[arr.Length + cnt];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arrPlusOne[index++] = arr[i];
                }
                if (arr[i] % 2 == 0)
                {
                    arrPlusOne[index++] = 1;
                    arrPlusOne[index++] = arr[i];
                }
            }
            return arrPlusOne;
        }
        
    }
}
