using System;
public class Par
{
	public static void Main()
	{
		int num;
		Console.Write("Introduce un número: ");
		num  = Convert.ToInt32(Console.ReadLine());
		if (num %  2 == 0)
		{
			Console.WriteLine("{0} es par.", num);
		} 
		else
		{
			Console.WriteLine("{0} es impar.", num);
		}
	}
}
