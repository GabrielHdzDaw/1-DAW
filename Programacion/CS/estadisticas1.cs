/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 21-10-2024
 * Descripción: Realiza un programa en C# que vaya pidiendo números reales de 
 * doble precisión hasta introducir 0 y saque la suma en cada paso:
Dato? 5
Suma=5
Dato? 4
Suma = 9
Dato? 0
 * 
 */

using System;
public class Estadisticas1
{
	public static void Main()
	{
		double numero, suma = 0;
		
		do
		{
			Console.Write("Dato? ");
			numero = Convert.ToDouble(Console.ReadLine());
			if(numero != 0)
			{
				suma += numero;
				Console.WriteLine("Suma = {0}", suma);
			}
			
		} while (numero != 0);
		
	}
}
