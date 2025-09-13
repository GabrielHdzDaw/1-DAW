/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 22-10-2024
 * Descripción: La sucesión de Fibonacci se define de la forma siguiente:
 *  el elemento 0 vale 0 y el elemento 1 vale 1. Cualquier elemento posterior 
 * n+1 es la suma de los que le preceden, (el tercer elemento es 0+1=1, el cuarto
 *  es 1+1=2, el quinto es 1+2=3 y así sucesivamente) por lo que se obtiene la 
 * secuencia.0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89...    Además, esta sucesión
 *  tiene muchas propiedades curiosas, como por ejemplo que el término n+1 dividido
 *  por el término n se acerca cada vez más al valor de la "proporción áurea", (1+Raíz(5))/2 = 1,6180339887...

Deberás crear un programa en C# que pregunte al usuario un número entero n y 
muestre el término n-simo de sucesión de Fibonacci y el resultado de dividir 
ese término entre el anterior. Por ejemplo, si el usuario introduce 8, las 
respuestas serían 21 (que es el término 8) y 1,615384615384615  (que es el resultado de dividir 21/13) (2 puntos).
 * 
 */

using System;
public class Fibonacci
{
	public static void Main()
	{
		int numeroTerminos, elementoActual = 1, elementoAnterior = 0, temporal = 0; 
		
		Console.Write("Introduce número de términos: ");
		numeroTerminos = Convert.ToInt32(Console.ReadLine());
		for (int i = 1; i < numeroTerminos; i++)
		{
			temporal = elementoActual;
			elementoActual += elementoAnterior;
			elementoAnterior = temporal;
		}
		Console.Write("Término {0}: {1}  Proporción áurea: {2}", numeroTerminos, elementoActual, 
		(double)elementoActual / (double)elementoAnterior);
	}
}
