namespace Les02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Start
            //decimal cash = 10;
            //bool b;
            //Console.WriteLine(5/2m);
            //Console.WriteLine(Math.Pow(27, 1d/3));
            //Console.WriteLine(5/2);

            //string s = Console.ReadLine();
            ////int a = int.Parse(Console.ReadLine());
            //int a = int.Parse("1234");
            //Convert.ToInt32(,);
            #endregion

            //+-*/ %
            //123
            //1 2 3

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = a / 100;
            //int c = a % 100 / 10;
            //int d = a % 10;
            //Console.WriteLine($"{b} {c} {d}");
            //Console.WriteLine($"{d}{c}{b}");

            //12 30 00
            //21 3  0

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(a % 10 *10 + a/10);
            //Console.WriteLine(b % 10 *10 + b/10);
            //Console.WriteLine(c % 10 * 10 + c/10);

            //Console.WriteLine($"Math.Max(3, 7) = {Math.Max(3, 7)}");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int res_1 = Math.Max(a, b);
            int Max = Math.Max(c, res_1);

            int res_2 = Math.Min(a, b);
            int Min = Math.Min(c, res_2);

            Console.WriteLine($"{Max} {Min}");



        }
    }
}