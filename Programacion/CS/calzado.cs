/*
 * Autor: Gabriel Hernández Collado 
 * Fecha: 19-09-2024 
 * Descripción: Crea un programa en C# que le pida al usuario 
 las tallas de zapatos de 4 personas. El programa deberá sacar por pantalla un mensaje diciendo "Todos calzan más de un 
 40", "Ninguno calza más de un 40" o "Hay algunos que calzan más de un 40 y otros que no", dependiendo de los datos 
 introducidos.  */

using System;
public class Calzado
{
	public static void Main()
	{
		int talla1, talla2, talla3, talla4;
		Console.Write("Introduce talla de zapatos: ");
		talla1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce talla de zapatos: ");
		talla2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce talla de zapatos: ");
		talla3 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce talla de zapatos: ");
		talla4 = Convert.ToInt32(Console.ReadLine());
		
		if(talla1>40 && talla2>40 && talla3>40 && talla4>40)
		{
			Console.WriteLine("Todos calzan más de 40.");
		}
		else if(talla1>40 || talla2>40 || talla3>40 || talla4>40)
		{
			Console.WriteLine("Algunos calzan más de 40 otros no.");
		}
		else 
		{
			Console.WriteLine("Ninguno calza más de 40.");
		}
		
		
	}
}
