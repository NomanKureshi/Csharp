using  System;
class Jagged_3D_Arr
{
	static void Main()
	{
		Console.Write("Enter The Dimensions Size of 3D Jagged Array : ");
		int d = int.Parse(Console.ReadLine());
		int[][][] NK = new int[d][][];
		Console.WriteLine("\nEnter The Row Size for each Dimensions : \n");  
		
		//Loop for getting size of rows Size for each Dimensions from the User
		for(int n=0;n<NK.Length;n++)
		{
			Console.Write("NK[{0}] : ",n);
			NK[n] = new int[int.Parse(Console.ReadLine())][];
		}
		
		Console.WriteLine("\nEnter the Columns Size for each Rows");
		//Loop for getting size of Columns Size for each row from the User
		for(int n=0;n<NK.Length;n++)
		{
			for(int k=0;k<NK[n].Length;n++)
			{
				Console.Write("NK[{0}][{1}] : ",n,k);
				NK[n][k] = new int[int.Parse(Console.ReadLine())];
			}                             
			Console.WriteLine();
		}

		Console.WriteLine("\nGet all the Elements from the User");
		//Loop for get all Elements from the user
		for(int n=0;n<NK.Length;n++)
		{
			for(int k=0;k<NK[n].Length;k++)
			{
				for(int f=0;f<NK[n][k].Length;f++)
				{
                Console.Write("NK[{0}][{1}][{2}] : ",n,k,f);
				NK[n][k][f] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}	
		Console.WriteLine("\nPrint all the Elements");
		//Loop for print all the  Elements 
		for(int n=0;n<NK.Length;n++)
		{
			for(int k=0;k<NK[n].Length;k++)
			{
				for(int f=0;f<NK[k].Length;f++)
				{
                Console.Write("NK[{0}][{1}][{2}] : {3}  ",n,k,f,NK[n][k][f]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}