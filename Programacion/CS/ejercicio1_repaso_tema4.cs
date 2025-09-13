/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 20-11-2024
 * Descripción: Concatenar todas las cadenas
Concatena todas las cadenas del array en una única cadena separada por un espacio.
Ejemplo:
Array: ["Hola" "mundo", "C#"]
Salida: "Hola mundo C#"
 * 
 */

using System;
public class Ejercicio1RepasoTema4
{
	public static void Main()
	{
		string[] array = {"Hola", "mundo", "C#"};
		Console.Write(String.Join(" ", array));
	}
}
