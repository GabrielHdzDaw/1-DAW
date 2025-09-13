/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 04-11-2024
 * Descripción: Crea un programa que pida al usuario 10 números reales, 
 * los guarde en dos arrays de 5 posiciones llamados datos1 y datos2 y 
 * después los muestre. Primero los del primer array y luego los del segundo.
 * 
 */

using System;
public class ValoresDosArrays
{
	public static void Main()
	{
		double[] datos1 = new double[5];
		double[] datos2 = new double[5];
		double numero;
		
		for (int i = 0; i < datos1.Length; i++)
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToDouble(Console.ReadLine());
			datos1[i] = numero;
		}
		for (int i = 0; i < datos2.Length; i++)
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToDouble(Console.ReadLine());
			datos2[i] = numero;
		}
		
		for (int i = 0; i < datos1.Length; i++)
		{
			Console.Write("{0} ", datos1[i]);
		}
		for (int i = 0; i < datos2.Length; i++)
		{
			Console.Write("{0} ", datos2[i]);
		}
	}
}
