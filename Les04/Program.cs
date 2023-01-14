namespace Les04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            #region Task1
            //Дано три числа. Упорядочите их в порядке неубывания.
            //1 2 1
            //1 1 2

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //4 4 4 
            #region 
            //if (a >= b && a >= c)
            //{
            //    Console.Write(a);
            //    if (b >= c)
            //    {
            //        Console.WriteLine($" {b} {c}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {c} {b}");
            //    }

            //}else if (b > a && b > c)
            //{
            //    Console.Write(b);
            //    if (a >= c)
            //    {
            //        Console.WriteLine($" {a} {c}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {c} {a}");
            //    }

            //}
            //else
            //{
            //    Console.Write(c);
            //    if (a >= b)
            //    {
            //        Console.WriteLine($" {a} {b}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {b} {a}");
            //    }
            //}
            #endregion
            //int Max = Math.Max(Math.Max(a, b),c);
            //int Min = Math.Min(Math.Min(a, b),c);
            //int Ever = (a + b + c) - Max - Min;

            //Console.WriteLine($" {Max} {Ever} {Min}");
            #endregion
            #region Task2
            //Вводятся пять натуральных чисел. Напишите программу,
            //которая выводит сумму только нечётных чисел.

            //2 4 3 5 7
            //15
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int e = Convert.ToInt32(Console.ReadLine());

            //int sum = 1;
            //if (a % 2 != 0) 
            //{
            //    sum *= a; 
            //}

            //if (b % 2 != 0)
            //{
            //    sum *= b;
            //}

            //if (c % 2 != 0)
            //{
            //    sum *= c;
            //}

            //if (d % 2 != 0)
            //{
            //    sum *= d;
            //}

            //if (e % 2 != 0)
            //{
            //    sum *= e;
            //}

            //Console.WriteLine(sum);
            #endregion

            #region Switch
            //1 - 5
            //int a = int.Parse(Console.ReadLine());
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("First");
            //        break;
            //    case 2:
            //        Console.WriteLine("Second");
            //        break;
            //    case 3:
            //        Console.WriteLine("Third");
            //        break;
            //    default:
            //        Console.WriteLine("I don`t know this!");
            //        break;
            //}
            #endregion

            //+1
            //-2
            //2+3
            //()?:
            int a = 4;
            int b = 7;
            int max = (a > b) ? a : b;

            Console.WriteLine((a > b) ? a : b);
        }
    }
}