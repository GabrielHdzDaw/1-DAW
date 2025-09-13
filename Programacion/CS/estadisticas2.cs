/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 21-10-2024
 * Descripción: Realiza un programa en C# que vaya pidiendo números 
 * reales de doble precisión hasta introducir 0 y saque la suma y la media en cada paso:
Dato? 5
Suma=5  media=5
Dato? 4
Suma = 9 media= 4,5
Dato? 0
 * 
 */

using System;
public class Estadisticas2
{
	public static void Main()
	{
		double numero, contador = 0, suma = 0;
		
		do
		{
			Console.Write("Dato? ");
			numero = Convert.ToDouble(Console.ReadLine());
			if(numero != 0)
			{
				contador++;
				suma += numero;
				Console.WriteLine("Suma = {0}  media = {1}", suma, suma/contador);
			}
			
		} while (numero != 0);
		
	}
}
