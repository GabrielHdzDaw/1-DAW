/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-10-2024
 * Descripción: Realiza un programa en C# que pida enteros hasta que se
 *  introduzca "fin" y al final nos diga cuantos pares e impares se han introducido. 
 * El 0 no se contabilizará ni como par ni como impar.
 * 
 */

using System;
public class CuentaPares
{
	public static void Main()
	{
		string numeroString;
		int numeroInt, contadorPares = 0, contadorImpares = 0;
		
		do
		{
			Console.Write("Introduce un número: ");
			numeroString = Console.ReadLine();
			if(numeroString != "fin")
			{
				numeroInt = Convert.ToInt32(numeroString);
				if(numeroInt != 0 && numeroInt % 2 == 0)
				{
					contadorPares++;
				}
				else
				{
					if (numeroInt != 0)
					{
						contadorImpares++;
					}
					
				}
				
			}
		} while (numeroString != "fin");
		Console.WriteLine("Pares: {0} Impares: {1}", contadorPares, contadorImpares);
		
	}
}
