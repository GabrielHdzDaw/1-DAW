/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 22-10-2024
 * Descripción:  Un número Harshad es un número que es divisible por la suma de sus dígitos. 
 * https://es.wikipedia.org/wiki/N%C3%BAmero_de_Harshad

Realiza un programa que pida números al usuario hasta que introduzca la palabra "fin" y 
conteste si es un número Harshad o no.
Número: 152
Sí es un número Harshad
Número: 121
No es un número Harshad
 * 
 */

using System;
public class Harshad
{
	public static void Main()
	{
		int numero, numeroOriginal = 0, resto, suma = 0;
		string numeroString;
		bool esHarshad = false;
		
		do
		{
			Console.Write("Introduce un número:");
			numeroString = Console.ReadLine();
			if (numeroString != "fin")
			{
				numero = Convert.ToInt32(numeroString);
				numeroOriginal = numero;
				if (numero >= 10)
				{
					while (numero != 0)
					{
						resto = numero%10;
						suma += resto;
						numero /= 10;
					}
					esHarshad = numeroOriginal % suma == 0 ? true : false;
					if (numeroString != "fin")
					{
						Console.WriteLine(esHarshad ? "{0} es número Harshard" : "{0} no es número Harshard", numeroOriginal);
					}
					resto = 0;
					suma = 0;
				}
			}
			
		} while (numeroString != "fin");
		
	}
}
