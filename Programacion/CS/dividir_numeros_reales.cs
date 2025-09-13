/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Realiza un programa en C# que pida dos números
 *  reales de simple precisión y muestre el resultado de dividirlos.


 */ 
 


using System;
public class DivisionNumerosReales
{
	public static void Main()
	{
		float numero1, numero2;
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToSingle(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		numero2 = Convert.ToSingle(Console.ReadLine());
		
		Console.WriteLine("{0} / {1} = {2}", numero1, numero2, numero1 / numero2);
	}
}
