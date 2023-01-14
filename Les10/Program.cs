namespace Les10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //далее последовательность
            //из N чисел, каждое из которых не превосходит. Найдите
            //максимальную по длине сериювозрастающих элементов.
            //Если таких серий несколько -- выведите первую из них.
            //4 3 1 2 3 5 3 5 6 7 7 8
            //1 2 3 5


            int[] arr = new int[12] { 4, 3, 1, 2, 3, 5, 3, 5, 6, 7, 7, 8 };
            int count = 0;
            int maxCount = 0;
            int index = 0; ;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                }
                else 
                {
                    if(maxCount < count)
                    {
                        maxCount = count;
                        index = i;
                    }

                    count = 0;
                }

            }
            for (int i = index - maxCount; i <= index; i++)
            {
                Console.Write($"{arr[i]} " );
            }
            Console.WriteLine();
            Console.WriteLine(maxCount+1);
            
        }
    }
}