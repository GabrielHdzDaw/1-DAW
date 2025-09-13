/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-10-2024
 * Descripción: Realiza un programa que utilize el operador condicional 
 * para asignar a una variable booleana true si dos números asignados
 *  por el usuario son pares o false si alguno de ellos es impar. 
 * 
 */

using System;
public class UsoBooleanos
{
	public static void Main()
	{
		int numero1, numero2;
		bool par;
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		numero2 = Convert.ToInt32(Console.ReadLine());
		
		//par = numero1 % 2 == 0 && numero2 % 2 == 0 ? true : false;
		par = numero1 % 2 == 0 && numero2 % 2 == 0;
		Console.WriteLine(par);
	}
}
