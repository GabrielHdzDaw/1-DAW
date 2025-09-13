/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-11-2024
 * Descripción: Un programa que pida tu nombre, tu día de nacimiento y tu mes de
nacimiento y lo junte todo en una cadena, separando el nombre de la fecha por
una coma, y el día y el mes por una barra inclinada, así: "Juan, nacido el 31/12".
 * 
 */

using System;
public class FechaNacimiento
{
	public static void Main()
	{
		string nombre, cadena;
		int dia, mes;
		
		Console.Write("Introduce tu nombre: ");
		nombre = Console.ReadLine();
		
		Console.Write("Introduce tu día de nacimiento: ");
		dia = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce tu mes de nacimiento: ");
		mes = Convert.ToInt32(Console.ReadLine());
		
		cadena = nombre + ", nacido el " + dia + "/" + mes;

		Console.WriteLine(cadena);
	
		
	}
}
