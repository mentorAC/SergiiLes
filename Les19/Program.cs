#region HW
//Console.WriteLine("Enter the number 0-10");
//int Num = int.Parse(Console.ReadLine());

//int[,] matrix = new int[Num, Num];

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i, j] = Math.Abs(i - j);


//        //if (i == j)
//        //{
//        //    matrix[i, j] = 0;
//        //}
//        //else
//        //{
//        //    matrix[i, j] = Math.Abs(i - j);
//        //}
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
#endregion
#region Task1
//Console.WriteLine("Enter dimention");
//var dim = Console.ReadLine().Split();

//int[,] matrix = new int[int.Parse(dim[0]), int.Parse(dim[1])];

//Random rnd = new Random();

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//	for (int j = 0; j < matrix.GetLength(1); j++)
//	{
//		matrix[i, j] = rnd.Next(0, 100);
//	}
//}
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//int Max = 0;
//for (int i = 0; i < matrix.GetLength(1); i++)
//{
//    for (int j = 0; j < matrix.GetLength(0); j++)
//    {
//        if (matrix[j, i] > Max)
//        {
//            Max = matrix[j, i]; 
//        }
//    }
//    Console.Write($"{Max} ");
//    Max = 0;
//}

#endregion
#region Task2
//var dim = Console.ReadLine().Split();

//int[,] matrix = new int[int.Parse(dim[0]), int.Parse(dim[1])];

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//	for (int j = 0; j < matrix.GetLength(1); j++)
//	{
//		if (i == 0 || i == matrix.GetLength(0) - 1)
//		{
//			matrix[i, j] = 1;
//		}
//		else
//        if (j == 0 || j == matrix.GetLength(1) - 1)
//        {
//            matrix[i, j] = 1;
//        }
//    }
//}

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {

//        //( ) ? <1>:<2>
//        Console.Write((matrix[i, j] == 1) ? "*" : " ");
//        //if (matrix[i, j] == 1)
//        //{
//        //    Console.Write("*");
//        //}
//        //else
//        //{
//        //    Console.Write(" ");
//        //}
//    }
//    Console.WriteLine();
//}
#endregion

using System.Transactions;

var dim = Console.ReadLine().Split();

int[,] matrix = new int[int.Parse(dim[0]), int.Parse(dim[1])];

for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		if (i == 0 || i == matrix.GetLength(0) -1)
		{
			matrix[i, j] = 1;
		}

        if (j == 0 || j == matrix.GetLength(1) -1)
        {
            matrix[i, j] = 1;
        }
		
    }
}

while (true)
{


	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (matrix[i, j] == 0)
			{
				Console.Write(" ");
			}
			else if (matrix[i, j] == 1)
			{
				Console.Write("*");
			}
			else if (matrix[i, j] == 5)
			{
				Console.Write("+");
			}


			//Console.Write((matrix[i, j] == 1) ? "*" : " ");
		}
		Console.WriteLine();
	}

	Console.WriteLine("Enter x y");

	var place = Console.ReadLine().Split();
	int x = int.Parse(place[0]);
	int y = int.Parse(place[1]);

	matrix[y, x] = 5;
	Console.SetCursorPosition(0, 0);
}
