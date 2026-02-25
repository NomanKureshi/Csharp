using System;
class Full_Dynamic_Jagged_Array
{
	static void Main()
	{
		Console.Write("Enter the size of 2D Jagged Array's Rows: ");
		int r = int.Parse(Console.ReadLine());
		int[][] NK = new int[r][];
		Console.WriteLine("\nEnter the size of Columns for each Rows :- \n");
		//Loop for get all Row's Columns size from the User
		
		for(int n=0;n<NK.Length;n++)
		{
			Console.Write("NK["+n+"] row = ");
			NK[n] = new int[int.Parse(Console.ReadLine())];
		}
		Console.WriteLine();	
		//Loop for get all Elements from the User
		
		for(int n=0;n<NK.Length;n++)
		{
			for(int k=0;k<NK[n].Length;k++)
			{
				Console.Write("NK ["+n+"]["+k+"] : ");
				NK[n][k] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
		
		//Loop for Print all Elements
		
		for(int n=0;n<NK.Length;n++)
		{
			for(int k=0;k<NK[n].Length;n++)
			{
				Console.Write("NK ["+n+"]["+k+"] = "+NK[n][k]+"  ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}
