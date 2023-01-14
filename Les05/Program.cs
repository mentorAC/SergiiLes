using System.Numerics;

namespace Les05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            //0 20
            //0 1 2 3 4 5 .. 20
            #region Task1
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();
            //for (int i = Math.Max(a, b); i >= Math.Min(a, b); i--)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion
            #region WHILE
            //while (<условие>)
            //{

            //}

            //int k = 0;
            //while(k <= 10)
            //{
            //    Console.Write($"{k} ");
            //    k++;
            //}

            //int a = -1;
            //int counter = 0;
            //while (a != 0)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    counter++;
            //}
            //Console.WriteLine(counter);
            #endregion

            #region for_while
            //for (;;)
            //{
            //}

            //while (true)
            //{

            //}
            #endregion
            #region do_while
            //do
            //{

            //}while(<условие>)
            //Console.WriteLine("Start while");
            //int a = 3;
            //while(a >= 4 && a < 8)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            //Console.WriteLine("End while");
            //Console.WriteLine("Start do while");
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //} while (a >= 4 && a < 8);
            //Console.WriteLine("End do while");
            #endregion


//            Console.WriteLine("Start");
//            for (int i = 0; i < 10; i++)
//            {
//                if(i == 7)
//                {
//                    //continue;
//                    //break;

//                    //goto m1;
//                }

//                Console.WriteLine(i);
//            }
//            Console.WriteLine("End");
////m1:;
//            for (int i = 0; i < 10; i++)
//            {

//            }

            int k = 0;

        m2:
            Console.WriteLine(k);
            k++;
            if (k < 10)
            {
                goto m2;
            }




        }
    }
}