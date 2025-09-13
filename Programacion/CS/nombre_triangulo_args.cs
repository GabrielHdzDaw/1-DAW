/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-12-2024
 * Descripción: Realiza una función llamada NombreTriangulo que reciba un nombre y un entero como parámetro
 *  y muestre un triángulo de la altura pasada como entero formado por última letras del nombre.
Ejemplo : NombreTriangulo(Mari Chelo,5)
    o
   lo
  elo
 helo
Chelo
NombreTriangulo(Mari Chelo, 20)
          o
         lo
        elo
       helo
      Chelo
      Chelo
    i Chelo
   ri Chelo
  ari Chelo
 Mari Chelo
 * 
 */

using System;
public class NombreTrianguloArgs
{
	public static void NombreTriangulo(string nombre, int altura)
	{
		altura = altura > nombre.Length ? nombre.Length : altura;
		for (int i = 1; i <= altura; i++)
		{
			for (int j = nombre.Length; j >= i; j--)
			{
				Console.Write(" ");
			}
			Console.Write(nombre.Substring(nombre.Length - i));
			Console.WriteLine();
		}
	}
	
	public static void Main()
	{
		NombreTriangulo("Lentejas de papá", 25);
	}
}
