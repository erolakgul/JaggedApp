using System.Collections.Generic;

namespace JaggedApp
{
    class Program
    {
        /// <summary>
        /// 1.adım parametrelerin tanımlanması
        /// 2.adım koleksiyonun doldurulması
        /// 3.adım array in iç size ının belirlenmesi
        /// 4.adım jagged array in koleksiyondaki veri ile doldurulması
        /// 5.adım jagged array deki verinin gösterilmesi
        /// </summary>
        
        static void Main(string[] args)
        {
            #region init 20x10 matris 
            int jsize = 0;
            int size = 0;
            const int jaggedInnerSize = 10;
            const int jaggedOuterSize = 20; 
            int[][] arr = new int[jaggedOuterSize][];  // outer size belirlenir // int[][] arr = new int[20][]; 
            List<int> _iList = new List<int>();
            #endregion

            #region koleksiyonu doldur
            _iList = Helper.iList(_iList, 200);
            #endregion

            #region array in iç size ını belirle
            arr = Helper.declare(arr,jaggedOuterSize,jaggedInnerSize);
            #endregion

            #region doldur jagged array
            foreach (var item in _iList)
            {
                if (size == jaggedInnerSize)
                {
                    size = 0;
                    jsize++;

                    if (jsize == jaggedOuterSize) break;

                    Helper.setJagged(arr, jsize, size, item);
                }
                else
                {
                    Helper.setJagged(arr, jsize, size, item);
                }
                size++;
            }
            #endregion

            #region göster
            Helper.display(arr);
            #endregion


            System.Console.ReadKey();
        }

    }
}
