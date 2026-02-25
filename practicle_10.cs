using System;
class User_Array
{
	static void Main()
	{
		Console.Write("Enter size of Array : ");
		int size = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the Elements(Values) of Array :- \n");
		int[] arr = new int[size];
		
		for(int n=0;n<arr.Length;n++)
		{
			Console.Write("arr["+n +"] : ");
			arr[n] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Print the Elements(Values) of Array :- \n");		
		
		for(int n=0;n<arr.Length;n++)
		{
			Console.WriteLine("arr["+n +"] = "+arr[n]);
		}
	}
}
