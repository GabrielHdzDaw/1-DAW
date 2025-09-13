
/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-10-2024
 * Descripción: Crea un programa en C# que pida números enteros 
 * hasta que el usuario introduzca "fin" como número. (Habrá que recoger 
 * el número primero como string y convertirlo después). Al terminar muestra el mayor de todos esos números.
 */

using System;
public class EnteroMayor
{
	public static void Main()
	{
		int numeroInt, mayor = 0;
		string numeroString; 
		
		do
		{
			Console.Write("Introduce un número: ");
			numeroString = Console.ReadLine();
			if (numeroString != "fin")
			{
				numeroInt = Convert.ToInt32(numeroString);
				if (numeroInt > mayor)
				{
					mayor = numeroInt;
				}
			}
			
		} while (numeroString != "fin");
		Console.WriteLine(mayor);
	}
	
}
