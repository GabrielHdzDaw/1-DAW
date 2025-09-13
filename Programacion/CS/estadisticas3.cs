/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 21-10-2024
 * Descripción: Realiza un programa en C# que vaya pidiendo 
 * números reales de doble precisión hasta introducir 0 y saque el mínimo, el máximo, la suma y la media en cada paso:
Dato? 5
min = 5  max = 5 Suma=5  media=5
Dato? 4
min = 4  max= 5 Suma = 9 media= 4,5
Dato? 0
 * 
 */

using System;
public class Test
{
	public static void Main()
	{
		double numero, min, max, contador = 0, suma = 0;
		Console.Write("Dato? ");
		numero = Convert.ToDouble(Console.ReadLine());
		min = numero;
		max = numero; 
		if(numero != 0)
			{
				contador++;
				
				suma += numero;
				Console.WriteLine("min = {0}  max = {1}  suma = {2}  media = {3}", min, max, suma, suma/contador);
			}
		do
		{
			
			Console.Write("Dato? ");
			numero = Convert.ToDouble(Console.ReadLine());
			
			
			if(numero != 0)
			{
				contador++;
				if (numero > max)
				{
					max = numero;
				}
				else
				{
					if (numero < min)
					{
						min = numero;
					}
				
			}
				suma += numero;
				Console.WriteLine("min = {0}  max = {1}  suma = {2}  media = {3}", min, max, suma, suma/contador);
			}
			
		} while (numero != 0);
	}
}
