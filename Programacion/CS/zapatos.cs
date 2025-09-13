
/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-09-2024
 * Descripción: Crea un programa en C# que le pida al usuario 
 * las tallas de zapatos de 4 personas. El programa deberá sacar por 
 * pantalla un mensaje diciendo "Todos calzan más de un 40", "Ninguno 
 * calza más de un 40" o "Hay algunos que calzan más de un 40 y otros 
 * que no", dependiendo de los datos introducidos.
 */

using System;
public class Zapatos
{
	public static void Main()
	{
		int talla1, talla2, talla3, talla4;
		string resultado;
		
		Console.Write("Introduce un número: ");
		talla1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		talla2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		talla3 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		talla4 = Convert.ToInt32(Console.ReadLine());
		
		resultado = talla1 > 40 && talla2 > 40 && talla3 > 40 && talla4 > 40 ? "Todos calzan más de un 40." : 
		talla1 > 40 || talla2 > 40 || talla3 > 40 || talla4 > 40 ? "Hay algunos que calzan más de un 40 y otros no." : 
		talla1 <= 40 && talla2 <= 40 && talla3 <= 40 && talla4 <= 40 ? "Ninguno calza más de un 40." : null;
		
		Console.WriteLine(resultado);
	}
	
}
