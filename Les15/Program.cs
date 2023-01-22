using Figgle;

namespace Les15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTime Start
            //Random rnd = new Random();
            //1.1.1 0:0:0 -> 31.12.9999 23:59:59
            //DateTime dateTime = new DateTime();

            //Console.WriteLine(dateTime);
            //Console.WriteLine(DateTime.MinValue);
            //Console.WriteLine(DateTime.MaxValue);

            //DateTime dt1 = new DateTime(2023, 1, 21);
            //Console.WriteLine(dt1);
            //DateTime dt2 = new DateTime(2023, 1, 21, 12, 38, 5);
            //Console.WriteLine(dt2.ToString());

            //DateTime dt3 = new DateTime(2023, 2, 21);
            //Console.WriteLine(dt3);  
            #endregion
            #region DateTime NOW
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.UtcNow);
            //Console.WriteLine(DateTime.Today);//GMT

            //Console.WriteLine(DateTime.Now.DayOfWeek);

            //Console.WriteLine("Enter the year");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the month");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the day");
            //int day = int.Parse(Console.ReadLine());

            //string date = Console.ReadLine();
            //DateTime dateString = DateTime.Parse(date);
            //Console.WriteLine(dateString.DayOfWeek);
            //DateTime dt = new DateTime(year, month, day);
            //Console.WriteLine(dt.DayOfWeek);
            #endregion
            #region Add Sub
            //DateTime dateTime= DateTime.Now;
            //DateTime dateTime1 = new DateTime(2023, 2, 1);
            ////Console.WriteLine(dateTime);
            ////dateTime = dateTime.AddDays(7);
            ////Console.WriteLine(dateTime);
            ////dateTime = DateTime.Now.AddMinutes(180);
            ////Console.WriteLine(dateTime);

            ////dateTime = dateTime.AddDays(-20);

            //TimeSpan res = dateTime1.Subtract(dateTime);
            //Console.WriteLine($"{res.Days} days, {res.Hours} hours, {res.Minutes}");


            //10 days 10:45:...
            #endregion

            DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.ToLocalTime());
            //Console.WriteLine(dt.ToUniversalTime());

            //Console.WriteLine(dt.ToLongDateString());
            //Console.WriteLine(dt.ToLongTimeString());
            //Console.WriteLine(dt.ToShortTimeString());

            //Console.WriteLine(dt.ToString("d/M/y"));
            //Console.WriteLine(dt.ToString("dd/MM/yyyy hh:mm:ss tt"));
            //Console.WriteLine(dt.ToString(""));

            //while (true)
            //{
            //    //\n 
            //    //\r
            //    //\a - 
            //    //\t - tab
            //    //\b - backspace
            //    Console.Write($"\r{DateTime.Now}     ");
            //    //Thread.Sleep(500);
            //    //Console.Clear();
            //}


            //string str = "hello world";
            //Console.WriteLine(str);
            //string text = FiggleFonts.Standard.Render(str);
            //Console.WriteLine(text);

            string text = Console.ReadLine();
            string newText = FiggleFonts.Tengwar.Render(text);
            Console.WriteLine(newText); 

        }
    }
}

