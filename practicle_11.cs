using System;
class NK
{
	static void Main()
	{
		Console.Write("Enter the size of array : ");
		int size = int.Parse(Console.ReadLine());
		int[] arr = new int[size];
		int sum=0;
		Console.WriteLine("Enter Elements of Array :- \n");
		
		for(int n=0;n<arr.Length;n++)
		{
			Console.Write("a["+n+"] : ");
			arr[n] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("\nPrint the Elements of Array :- \n");
		
		for(int n=0;n<arr.Length;n++)
		{
			Console.Write("a["+n+"] = ");
			sum +=arr[n];
			Console.WriteLine(arr[n]);
		}
		Console.WriteLine("\nSum of Array's Elements  : "+sum);
		Console.ReadLine();
	}
}
