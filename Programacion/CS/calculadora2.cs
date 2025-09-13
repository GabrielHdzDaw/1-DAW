/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-10-2024
 * Descripción: Realiza un programa en C# que pida al usuario dos
 *  números y la operación a realizar(+,-,*,/)y devuelva el valor
 *  resultante. Seguirá pidiendo datos hasta que introduzcamos como operación 'f'

Por ejemplo:

Primer operando: 5

Operación: +

Segundo operando: 5

Resultado: 10
 * 
 */

using System;
public class Calculadora2
{
	public static void Main()
	{
		int operando1, operando2, resultado = 0;
		char operador = '+';
		
		while (operador != 'f')
		{
			Console.Write("Introduce el primer operando: ");
			operando1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduce el operador: ");
			operador = Convert.ToChar(Console.ReadLine());
			Console.Write("Introduce el segundo operando: ");
			operando2 = Convert.ToInt32(Console.ReadLine());
			
			switch (operador)
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
					resultado = operando1 / operando2;
					break;
				case 'f':
					Console.WriteLine("Fin.");
					break;
				default:
					Console.WriteLine("Operador no válido.");
					break;
			}
			if (operador != 'f')
			{
				if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
				{
					Console.WriteLine("{0} {1} {2} = {3}", operando1, operador, operando2, resultado);
				}
			}
			
			
		}
	}
}
