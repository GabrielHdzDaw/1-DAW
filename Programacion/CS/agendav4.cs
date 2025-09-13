
/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 12-11-2024
 * Descripción: Realiza un programa que cree en código un array de 20 nombres, por ejemplo:
string[] agenda={"Mari Chelo Rubio", "Jacinto Benavente",....}
y muestre el siguiente menú repetitivo al usuario:
1.- Buscar un nombre en concreto
2.- Buscar por el nombre (primera palabra coincide con la introducida por el   usuario)
3.- Buscar cualquier coincidencia (si la palabra introducida por el usuario está en alguna posición)
4.- Mostrar todos los nombres (sólo los nombres -- 1ª palabra)
5.- Normalizar (poner en mayúsculas todas las iniciales de palabra)
7.- Salir
 */

using System;
public class AgendaV4
{
	public static void Main()
	{
		string[] agenda = {"Rudolph Schwarzenegger", "Botones Sacarino", "Colina Colindante", "Mando de PlayStation",
			"Mando de Xbox", "Masaje Final Agridulce", "Qwerty Azerty", "Mc Lla de Ruedas", "Chelo C Sostenido", "Nacho Cabano",
			"Juninho Laupiz", "Romaldo Bosques", "Azucena Novoy", "Asucomida Sí", "Waylon Smithers", "TJ Detweiler", "Peter Parker",
			"Lil Pequeñín", "Big Grandote", "Hahahaha Ronaldinho Soccer"};
			
		string entradaUsuario;
		string[] nombreSplit;
		char eleccion;
		bool salir = false;
		bool encontrado = false;
		
		while (!salir)
		{
			Console.WriteLine("1.- Buscar un nombre en concreto");
			Console.WriteLine("2.- Buscar por el nombre (primera palabra coincide con la introducida por el usuario)");
			Console.WriteLine("3.- Buscar cualquier coincidencia (si la palabra introducida por el usuario está en alguna posición)");
			Console.WriteLine("4.- Mostrar todos los nombres (sólo los nombres -- 1ª palabra)");
			Console.WriteLine("5.- Normalizar (poner en mayúsculas todas las iniciales de palabra)");
			Console.WriteLine("7.- Salir");
			eleccion = Convert.ToChar(Console.ReadLine());
			
			switch (eleccion)
			{
				case '1':
					Console.Write("Introduce el nombre a buscar: ");
					entradaUsuario = Console.ReadLine();
					for (int i = 0; i < agenda.Length && !encontrado; i++)
					{
						if (entradaUsuario == agenda[i])
						{
							encontrado = true;
							Console.WriteLine($"Nombre encontrado:\n{agenda[i]}.\n");
						}
					}
					if (!encontrado)
					{
						Console.WriteLine("Nombre no encontrado.\n");
					}
					encontrado = false;
					break;
					
				case '2':
					Console.Write("Introduce el nombre a buscar: ");
					entradaUsuario = Console.ReadLine();
					for (int i = 0; i < agenda.Length; i++)
					{
						if (agenda[i].IndexOf(entradaUsuario) == 0)
						{
							encontrado = true;
							Console.WriteLine($"Nombre encontrado:\n{agenda[i]}.\n");
						}
					}
					if (!encontrado)
					{
						Console.WriteLine("Nombre no encontrado.\n");
					}
					encontrado = false;
					break;
					
				case '3':
					Console.Write("Introduce el nombre a buscar: ");
					entradaUsuario = Console.ReadLine();
					for (int i = 0; i < agenda.Length; i++)
					{
						if (agenda[i].Contains(entradaUsuario))
						{
							encontrado = true;
							Console.WriteLine($"Nombre encontrado:\n{agenda[i]}.\n");
						}
					}
					if (!encontrado)
					{
						Console.WriteLine("Nombre no encontrado.\n");
					}
					encontrado = false;
					break;
					
				case '4':
					for (int i = 0; i < agenda.Length; i++)
					{
						nombreSplit = agenda[i].Split();
						Console.WriteLine(nombreSplit[0]);
					}
					Console.WriteLine();
					break;
				case '5':
					for (int i = 0; i < agenda.Length; i++)
					{
						nombreSplit = agenda[i].Split();
						for (int j = 0; j < nombreSplit.Length; j++)
						{
							Console.Write(nombreSplit[j].Substring(0, 1).ToUpper() + nombreSplit[j].Substring(1) + " ");
						}
						Console.WriteLine();
					}
					Console.WriteLine();
					break;
				case '7':
					salir = true;
					break;
					
				default:
				Console.WriteLine("Opción no válida.");
					break;
			}
		}
	}
}

