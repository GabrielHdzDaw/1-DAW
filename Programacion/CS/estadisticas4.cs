/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 21-10-2024
 * Descripción: Realiza un programa en C# que vaya pidiendo números 
 * reales de doble precisión hasta introducir "fin" y saque el mínimo, el máximo, la suma y la media en cada paso:
Dato? 5
min = 5  max = 5 Suma=5  media=5
Dato? 4
min = 4  max= 5 Suma = 9 media= 4,5
Dato? fin
 * 
 */

using System;
public class Estadisticas4
{
	public static void Main()
	{
		string numeroString;
		double numeroDouble, min, max, contador = 0, suma = 0;
		Console.Write("Dato? ");
		numeroString = Console.ReadLine();
		numeroDouble = Convert.ToDouble(numeroString);
		min = numeroDouble;
		max = numeroDouble; 
		if(numeroString != "fin")
			{
				numeroDouble = Convert.ToDouble(numeroString);
				contador++;
				
				suma += numeroDouble;
				Console.WriteLine("min = {0}  max = {1}  suma = {2}  media = {3}", min, max, suma, suma/contador);
			}
		do
		{
			
			Console.Write("Dato? ");
			numeroString = Console.ReadLine();
			if(numeroString != "fin")
			{
				numeroDouble = Convert.ToDouble(numeroString);
				contador++;
				if (numeroDouble > max)
				{
					max = numeroDouble;
				}
				else
				{
					if (numeroDouble < min)
					{
						min = numeroDouble;
					}
				
			}
				suma += numeroDouble;
				Console.WriteLine("min = {0}  max = {1}  suma = {2}  media = {3}", min, max, suma, suma/contador);
			}
			
		} while (numeroString != "fin");
	}
}
