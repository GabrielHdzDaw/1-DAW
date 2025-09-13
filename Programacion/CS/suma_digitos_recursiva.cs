/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 29-11-2024
 * Descripción: Realiza una función  que sume los dígitos recibidos como parámetro de forma recursiva
 * 
 */

using System;
public class SumaDigitosRecursiva
{
	public static int SumaDigitos(int numero)
	{
		if (numero /10 == 0)
		{
			return numero;
		}
		return (numero % 10) + SumaDigitos(numero / 10);
	}
	public static void Main()
	{
		Console.WriteLine(SumaDigitos(136));
	}
}
