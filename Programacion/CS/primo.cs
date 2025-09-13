/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 27-09-2024
 * Descripción: Crea un programa en C# que responda si un número introducido por el usuario es primo o no
 */ 
 


using System;
public class Primo
{
	public static void Main()
	{
		int numero, primo = 0;
		do
		{
			Console.Write("Introduce un número: ");
			numero = Convert.ToInt32(Console.ReadLine());
		}while(numero < 1);
		
		
		for(int i = 2; i * i <= numero; i++)
		{
			if (numero % i != 0)
			{
				primo = 1;
			}
		}
		
		Console.WriteLine(primo == 1 ? "{0} es primo" : "{0} no es primo", numero);
		
		
	}
}
