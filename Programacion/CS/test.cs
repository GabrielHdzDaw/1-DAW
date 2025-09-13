using System;
public class Test
{
	public static void Main()
	{
			Console.Write("Introduce un número: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduce otro número: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			if (num2 != 0)
			{	
			int cociente = num1/num2;
			int resto = num1%num2; 
			Console.WriteLine("El cociente es {0} y el resto {1}", cociente, resto);
			} else
			{
				Console.WriteLine("No se puede dividir por 0");
			}
			 	
		}
}

