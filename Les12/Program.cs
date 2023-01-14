using System.Globalization;

namespace Les12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("Введите число от 1 до 26:");
            //int number = int.Parse(Console.ReadLine());
            ////char ch = 'A';

            //for (int i = 'A'; i < number+'A'; i++)
            //{
            //    Console.Write($"{(char)i}");
            //}
            #endregion
            #region Task2
            //string txt1 = "1233" +
            //              "sdfsdf" +
            //              "sdfsdf";

            //string txt2 = """
            //              hshdf
            //              ashdkja
            //              """;
            #endregion

            string s1 = "hello world agsdj world world  world world", 
                   s2 = "world";
            #region EQEAl
            //Console.WriteLine(s1 == s2);
            //-1 s1<s2
            //0 s1==s2
            //1 s1>s2
            //Console.WriteLine(s1.CompareTo(s2));
            #endregion
            #region Contains
            //if (s1.Contains(s2))
            //{
            //    Console.WriteLine("Yes");
            //}
            #endregion
            #region Format
            //Console.WriteLine("{0} ahsdkjahsd {1}", 100, "hello hello");

            //string txt = "{0} ahsdkjahsd {1}";
            //int par1 = 100;
            //string par2 = "hello hello";

            //string res = string.Format(txt, par1, par2);
            //Console.WriteLine(res);
            //Console.WriteLine(txt);
            #endregion
            #region IndexOf
            //Console.WriteLine(s1.IndexOf(s2));
            //Console.WriteLine(s1.LastIndexOf(s2));
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    i = s1.IndexOf(s2, i);
            //    Console.WriteLine(i);
            //    if(i == -1)
            //    {
            //        break;
            //    }
            //}
            #endregion
            #region Join
            //int[] arr = { 2, 4, 5, 8, 3, 6 };
            //Console.WriteLine(string.Join(", ", arr));
            #endregion
            #region Insert
            //string tmp = s1.Insert(5, "!!!!!");
            //Console.WriteLine(tmp);
            #endregion
            #region Replace
            //string line = Console.ReadLine();
            ////asd asdas asda dfgf
            //string tmp = line.Replace(" ",", ");
            //Console.WriteLine(tmp);
            #endregion

            string s = "I lOvE c#";
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
        }
    }
}