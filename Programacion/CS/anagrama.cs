/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 15-11-2024
 * Descripción: crea un array y pide una palabra a un usuario. Comprueba si esa palabra es anagrama de una de las
 * palabras del array
 * 
 */

using System;
public class Anagrama
{
	public static void Main()
	{
		string[] palabras = {
		"amor",
		"ratón",
		"sal",
		"casa",
		"perro",
		"ropa",
		"arco",
		"luz",
		"lupa",
		"gato",
		"mesa",
		"sopa",
		"tren",
		"manos",
		"piedra",
		"fruta",
		"carro",
		"viento",
		"flor",
		"norte",
		"roma",
		"mora"
		};
		string palabraUsuario, palabraUsuarioOrdenada;
		
		Console.Write("Introduce una palabra: ");
		palabraUsuario  = Console.ReadLine();
		char[] arrayCharsUsuario = new char[palabraUsuario.Length];
		
		for (int i = 0; i < arrayCharsUsuario.Length; i++)
		{
			arrayCharsUsuario[i] = palabraUsuario[i];	
		}
		
		Array.Sort(arrayCharsUsuario);
		palabraUsuarioOrdenada = String.Join("", arrayCharsUsuario);
	
		
		char[] arrayCharsPalabra;
		Console.WriteLine("Anagramas de {0}: ", palabraUsuario);
		for (int i = 0; i < palabras.Length; i++)
		{
		
			arrayCharsPalabra = new char [palabras[i].Length];
			
			for (int j = 0; j < palabras[i].Length; j++)
			{
				if (palabras[i][j].ToString() != " ")
				{
					arrayCharsPalabra[j] = palabras[i][j];
				}
				
			}
			
			Array.Sort(arrayCharsPalabra);
			string palabraArray = String.Join("", arrayCharsPalabra);
			
			if (palabraArray == palabraUsuarioOrdenada)
			{
				Console.WriteLine(palabras[i]);
			}
			
		}
		
	}
}
