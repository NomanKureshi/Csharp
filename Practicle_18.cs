using System;
class Check_Number
{
	static void Main()
	{
		Console.WriteLine("Enter a Number to check that is Positive or Nagative Or Zero :- \n");
		Console.Write("Enter a Number : ");
		int NK_Num = int.Parse(Console.ReadLine());
		
		if(NK_Num > 0)
			Console.WriteLine("The Number is Positive");
		else if(NK_Num < 0)
			Console.WriteLine("The Number is Negative");
		else
			Console.WriteLine("The Number is Zero");
	}
}