class Program
{
    public static void Main(string[] args)
    {
        #region Output
        //Console.WriteLine("Hello world");
        //Console.WriteLine(12345);
        #endregion
        #region INT
        //int   //4byte -8.. +8
        //byte  //1byte 0-255
        //int age1 = 10;
        //byte age2 = 20;
        //byte age3;
        //age3 = age1 + age2;
        #endregion
        #region Double
        //float     4byte
        //double    8byte
        //double d = 1.3;
        //1.3000000004
        #endregion
        #region
        //bool  1(4)byte -> true false
        //char -> 2byte
        //char c = 'a';
        //string n*2+ 2;// \0
        //string str = "abc чфт";
        //Console.WriteLine(str);
        #endregion

        //"1234567"
        string str = Console.ReadLine();
        Console.WriteLine(str);

        string name = "Tom";
        int age = 30;
        //Name: .... age: ...
        Console.WriteLine("Name: " + name + " age: " + age);
        Console.WriteLine("Name: {0} age: {1}", name, age);
        Console.WriteLine($"Name: {name} age: {age}");
    }
}
//int main(){

//return 0;
//}