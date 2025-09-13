/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-10-2024
 * Descripción: Realiza un programa en C# que asigne a una variable
 *  "notaEnTexto" (string) el valor "aprobado" si la variable numérica 
 * "nota" tiene un valor de 5 o más y "suspendido" si está por debajo de 5. Hazlo de 3 formas:

             -- Usando "if"

             -- Usando el operador condicional
 * 
 */

using System;
public class OperadorCondicionalString
{
	public static void Main()
	{
		int nota = 10;
		string notaEnTexto;
		
		if (nota >= 5)
		{
			notaEnTexto = "aprobado";
		}
		else
		{
			notaEnTexto = "suspendido";
		}
		
		notaEnTexto = nota >= 5 ? "aprobado" : "suspendido";
		Console.WriteLine(notaEnTexto);
	}
}
