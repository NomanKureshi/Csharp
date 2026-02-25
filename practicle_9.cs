using System;
class  Unboxing
{
	static void Main()
	{
		int n = 99 ;
		Object obj = n;//Boxing
		int k = (int)obj;//Unboxing 
		Console.WriteLine("Value of Integer n = "+n);
		Console.WriteLine("Value of object obj = "+obj);
		Console.WriteLine("Value of integer K = "+k);
		Console.ReadLine();
	}
}