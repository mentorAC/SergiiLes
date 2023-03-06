//using Figgle;
using Figgle;

#region DateTime
//DateTime date = new DateTime(2023, 2, 26);

//string sDate = date.ToString();
//Console.WriteLine(sDate);

//Console.WriteLine(date.AddDays(-2));
//Console.WriteLine(DateTime.Now);
//Console.WriteLine("<------->");

//var span = date.Subtract(DateTime.Now);
//var str = $"{span.Days} days " +
//          $"{span.Hours}:{span.Minutes}:{span.Seconds}";
//Console.WriteLine(str);

//dll
//lib
#endregion

//string text = "Text";
//string renderText = FiggleFonts.Standard.Render(text) ;
//Console.WriteLine(renderText);
//string userText = Console.ReadLine();
//string renderText = FiggleFonts.Starwars.Render(userText);
//Console.WriteLine(renderText);

//while (true)
//{
//    Console.Write($"{DateTime.Now}\t\r");
//    Thread.Sleep(1000);
//    //Console.Clear();
//}
Console.CursorVisible = false;
for (int k = 0; k < 10; k++)
{
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			Console.Write(k);
		}
		Console.WriteLine();
	}
	Console.SetCursorPosition(0,0);
    Thread.Sleep(250);
    //Console.Clear();
    if (k == 9)
	{
		k = -1;
	}
}
