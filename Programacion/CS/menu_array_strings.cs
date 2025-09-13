/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 08-11-2024
 * Descripción: Crea un programa para gestionar un array de nombres.
 *  Deberá tener el siguiente menú: (Recordad hacer cada opción en una función)
1. Añadir 10 cadenas (rellena el array completo)
2. Buscar un nombre en concreto
3. Buscar los nombres que comiencen por un texto posterior a la introducida por el usuario
4. Buscar un nombre que contenga un texto introducido por el usuario
5. Salir
 *  
 */

using System;
public class MenuArrayStrings
{
	public static void Main()
	{
		string[] nombres = new string[10];
		char seleccionUsuario;
		string nombreBuscar, textoComparar, textoContiene;
		bool salir = false;
		bool encontrado = false;
		
		for (int i = 0; i < nombres.Length; i++)
		{
			Console.Write("Introduce un nombre: ({0} de {1}): ", i + 1, nombres.Length);
			nombres[i] = Console.ReadLine();
		}
		
		while (!salir)
		{
			Console.WriteLine("1. Añadir {0} cadenas", nombres.Length);
			Console.WriteLine("2. Buscar un nombre en concreto");
			Console.WriteLine("3. Buscar los nombres que comiencen por un texto posterior a la introducida por el usuario");
			Console.WriteLine("4. Buscar un nombre que contenga un texto introducido por el usuario");
			Console.WriteLine("5. Salir");
			Console.Write("\nSelecciona una de las opciones: ");
			seleccionUsuario = Convert.ToChar(Console.ReadLine());
			
			if (!salir)
			{
				switch (seleccionUsuario)
				{
				case '1':
					for (int i = 0; i < nombres.Length; i++)
					{
						Console.Write("Introduce un nombre: ({0} de {1})", i + 1, nombres.Length);
						nombres[i] = Console.ReadLine();
					}
					break;
				case '2':
					Console.Write("Introduce nombre a buscar: ");
					nombreBuscar = Console.ReadLine().ToLower();
					for (int i = 0; i < nombres.Length && !encontrado; i++)
					{
						encontrado = nombreBuscar == nombres[i];
					}
					if (encontrado)
					{
						Console.WriteLine("Nombre encontrado.\n");
					}
					else
					{
						Console.WriteLine("Nombre no encontrado.");
					}
					break;
				case '3':
					Console.Write("Introduce texto a comparar: ");
					textoComparar = Console.ReadLine();
					for (int i = 0; i < nombres.Length; i++)
					{
						if (textoComparar.CompareTo(nombres[i]) < 0)
						{
							Console.WriteLine(nombres[i]);
						}
					}
					break;
				case '4':
					Console.Write("Introduce texto a comparar: ");
					textoContiene = Console.ReadLine();
					for (int i = 0; i < nombres.Length; i++)
					{
						if (nombres[i].Contains(textoContiene))
						{
							Console.WriteLine("{0} ", nombres[i]);
						}
						
					}
					break;
				case '5':
					salir = true;
					break;
				default:
					Console.WriteLine("Opción no válida");
					break;
				}
			}
			encontrado = false;
		}
	}
}
