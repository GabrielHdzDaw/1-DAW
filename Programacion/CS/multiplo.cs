
/*
 * Gabriel Hernández Collado
 * 16/09/2024
 * Comprueba si un número es múltiplo de otro
 */

using System;
public class Multiplo
{
	public static void Main()
	{
		int num1, num2;
		Console.Write("Introduce un número: ");
		num1  = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		num2  = Convert.ToInt32(Console.ReadLine());
		if (num2 != 0)
		{
			if (num1 %  num2 == 0)
			{
				Console.WriteLine("{0} es múltiplo de {1}.", num1, num2);
			} 
			else
			{	
				Console.WriteLine("{0} no es múltiplo de  {1}.", num1, num2);
			}
		}
		else
		{ 
			Console.WriteLine("No se puede dividir entre 0.");
		}
		
	}
}
