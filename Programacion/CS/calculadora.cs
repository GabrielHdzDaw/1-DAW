/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 20-09-2024
 * Descripción: Crea una calculadora con switch
 * 
 */

using System;
public class Calculadora
{
	public static void Main()
	{
		int operando1, operando2, resultado;
		resultado = 0;
		char operador;
		Console.Write("Introduce un número: ");
		operando1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce otro número: ");
		operando2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce un operador: ");
		operador = Convert.ToChar(Console.ReadLine());
		
		switch(operador)
		{
			case '+':
				resultado = operando1 + operando2;
				break;
			case '-':
				resultado = operando1 - operando2;
				break;
			case '*':
				resultado = operando1 * operando2;
				break;
			case '/':
				if (operando2 != 0)
				{
					resultado = operando1 / operando2;
					
				}
				else
				{
					Console.WriteLine("No se puede dividir entre 0.");
				}
				break;
			default:
				Console.WriteLine("{0} no es un operador válido.", operador);
				break;
		}
		
		Console.WriteLine("{0} {1} {2} = {3}", operando1, operador, operando2, resultado);
	}
}
