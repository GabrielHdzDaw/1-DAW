/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Realiza un programa en C# que pida dos números reales
 *  de doble precisión y muestre el resultado de su división. Controla que el divisor no sea 0.


 */ 
 


using System;
public class DivisionDoblesReales
{
	public static void Main()
	{
		double numero1, numero2;
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		numero2 = Convert.ToDouble(Console.ReadLine());
		
		if(numero2 != 0)
		{
			Console.WriteLine("{0} / {1} = {2}", numero1, numero2, numero1 / numero2);
		}
		else
		{
			Console.WriteLine("No se puede dividir entre 0");
		}
	}
}
