/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 20-11-2024
 * Descripción:Palabras más largas
	Encuentra cuál es la palabra más larga y cuál es la más corta en el array. Muestra sus longitudes.
	Ejemplo:
	Array: "[casa", "ventilador", "sol"]
	Salida: "Palabra más larga: ventilador (10 caracteres), más corta: sol (3
	caracteres)"
 * 
 */

using System;
public class Ejercicio2_repaso_tema4
{
	public static void Main()
	{
		string[] palabras = {"casa", "ventilador", "sol"};
		string mayor = palabras[0];
		string menor = palabras[0];
		for (int i = 0; i < palabras.Length; i++)
		{
			mayor = mayor.Length > palabras[i].Length ? mayor : palabras[i];
			menor = menor.Length < palabras[i].Length ? menor : palabras[i];
		}
		Console.WriteLine("Mayor: {0}  Menor: {1}", mayor, menor);
	}
}
