
/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 21-10-2024
 * Descripción: Se deben ir pidiendo enteros por pantalla y cuando se
 *  introduzca un "fin" Se sacarán los siguientes resultados:
Cuantos con 1 dígito, cuantos con 2 dígitos, cuantos con 3 dígitos y cuantos con más de 3 dígitos.
Excepto el 0 que no lo vamos a considerar.
 */

using System;
public class ContarDigitos2
{
	public static void Main()
	{
		int numero, contadorDigitos = 0, contador1 = 0, contador2 = 0, contador3 = 0, contadorMas3 = 0;
		string numeroString;
		
		do
		{
			Console.Write("Introduce un número: ");
			numeroString = Console.ReadLine();
			if(numeroString != "fin" && numeroString != "0")
			{
				numero = Convert.ToInt32(numeroString);
				
				do
				{
					contadorDigitos++;
					numero = numero/10;
					
				} while (numero != 0);
				
				
				if (contadorDigitos == 1)
				{
					contador1++;
				}
				else
				{
					if (contadorDigitos == 2)
					{
						contador2++;
					}
					else
					{
						if (contadorDigitos == 3)
						{
							contador3++;
						}
						else
						{
							contadorMas3++;
						}
					}
				}
			}
			contadorDigitos = 0;
		} while (numeroString != "fin");
		Console.WriteLine("un dígito: {0}\ndos dígitos: {1}\ntres dígitos: {2}\nmás de tres dígitos: {3}", contador1, contador2, contador3, contadorMas3);
	}
	
}
