using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int clms = int.Parse(Console.ReadLine());
        int[,] arr = new int[rows,clms];
        Console.WriteLine("\nEnter array elements:");
       
	    for (int i=0; i <arr.GetLength(0); i++)
        {
            for (int j=0; j <arr.GetLength(1); j++)
            {
                Console.Write("Element [{0},{1}]: ",i,j);
                arr[i, j] = int.Parse(Console.ReadLine());
            }
			Console.WriteLine(" ");
        }
        Console.WriteLine("\nDuplicate elements and their counts:");
        for (int i=0; i < rows; i++)
        {
            for (int j=0; j < clms; j++)
            {
                int count = 1;
                if (arr[i,j] == -1)
                    continue;

                for (int x=i; x < arr.GetLength(0); x++)
                {
                    for (int y=0; y < arr.GetLength(1); y++)
                    {
                        if (x == i&&y <= j)
                            continue;

                        if (arr[i,j] == arr[x, y])
                        {
                            count++;
                            arr[x, y] = -1;
                        }
                    }
                }
                if (count>1)	
				{
                    Console.WriteLine("Element {0} appears {1} times",arr[i,j],count);
				}
            }
        }
    }
}