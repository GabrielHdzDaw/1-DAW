/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 03-12-2024
 * Descripción: Realiza un programa llamado calculadora que funcione de la siguiente forma:

Calculadora 5 + 2

7

Deberá poder realizar (+,-,*,/)

Si los parámetros no son 3 se debe sacar el siguiente mensaje:

Uso: Calculadora operando1 operación operando2

Si el segundo operando no es correcto se debe sacar:

Operación no permitida
 * 
 */

using System;
public class Test
{
	public static double Operacion(double num1, double num2, string operador)
	{
		double resultado = 0;
		switch (operador)
			{
				case "+":
					resultado = num1 + num2;
					break;
				case "-":
					resultado = num1 - num2;
					break;
				case "/":
					if (num2 != 0)
					{
						resultado = num1 / num2;
					}
					else
					{
						Console.WriteLine("No se puede dividir por cero");
					}
					break;
				case "*":
					resultado = num1 * num2;
					break;
				default:
					Console.WriteLine(operador + " no es un operador correcto");
					break;
			}
		return resultado;
	}
	public static void Main(string[] args)
	{
		double resultado = 0;
		if (args.Length == 3)
		{
			double num1 = Convert.ToDouble(args[0]);
			double num2 = Convert.ToDouble(args[2]);
			resultado = Operacion(num1, num2, args[1]);
			
		} else 
		{
			Console.WriteLine("El programa necesita 3 argumentos (5 + 2)");
		}
		Console.WriteLine(resultado);
	}
}
