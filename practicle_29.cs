using System;
class demo
{
	public static void Main()
	{
		pqr p = new pqr();
		p.method();
		p.method(10);
		p.method(10.5);
		p.method("Noman");
		Console.ReadLine();
	}
}
public class pqr
{
	public void method ()
	{
		Console.WriteLine("default method");
	}
	
	public void method(int a)
	{
		Console.WriteLine("This is int: " + a);
	}
	
	public void method(double b)
	{
		Console.WriteLine("This is double: " + b);
	}
	
	public void method(string c)
	{
		Console.WriteLine("This is string: " + c);
	}
}