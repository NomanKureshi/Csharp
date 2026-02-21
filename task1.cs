using System;
class Demo
{
    public static void Main()
    {
        Child obj = new Child();
        obj.size();          
        obj.FillWithOne();   
        obj.Printing();  
	}
}
public class Abc
{
    public int[][] NK = new int[5][];

    public void FillWithOne()
    {
        for (int i = 0; i < NK.Length; i++)
        {
            for (int j = 0; j < NK[i].Length; j++)
            {
                NK[i][j] = 1;
            }
        }
    }

    public void Printing()
    {
        Console.WriteLine("\nPrinting Jagged Array:");

        for (int i = 0; i < NK.Length; i++)
        {
            for (int j = 0; j < NK[i].Length; j++)
            {
                Console.Write(NK[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

public class Child : Abc
{
    public void size()
    {
        NK[0] = new int[5];
        NK[1] = new int[1];
        NK[2] = new int[3];
        NK[3] = new int[1];
        NK[4] = new int[5];
    }
}