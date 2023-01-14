using System;

namespace Les06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch
            //1 +
            //2 -
            //3 *
            //int @operator = 1;
            //int a = 1, b= 4;


            //int result = @operator switch
            //{
            //    1 => a + b,
            //    2 => a - b,
            //    3 => a * b,
            //    _ => -1
            //};
            #endregion
            #region Task1
            //По данному целому числу N распечатайте все квадраты
            //натуральных чисел, не превосходящие N, в порядке
            //возрастания.
            //50
            //1 4 9 16 25 36 49

            //int Num = int.Parse(Console.ReadLine());
            //int Sqrt = 1;

            //while (Sqrt*Sqrt < Num) 
            //{
            //    Console.WriteLine(Sqrt*Sqrt);
            //    Sqrt++;
            //}
            #endregion
            #region Task2
            //Дано целое число, не меньшее 2. Выведите его
            //наименьший натуральный делитель, отличный от 1.
            //15
            //3
            //25
            //5
            //int a = int.Parse(Console.ReadLine());
            //int div = 2;
            //while (a % div !=0)
            //{
            //    div++;
            //}
            //Console.WriteLine(div);
            #endregion

            Random random = new Random();
            int value = random.Next(50, 100);
            //int value1 = 50 + random.Next() % (100 - 50);
            Console.WriteLine(value);

            //12345
            int a = 256;
            byte b = (byte)a;
            Console.WriteLine(b);
        }
    }
}