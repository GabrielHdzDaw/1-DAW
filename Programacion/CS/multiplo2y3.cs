/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-09-2024
 * Descripción: Crea un programa en C# que asigne a una variable llamada multiplo un 1 si un número proporcionado por 
 * el usuario es múltiplo de 2 y de 3 y un 0 si no lo es utilizando el operador condicional.
   Tras esto saca por pantalla un mensaje adecuado.
 * 
 */

using System;
public class MultiploDe2y3
{
	public static void Main()
	{
		int num, multiplo;
		Console.Write("Introduce un número: ");
		num = Convert.ToInt32(Console.ReadLine());
		multiplo = num % 2 == 0 && num % 3 == 0 ? 1 : 0;
		Console.WriteLine(multiplo == 1 ? "Es múltiplo" : "No es múltiplo");
	}
}
