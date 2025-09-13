/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 23-09-2024
 * Descripción: Pide un número y luego otro. Si el segundo es 0 
 * lo tendrás que seguir pidiendo hasta que introduzca el usuario
 *  un número diferente de 0. Después de esto realizas la división y sacas el resultado por pantalla. (while)
 * 
 */

using System;
public class DivideSiNoCero
{
	public static void Main()
	{
		int numero1, numero2 = 0;
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		
		//do
		//{
			//Console.Write("Introduce otro número: ");
			//numero2 = Convert.ToInt32(Console.ReadLine());
		//}while(numero2 == 0);
		//Console.WriteLine("{0} entre {1} es {2}", numero1, numero2, numero1/numero2);
		while(numero2 == 0)
		{
			Console.Write("Introduce otro número: ");
			numero2 = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("{0} entre {1} es {2}", numero1, numero2, numero1/numero2);
	}
}
