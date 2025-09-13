/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 23-09-2024
 * Descripción: Realiza un programa de C# que pedirá un número de forma repetitiva
 *  y dirá si el número introducido es par o impar. Dejará de pedir números cuando se introduzca un 0.
   Realiza este programa con while y con do while.
 * 
 */

using System;
public class Test
{
	public static void Main()
	{
		int numero;
		numero = 1;
		//while(numero != 0)
		//{
			//if (numero != 0)
			//{
				//if (numero % 2 == 0)
				//{
					//Console.WriteLine("{0} es par.", numero);
				//}
				//else
				//{
					//Console.WriteLine("{0} es impar.", numero);
				//}
			//}
		//}
		
		do
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToInt32(Console.ReadLine());
			if (numero != 0)
			{
				if (numero % 2 == 0)
				{
					Console.WriteLine("{0} es par.", numero);
				}
				else
				{
					Console.WriteLine("{0} es impar.", numero);
				}
			}
			
		} while(numero != 0);
		
	}
}
