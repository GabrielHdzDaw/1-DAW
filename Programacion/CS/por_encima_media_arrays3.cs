/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-10-2024
 * Descripción: Un programa que pida al usuario cuantas notas va a introducir. Después pida ese número de notas(double)
 *  y los guarde en un array y calcule su media.

(Primero guardamos todos los datos en el array y luego lo volvemos a recorrer para calcular la media)

y luego muestre los que están por encima de la media.
 * 
 */

using System;
public class PorEncimaMedia3
{
	public static void Main()
	{
		int cantidadNotas;
		Console.Write("Introduce número de notas: ");
		cantidadNotas = Convert.ToInt32(Console.ReadLine());
		
		double[] notas = new double[cantidadNotas];
		
		double suma = 0;
		double media;
		for (int i = 0; i < notas.Length; i++)
		{
			Console.Write("Introduce una nota: ");
			notas[i] = Convert.ToDouble(Console.ReadLine());
		}
		
		for (int i = 0; i < notas.Length; i++)
		{
			suma += notas[i];
		}
		media = suma / notas.Length;
		
		Console.WriteLine("Media: {0}", media);
		
		Console.Write("Por encima de la media: ");
		for (int i = 0; i < notas.Length; i++)
		{
			if (notas[i] > media)
			
				Console.Write("{0} ", notas[i]);
			}
		}
	}

