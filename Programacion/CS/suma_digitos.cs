/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-09-2024
 * Descripción: Crea un programa en C# que dado un número sumininstrado por el usuario, responda la suma de sus dígitos
 */ 
 


using System;
public class SumaDigitos
{
	public static void Main()
	{
		int numero, suma = 0, resto = 0;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		do
		{
			resto = numero%10;
			suma += resto;
			numero = numero/10;
		} while(numero != 0);
		
		Console.WriteLine("La suma de sus dígitos es: {0}", suma);
	}
}
