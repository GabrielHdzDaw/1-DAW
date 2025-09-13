/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 20-09-2024
 * Descripción:Pide al usuario 3 números y muestra por pantalla cual es el mayor de los 3. 
 * Hazlo 2 veces, una vez usando if else y otra con el operador condicional.
 * 
 */

using System;
public class NumeroMayor
{
	public static void Main()
	{
		int numero1, numero2, numero3, mayor;
		
		Console.Write("Introduce un número: ");
		numero1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un número: ");
		numero2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un número: ");
		numero3 = Convert.ToInt32(Console.ReadLine());
		
		//if (numero1 > numero2 && numero1 > numero3)
		//{
			//mayor = numero1;
		//}
		//else
		//{
			//if (numero2 > numero3)
			//{
				//mayor = numero2;
			//}
			//else
			//{
				//mayor = numero3;
			//}
		//}
		
		mayor = numero1 > numero2 && numero1 > numero3 ? numero1 : numero2 > numero3 ? numero2: numero3;
		Console.WriteLine("{0} es mayor.", mayor);
	}
	
}
