/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-11-2024
 * Descripción: Crea una función llamada EsPrimo que devolverá true 
 * si el entero recibido como parámetro es primo y false si no lo es. 
 * 
 */

using System;
public class FuncionEsPrimo
{
	public static bool EsPrimo(int numero)
	{
		bool esPrimo = true;
		for (int i  = 2; i <= numero/2 && esPrimo; i++)
		{
			esPrimo = numero % i != 0;
		}
		return esPrimo;
	}
	
	public static void Main()
	{
		int numero;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(EsPrimo(numero) ? "Es primo" : "No es primo");
	}
}
