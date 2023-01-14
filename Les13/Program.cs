using System.Text;

namespace Les13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Split
            //Split

            //string s1 = "hello@world, agsdj_world,,world@world,@world";
            //char[] sep = ".,@ ".ToCharArray();
            //string[] words = s1.Split(".,@ ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join('\n', words));
            #endregion
            #region TRIM
            //Trim
            //string s3 = "_...hello world..!..@";
            //Console.WriteLine(string.Join('\n', s3.Split()));
            //Console.WriteLine(s3.Trim('.', '@', '!', '_'));
            #endregion
            #region Task1
            //".,!?"
            //string s1 = "hello world,   agsdj? world! world, world,";//Console.ReadLine();
            //string[] s2 = s1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < s2.Length; i++)
            //{
            //    Console.WriteLine(s2[i].Trim(".,!?".ToCharArray()));
            //}
            #endregion
            #region Task2
            //StringBuilder stringBuilder = new StringBuilder();
            ////string s = "";
            //for (int i = 0; i < 100000; i++)
            //{//"5" "99999"
            //    stringBuilder.Append(i.ToString()) ;
            //    //s += i.ToString();
            //}

            ////Console.WriteLine(s);
            //Console.WriteLine(stringBuilder.ToString().Length);
            #endregion

            //string s1 = "hello world,   agsdj? world! world, world,";
            Console.WriteLine(Console.ReadLine().Split().Length + 1);
        }
    }
}