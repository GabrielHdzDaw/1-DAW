/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-11-2024
 * Descripción: Un programa capaz de sumar dos números enteros muy grandes (por
ejemplo, de 50 cifras), que se deberán pedir como cadena de texto y analizar letra
a letra (pista: tendrás que pensar cómo sumas dos números a mano: qué ocurre si
al suma cifra a cifra obtienes un número mayor que 10 y cómo tratar el caso de
que los dos números no tengan la misma longitud).
 * 
 */

using System;
public class Test
{
	public static void Main()
	{
		string numero1, numero2;
		int n1, n2, sumaN1N2, meLlevo = 0;
		string resultado;
		Console.Write("Introduce el primer número: ");
		numero1 = Console.ReadLine();
		Console.Write("Introduce el segundo número: ");
		numero2 = Console.ReadLine();
		
		for (int i = numero1.Length; i > 0 ; i--)
		{
			n1 = Convert.ToInt32(numero1[i]);
			n2 = Convert.ToInt32(numero2[i]);
			sumaN1N2 = n1 + n2 > 10 ? (n1 + n2) - 10 : n1 + n2;
			meLlevo = n1 + n2 > 10 ? 1 : 0;
			
		}
	}
}
