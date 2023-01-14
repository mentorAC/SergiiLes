namespace Les09CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Start
            //int a;
            //Array
            //Array
            //int[] arr = new int[10];

            //int[] arr = { 4, 3, 2, 6 };
            //Console.WriteLine(string.Join(' ', arr)) ;
            //int a = 10;
            //int[] tArr = new int[arr.Length + 1];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    tArr[i] = arr[i];
            //}

            //tArr[arr.Length] = a;
            //arr = tArr;
            //Console.WriteLine(string.Join(' ', arr));

            //Array.Resize(ref arr, arr.Length+1);
            //arr[arr.Length - 1] = a;
            //Console.WriteLine(string.Join(' ', arr));
            #endregion
            //Выведите значение наименьшего из всех положительных
            //элементов в массиве. Известно, что в массиве есть хотя
            //бы один положительный элемент.
            //5
            //5 -4 3 -2 1
            //1
            int[] arr = { 5, -4, 3, -2, 1 };

            int Min = int.MaxValue;
             
            for (int i = 0; i< arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] < Min)
                {
                    Min = arr[i];   
                }
            }
            Console.WriteLine(Min);

        }
    }
}