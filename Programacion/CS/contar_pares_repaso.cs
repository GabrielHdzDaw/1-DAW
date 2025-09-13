/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 07-10-2024
 * Descripción: Crea un programa que pida al usuario 2 números enteros 
 * "n1" y "n2" y asigne a la variable "numerosPares" los valores 0, 1 o 2, dependiendo de cuantos de ellos sean pares.

0 si hay 0 números pares

1 si hay 1 número par

2 si los 2 números son pares
 */ 
 


using System;
public class ContarPares
{
	public static void Main()
	{
		int num1, num2, numerosPares;
		Console.Write("Introduce un número: ");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		num2 = Convert.ToInt32(Console.ReadLine());
		
		numerosPares = num1 % 2 == 0 && num2 % 2 == 0 ? 2 : num1 % 2 != 0 && num2 % 2 != 0 ? 0 : 1;
		
		Console.WriteLine(numerosPares);
	}
}
