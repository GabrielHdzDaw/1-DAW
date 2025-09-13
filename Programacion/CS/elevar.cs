/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 03-10-2024
 * Descripción: Crea un programa que calcule un nu´mero elevado a otro, usando multiplicaciones sucesivas
 */ 
 


using System;
public class Elevar
{
	public static void Main()
	{
		int numero, exponente, resultado;
		
		Console.Write("Introduce un número:");
		numero = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un exponente:");
		exponente = Convert.ToInt32(Console.ReadLine());
		resultado = numero;
		for (int i = 1; i < exponente; i++)
		{
			resultado *= numero;
		}
		Console.WriteLine(resultado);
		
	}
}
