/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: Pide 10 números enteros y guardalos en un array.

Después recorre ese array y cuenta cuantos hay pares y cuantos impares.(el 0 lo consideraremos par)
A continuación crea 2 arrays uno para los pares y otro para los impares.

Recorre el array original y copia los números pares en el array de pares y el de los impares en el array de impares.
 * 
 */

using System;
public class ParImparArrays
{
	public static void Main()
	{
		int contadorPar = 0, contadorImpar = 0;
		int[] numeros = new int[10];
		
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Introduce un número: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			if (numeros[i] % 2 == 0)
			{
				contadorPar++;
			}
			else
			{
				contadorImpar++;
			}
		}
		Console.WriteLine("Pares: {0}  Impares:{1}", contadorPar, contadorImpar);
		
		int[] pares = new int[contadorPar];
		int[] impares = new int[contadorImpar];
		
		int indicePar = 0, indiceImpar = 0;
		
		for (int i = 0; i < numeros.Length; i++)
		{
			if (numeros[i] % 2 == 0)
			{
				pares[indicePar] = numeros[i];
				indicePar++;
			}
			else
			{
				impares[indiceImpar] = numeros[i];
				indiceImpar++;
			}
		}
		
		for (int i = 0; i < pares.Length; i++)
		{
			Console.Write("{0} ", pares[i]);
		}
		Console.WriteLine();
		for (int i = 0; i < impares.Length; i++)
		{
			Console.Write("{0} ", impares[i]);
		}
	}
}
