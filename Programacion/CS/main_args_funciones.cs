/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-12-2024
 * Descripción: Realiza un Main que reciba como primer parámetro "par", "segundo","triangulo".
Como segundo parámetro deberá recibir un entero en caso de haber puesto como primer parámetro "par",
 un número indeterminado de enteros (mínimo 2) en caso de haber puesto "segundo", y una cadena y un entero en
  caso de haber puesto "triangulo".
Para cada caso se llamará a la función correspondiente:
 par --> CuentaParImpar (ya realizada)
 segundo --> SegundoMayor(int[] numeros, int segundo) --> devuelve el segundo mayor número del array pasado como 
 parámetro.
triangulo --> NombreTriangulo (ya realizada)
Se deberán revisar que los parámetros son correctos ( el primero es una de las opciones válidas y el resto de 
parámetros se corresponden con la opción elegida en el primer parámetro) y si no lo son se deberá sacar mensaje
 con el uso correcto y se devolverá al sistema operativo un 2 en caso de todo ir correctamente se devolverá un 0.
 * 
 */

using System;
public class MainArgs
{
	public static void CuentaParImpar(int numero, out int pares, out int impares)
	{
		pares = 0;
		impares = 0;
		while (numero > 0)
		{
			if ((numero % 10) % 2 == 0)
			{
				pares++;
			}
			else 
			{
				impares++;
			}
			numero /= 10;
		}	
	}
	
	public static void SegundoMayor(int[] numeros, out int segundo)
	{
		Array.Sort(numeros);
		segundo = numeros[numeros.Length - 2];
	}
	
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
		if (args.Length == 0)
		{
			Console.WriteLine("Introduce ");
		}
		else
		{
			string eleccion = args[0];
			switch (eleccion)
			{
				case "par":
					if (args.Length == 2)
					{
						int par, impar;
						int numero = Convert.ToInt32(args[1]);
						CuentaParImpar(numero, out par, out impar);
					}
					else
					{
						
					}
					break;
				case "segundo":
					_
					break;
				case "triangulo":
					_
					break;
				default:
					_
			}
			
		}
	}
}
