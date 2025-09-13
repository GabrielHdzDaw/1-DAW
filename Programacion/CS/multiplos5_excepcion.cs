/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 07-10-2024
 * Descripción: Realiza un programa en C# que pida números al usario
 *  hasta que este introduzca un 0. Deberá contar los
 *  que son múltiplos de 5 y el 0 final no debe ser contado.
 *  Debes capturar la excepción en caso de no introducir un número.
 */ 
 


using System;
public class Multiplos5Excepcion
{
	public static void Main()
	{
		int num = 1, contador = 0;
		do
		{
			try
			{
				Console.Write("Introduce un número: ");
				num = Convert.ToInt32(Console.ReadLine());
				
			if (num % 5 == 0 && num != 0)
			{
				contador++;
			}
			}
			catch (FormatException)
			{
				Console.WriteLine("Formato no válido. Solo admite números enteros.");
			}
			
		} while (num != 0);
		
		Console.WriteLine(contador);
		
	}
}
