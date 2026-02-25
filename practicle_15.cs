using System;
class Full_Dynamic_3D_Array
{
	static void Main()
	{
		Console.Write("Enter The Number of Dimension of 3D Array :- ");
		int t = int.Parse(Console.ReadLine());
		Console.Write("Enter The Number of Rows of 3D Array :- ");
		int r = int.Parse(Console.ReadLine());
		Console.Write("Enter The Number of Columns of 3D Array :- ");
		int c = int.Parse(Console.ReadLine());
		
		int[,,] NK = new int[t,r,c];
		
		Console.WriteLine("\nEnter The Elements(Values) of 3D Array :- \n");
		
		for(int n=0;n<t;n++)
		{
			for(int k=0;k<r;k++)
			{
				for(int z=0;z<c;z++)
				{
					Console.Write("NK["+n+","+k+","+z+"] : ");
					NK[n,k,z] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}		
		Console.WriteLine("Print The Elements(Values) of 3D Array :- \n");
		
		for(int n=0;n<t;n++)
		{
			for(int k=0;k<r;k++)
			{
				for(int z=0;z<c;z++)
				{
				Console.Write("SK["+n+","+k+","+z+"] : "+NK[n,k,z]+"  ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}

}
