/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-11-2024
 * Descripción:
 * 
 */

using System;
public class FuncionBienvenida
{
	public static void DarBienvenida()
	{
		Console.WriteLine("Bienvenido al programa de prueba");
	}
	
	public static void MostrarMenu()
	{
		Console.WriteLine("1. Abrir\n2. Cerrar\n3. Salir");
	}
	
	public static int Suma(int numero1, int numero2)
	{
		return numero1 + numero2;
	}
	
	public static string Concat(string s1, string s2)
	{
		return s1 + s2;
	}
	
	public static void Main()
	{
		DarBienvenida();
		MostrarMenu();
		Console.WriteLine(Suma(3,4));
		Console.WriteLine(Concat("patata ", "deliciosa"));
	}
}
