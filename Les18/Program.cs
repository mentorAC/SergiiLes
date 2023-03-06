
#region Proj
//using Figgle;
//Console.WriteLine("Hello, write your deadline here: yyyy.mm.dd");
//string[] deadline = Console.ReadLine().Split(".");
//int year = int.Parse(deadline[0]);
//int month = int.Parse(deadline[1]); ;
//int day = int.Parse(deadline[2]); ;
//DateTime date = new DateTime(year, month, day);



//while (true)
//{
//    var span = date.Subtract(DateTime.Now);

//    var str = $"{span.Days} days    " +
//              $"{span.Hours} hours:  {span.Minutes} : {span.Seconds}      ";

//    Console.CursorVisible = false;
//    Console.SetCursorPosition(0, 0);

//    string renderText = FiggleFonts.Standard.Render(str);
//    Console.WriteLine($"{renderText}");

//    Thread.Sleep(1000);
//    //Console.Clear();
//}

#endregion
#region Task1
//Console.WriteLine("Enter your matrix 3x3 row  by row:");

//int row = 3;
//int col = 3;

//int[,] matrix = new int[row, col];

//for (int i = 0; i < row; i++)
//{
//    string strRow = Console.ReadLine();
//    string[] arrRow = strRow.Split(StringSplitOptions.RemoveEmptyEntries);
//    for (int j = 0; j < col; j++)
//    {
//        matrix[i, j] = int.Parse(arrRow[j]);
//    }
//}

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}

//1 2 3
//4 5 6
#endregion
#region Task2
//1 2 3
//4 5 6
//7 8 9

//1 4 7
//2 5 8
//3 6 9
//int row = 2;
//int col = 4;

//int[,] matrix= new int[row, col];

//Random rnd = new Random();

//for (int i = 0; i< matrix.GetLength(0); i++)
//{
//	for (int j = 0; j < matrix.GetLength(1); j++)
//	{
//		matrix[i, j] = rnd.Next(0,10);
//	}
//}

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write(matrix[i, j]+" " );
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//for (int i = 0; i < matrix.GetLength(1); i++)
//{
//    for (int j = 0; j < matrix.GetLength(0); j++)
//    {
//        Console.Write(matrix[j, i]+" ");
//    }
//    Console.WriteLine();
//}
#endregion
#region Task 3
//int row = 4;
//int col = 10;

//int[,] matrix = new int[row, col];

//Random rnd = new Random();

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i, j] = rnd.Next(0, 10);
//    }
//}
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//int Sum = 0;
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            Sum += matrix[i, j];
//        }
//    }

//}
//Console.WriteLine(Sum);
//Sum = 0;
//for (int i = 0; i < Math.Min(matrix.GetLength(1), matrix.GetLength(0)); i++)
//{
//    Sum += matrix[i, i];
//}
//Console.WriteLine(Sum);

#endregion

using System.Text.Json.Serialization;

char[,] matrix = new char[4, 8];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = ' ';
    } 
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i < matrix.GetLength(0) / 2)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        else
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        Console.Write($"{matrix[i, j]} ");

        Console.ResetColor();
    }
    Console.WriteLine();
}

