using System;
class Array_2D
{
	static void Main()
	{
		int[,] NK = new int[3,3];
		Console.WriteLine("Enter the elements(values) of Array :-");
		
		//loop for get the Elements(values) of the array from the User
		
		for(int n=0;n<NK.GetLength(0);n++)
		{
			for(int k=0;k<NK.GetLength(1);k++)
			{
				Console.Write("NK["+n+","+k+"] : ");
				NK[n,k] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
		//loop for print the Elements(values) of the array  
		
		for(int n=0;n<NK.GetLength(0);n++)
		{
			for(int k=0;k<NK.GetLength(1);k++)
			{
			Console.Write("SK["+n+","+k+"] = "+NK[n,k]+"  ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}