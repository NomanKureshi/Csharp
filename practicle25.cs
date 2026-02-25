using System;
class Demo
{
    public static void Main()
    {
        Child obj = new Child();
        obj.size();          
        obj.FillSequential();   
        obj.Printing();  
    }
}
public class Abc
{
    public int[][] NK = new int[5][];
    public void FillSequential()
    {
        int num = 1;
        for (int i = 0; i < NK.Length; i++)
        {
            for (int j = 0; j < NK[i].Length; j++)
            {
                NK[i][j] = num;
                num++;
            }
        }
    }
    public void Printing()
    {
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