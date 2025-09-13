
/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 05-11-2024
 * Descripción: Ahora vamos a hacer un array de 3 bloques pero se le pedirá 
 * al usuario el tamaño de cada uno de estos bloques.
Una vez definido el array, se pedirán los datos y se mostrará la media,
 el mayor y el menor de cada uno de estos bloques.
A continuación pide números al usuario hasta que introduzca un 0 y se
 le irá indicando si el número está en el array de arrays.
 */

using System;
public class Test
{
	
	public static void Main()
	{
		int[][] numeros = new int[3][];
		double[] suma = new double[numeros.Length];
		double[] mayores = new double[numeros.Length];
		double[] menores = new double[numeros.Length];
		double numeroBusqueda;
		bool numeroEncontrado = false;
		
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Introduce tamaño array {0}: ", i);
			numeros[i] = new int[Convert.ToInt32(Console.ReadLine())];
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			for (int j = 0; j < numeros[i].Length; j++)
			{
				Console.Write("Introduce un número {0}, {1}: ", i+1, j+1);
				numeros[i][j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			for (int j = 0; j < numeros[i].Length; j++)
			{
				suma[i] += numeros[i][j];
			}
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			mayores[i]=numeros[i][0];
            menores[i]=numeros[i][0];
            
			for (int j = 0; j < numeros[i].Length; j++)
			{
				mayores[i] = mayores[i] > numeros[i][j] ? mayores[i] : numeros[i][j];
				menores[i] = menores[i] < numeros[i][j] ? menores[i] : numeros[i][j];
			}
		}
		
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Números {0}: ", i);
			for (int j = 0; j < numeros[i].Length; j++)
			{
				Console.Write("{0} ", numeros[i][j]);
			}
			Console.WriteLine("| Media: {0} | mayor: {1} | menor: {2}", suma[i] / numeros[i].Length, mayores[i], menores[i]);
		}
		
		do
		{
			Console.Write("Introduce número a buscar: ");
			numeroBusqueda = Convert.ToDouble(Console.ReadLine());
			
			int i = 0, j = 0;
			
			if (numeroBusqueda != 0)
			{
				while (i < numeros.Length && !numeroEncontrado)
				{
					j = 0;
					while (j < numeros[i].Length && !numeroEncontrado)
					{
						if (numeros[i][j] == numeroBusqueda)
						{
							numeroEncontrado = true;
						}
						j++;
					}
				i++;
				}
			}
			if (numeroBusqueda != 0)
			{
				Console.WriteLine(numeroEncontrado ? "Número {0} encontrado" : "Número {0} no encontrado", numeroBusqueda);
			}
			
		} while (numeroBusqueda != 0);
		
		
		
	}
	
}
