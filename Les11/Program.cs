namespace Les11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //char[] word = { 'a', 'b' };

            //string s1 = "hello world😂";
            //Console.WriteLine(s1);

            //int a = 5;
            //double b = a;
            //a = (int)b;

            //char ch = (char)6;
            //Console.WriteLine(ch);


            //for (int i = 0; i < 255; i++)
            //{
            //    Console.Write($"{(char)i} ");
            //}
            #endregion
            #region Task2
            //char ch = char.Parse(Console.ReadLine());
            ////int a = (int)ch;

            //if(ch >= 'A' && ch <= 'Z')
            //{

            //    //a += 32; 
            //    //ch += 10;
            //    Console.WriteLine((char)ch + ' ');
            //}
            //else 
            //{
            //    Console.WriteLine((char)(ch - ' '));
            //    //a -= 32;
            //}
            //Console.WriteLine((char)a);
            #endregion
            string s1 = new string('@', 10);
            //Console.WriteLine(s1);
            char[] chars = { 'a', 'b', 'c', 'd'};
            string s2 = new string(chars);
            //Console.WriteLine(s2);
            //for (int i = 0; i < s2.Length; i++)
            //{
            //    Console.WriteLine(s2[i]);
            //}


            Console.WriteLine(s1[3]);
            //s1[3] = '#';
            Console.WriteLine(s1[3]);
            s1 = "asdasdas";

            string s4 = "";
            s4 += s1;
            s4 += s2;
            Console.WriteLine(s4);
        }
    }
}