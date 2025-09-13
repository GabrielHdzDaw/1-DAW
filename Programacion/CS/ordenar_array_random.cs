/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 28-11-2024
 * Descripción: Crea un programa que genere un array, lo rellene con 100 números 
 * reales al azar entre -1000 y 1000 con dos cifras decimales (números como -123,45).
 *  Luego deberá ordenar los datos y mostrarlos.
 * 
 */

using System;
public class OrdenarArray
{
	public static void Main()
	{
		Random generator = new Random();
		double[] numeros = new double[100];
		
		for (int i = 0; i < numeros.Length; i++)
		{
			numeros[i] = generator.Next(-100000, 100001) / 100.0;
		}
		Array.Sort(numeros);
		for (int i = 0; i <  numeros.Length; i++)
		{
			Console.WriteLine(numeros[i]);
		}
	}
}
