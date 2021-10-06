using System.Collections.Generic;

namespace JaggedApp
{
    public class Helper
    {
        //// koleksiyonu doldur
        public static List<int> iList(List<int> _iList, int num)
        {
            for (int i = 1; i <= num; i++) _iList.Add(i);
            return _iList;
        }

        //  array inner size ını belirle
        public static int[][] declare(int[][] arr,int outerSize,int innerSize)
        {
            for (int i = 0; i < outerSize; i++) arr[i] = new int[innerSize];
            return arr;
        }

        //// array i doldur
        public static void setJagged(int[][] array, int i, int j, int value)
        {
            array[i][j] = value;
        }

        // değerleri göster
        public static void display(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Array({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }

    }
}
