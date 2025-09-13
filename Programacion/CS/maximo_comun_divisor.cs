/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 01-10-2024
 * Descripción: Crea un programa en C# que nos diga el
 *  máximo común divisor de  2 números suministrados por el usuario
 */ 
 


using System;
public class MaximoComunDivisor
{
	public static void Main()
	{
		int numero1, numero2, i;
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		numero2 = Convert.ToInt32(Console.ReadLine());
		i = numero1 < numero2 ? numero1 : numero2;
		
		while(i != 0 && (numero1 % i != 0 || numero2 % i != 0))
		{
			i--;
		}
		Console.WriteLine("El máximo comun divisor de {0} y {1} es {2}", numero1, numero2, i);
	}
}
