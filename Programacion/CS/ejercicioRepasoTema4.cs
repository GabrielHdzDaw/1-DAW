/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 20-11-2024
 * Descripción:
 * 
 */

using System;
public class EjercicioRepasoTema4
{
	
	public static void Main()
	{
		string[] cadenas = 
		{
		"Hola mundo",
		"El cielo es azul",
		"Sueña en grande",
		"El tiempo vuela",
		"Nunca te rindas",
		"La vida es bella",
		"Todo es posible",
		"Confía en ti",
		"Sigue aprendiendo",
		"Ama y vive",
		"El sol brilla",
		"Ríe más fuerte",
		"Paso a paso",
		"La calma llega",
		"Sé tú mismo",
		"Nada es fácil",
		"Piensa positivo",
		"Valora el presente",
		"Anilina",
		"Reconocer"
		};
		
		bool salir = false;
		char eleccion;
		
		while (!salir)
		{
			Console.WriteLine("0. Mostrar array");
			Console.WriteLine("1. Concatenar todas las cadenas");
			Console.WriteLine("2. Palabras más largas");
			Console.WriteLine("3. Convertir todas las palabras a mayúsculas");
			Console.WriteLine("4. Reemplazar vocales por un carácter en todas las cadenas");
			Console.WriteLine("5. Filtrar palabras por longitud");
			Console.WriteLine("6. Ordenar palabras alfabéticamente");
			Console.WriteLine("7. Contar la frecuencia de palabras específicas");
			Console.WriteLine("8. Dividir cadenas largas en palabras individuales");
			Console.WriteLine("9. Cadenas palíndromas en un array");
			Console.WriteLine("s. Salir");
			
			eleccion = Convert.ToChar(Console.ReadLine());
			Console.WriteLine();
			switch (eleccion)
			{
				case '0':
					for (int i = 0; i < cadenas.Length; i++)
					{
						Console.WriteLine(cadenas[i]);
					}
					Console.WriteLine();
					break;
				case '1':
					string concatenado = "";
					for (int i = 0; i < cadenas.Length; i++)
					{
						concatenado += " " + cadenas[i];
					}
					Console.WriteLine(concatenado);
					Console.WriteLine();
					break;
					
				case '2':
					string mayor = cadenas[0];
					string menor = cadenas[0];
					for (int i = 0; i < cadenas.Length; i++)
					{
						mayor = mayor.Length > cadenas[i].Length ? mayor : cadenas[i];
						menor = menor.Length < cadenas[i].Length ? menor : cadenas[i];
					}
					Console.WriteLine("Mayor: {0}  Menor: {1}", mayor, menor);
					Console.WriteLine();
					break;
					
				case '3':
					for (int i = 0; i < cadenas.Length; i++)
					{
						cadenas[i] = cadenas[i].ToUpper();
					}
					break;
					
				case '4':
					string[] vocales = {"a", "e", "i", "o", "u"};
					Console.Write("Introduce carácter de reemplazo: ");
					char reemplazo = Convert.ToChar(Console.ReadLine());
					string reemplazada;
					for (int i = 0; i < cadenas.Length; i++)
					{
						reemplazada = cadenas[i].ToLower();
						for (int j = 0; j < vocales.Length; j++)
						{
							reemplazada = reemplazada.Replace(vocales[j], reemplazo.ToString());
						}
						Console.WriteLine(reemplazada);
					}
					break;
					
				case '5':
					Console.Write("Introduce longitud de palabra: ");
					int longitud = Convert.ToInt32(Console.ReadLine());
					for (int i = 0; i < cadenas.Length; i++)
					{
						if (cadenas[i].Length >= longitud)
						{
							Console.WriteLine(cadenas[i]);
						}
					}
					Console.WriteLine();
					break;
					
				case '6':
					Array.Sort(cadenas);
					Console.WriteLine("Array ordenado alfabéticamente.");
					Console.WriteLine();
					break;
					
				case '7':
					Console.Write("Introduce palabra a buscar: ");
					string busqueda = Console.ReadLine();
					int contador = 0;
					for (int i = 0; i < cadenas.Length; i++)
					{
						if (cadenas[i].Contains(busqueda))
						{
							Console.WriteLine("\"{0}\" encontrado en \"{1}\"", busqueda, cadenas[i]);
							contador++;
						}
					}
					Console.WriteLine("\"{0}\" encontrado {1} veces.", busqueda, contador);
					Console.WriteLine();
					break;
					
				case '8':
					for (int i = 0; i < cadenas.Length; i++)
					{
						string[] nuevoArray = cadenas[i].Split();
						for (int j = 0; j < nuevoArray.Length; j++)
						{
							Console.WriteLine(" {0}", nuevoArray[j]);
						}
						Console.WriteLine();
					}
					Console.WriteLine();
					break;
					
				case '9':
					for (int i = 0; i < cadenas.Length; i++)
					{
						string palabraReves = "";
						for (int j = cadenas[i].Length -1 ; j >= 0 ; j--)
						{
							palabraReves += cadenas[i][j];
						}
						
						if (cadenas[i].ToLower() == palabraReves.ToLower())
						{
							Console.WriteLine("\"{0}\" es palíndromo.", cadenas[i]);
						}
					}
					Console.WriteLine();
					break;
					
				default:
					Console.WriteLine("Opción no válida.");
					Console.WriteLine();
					break;
			}
		}
	}
}
