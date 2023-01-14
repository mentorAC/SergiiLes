namespace Les07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DZ
            //Random random = new Random();
            //int comp_number = random.Next(100);

            //int player_number = -1;

            //Console.WriteLine("Угадайте число, которое загадал компьютер (0-100): ");

            //while (comp_number != player_number)
            //{

            //    player_number = int.Parse(Console.ReadLine());

            //    if (player_number < comp_number)
            //    {
            //        Console.WriteLine("Your number is small, try again");
            //    }
            //    else if (player_number > comp_number)
            //    {
            //        Console.WriteLine("Your number is big, try again");

            //    }

            //}

            //Console.WriteLine($"Congratulations, you choose the right number. it is {comp_number} ");

            ////Delay
            //Console.ReadLine();
            #endregion
            #region Task1
            //Программа получает на вход последовательность
            //целых неотрицательных чисел, каждое число
            //записано в отдельной строке. Последовательность
            //завершается числом 0, при считывании которого
            //программа должна закончить свою работу и вывести
            //количество членов последовательности (не считая
            //завершающего числа 0).
            //Числа, следующие за числом 0, считывать не нужно.

            //1 7 9 0
            //3
            //int num = -1;
            //int a = -1;
            //while(a != 0)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    num++;
            //}
            //Console.WriteLine(num);
            #endregion
            #region Task2
            // 3 6 1 8 4 0
            //int max = -1;
            //int num = -1;

            //while (num != 0)
            //{
            //    num = int.Parse(Console.ReadLine());
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine(max);
            #endregion


            int[] arr = new int[5];
            int[] arr1 = new int[5] {1,2,3,4,5 };
            int[] arr2 = new int[] {1,2,3,4,5 };
            int[] arr3 = new[] {1,2,3,4,5 };
            int[] arr4 = { 1, 2, 3, 4, 5 };

            string[] names = { "Bob", "Mark", "Tom"};

            //Console.WriteLine(arr1[2]);

            #region Task3
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //foreach(int a in arr1)
            //{
            //    Console.WriteLine(a);
            //}
            #endregion

            //Выведите все элементы массива с четными индексами
            //5
            //1 2 3 4 5
            //-> 1 3 5

            int size = int.Parse(Console.ReadLine());
            int[] arr5 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr5[i] = int.Parse(Console.ReadLine());
            }

            for (int i=0; i< arr5.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{arr5[i]} ");
                }
            }
            
        }
    }
}