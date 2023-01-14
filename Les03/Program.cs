namespace Les03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //bool b = false; //8 byte

            //< > <= >= != == !

            //int a = 3;
            //int c = 4;
            //b = a == c;

            //b = (bool)100;
            //int a = Convert.ToInt32(Console.ReadLine());
            //b = 1 <= a && a <= 10;
            //1 <= a <= 10

            //Console.WriteLine(b);
            //&&
            // 1 * 1=> 1
            // 1 * 0=> 0
            // 0 * 1=> 0
            // 0 * 0=> 0

            //||
            // 1 + 1=> 2(1)
            // 1 + 0=> 1
            // 0 + 1=> 1
            // 0 + 0=> 0
            // & |
            // && ||
            #endregion
            #region Task2
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //int res1 = Math.Max(a, b);
            //int res2 = Math.Max(Math.Max(a, b), c);
            //Console.WriteLine(res2);

            //int res3 = 0;
            //int res4 = 0;
            //if (a > b)
            //{
            //    res3 = a;
            //}
            //else
            //{
            //    res3 = b;
            //}

            //if (res3 > c)
            //{
            //    res4 = res3;
            //}
            //else
            //{
            //    res4 = c;
            //}
            //Console.WriteLine(res4);
            #endregion
            #region Task3
            ////a + b > c
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());


            //if (a+b > c && b+c>a && a+c >b)
            //{
            //Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion

            // !
            Console.WriteLine(true);
            Console.WriteLine(!true);
            Console.WriteLine(!!true);

            bool b = true;

            if(b == true)
            {
                b = false;
            }else
            {
                b = true;
            }

            b = !b;


            bool gameOver = false;

            if(!gameOver)
            {

            }





        }
    }
    //1 byte -> 1 1 0 0 0 0 0 0

}