using System;
class demo
{
	static void Main()
	{
		b x = new b();
		c p = new c();
		p.method();
		Console.ReadLine();
	}
}
public class a
{
	protected void display()
	{
		Console.WriteLine("Hello parent");
	}
}
public class b : a
{
	public void print()
	{
		Console.WriteLine("Hello print child of abc");
	}
}
public class c : a
{
	public void method()
	{
		Console.WriteLine("hello pqr sub child of xyz");
		display();
		Console.WriteLine("back to sub child");
	}
} 
