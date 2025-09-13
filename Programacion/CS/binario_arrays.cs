/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 04-11-2024
 * Descripción: Haz un programa que pase a binario un número pedido al usuario y lo muestre por pantalla. 
Compara tu resultado con el obtenido con .ToString().
1.- Primero se debe calcular la longitud del array donde guardar los dígitos binarios.  
Para saber a priori el tamaño del array podemos establecerlo siguiente: esta regla:

números menores de 2 -- 1 posición
números menores 4 -- 2 posiciones
números menores de 8 --- 3 posiciones
...
números menores de 2n    n posiciones

2.- Una vez establecida lo longitud se calcula el número binario haciendo las sucesivas divisiones 
y guardando los restos en el array creado anteriormente.

3.- Finalmente muestra el número binario recorriendo el array al revés.
 *  
 */

using System;
public class BinarioArrays
{
	public static void Main()
	{
		int[] numerosBinario;
		int numero, longitudArray = 1;
		Console.Write("Introduce un número: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		int contador = 1;
		while (Math.Pow(2,contador) <= numero)
		{
			contador++;
			longitudArray = contador;
		}
		
		numerosBinario = new int[longitudArray];
		
		int temporal = numero;
		for (int i = 0; i < longitudArray; i++)
		{
			numerosBinario[i] = temporal % 2;
			temporal /= 2;
		}
		
		Console.WriteLine(Convert.ToString(numero, 2));
		
		for (int i = longitudArray - 1; i >= 0; i--)
		{
			Console.Write(numerosBinario[i]);
		}
	}
}
