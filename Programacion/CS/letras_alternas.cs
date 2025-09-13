/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 17-10-2024
 * Descripción: Crea un programa que muestre letras alternas (una sí y una no)
 *  entre la que teclee el usuario y la "z". Por ejemplo, si el usuario introduce una "a", se escribirá "aceg..."
 * 
 */

using System;
public class LetrasAlternas
{
	public static void Main()
	{
		char letra;
		Console.Write("Introduce una letra: ");
		letra = Convert.ToChar(Console.ReadLine());
		
		for (char c = letra; c <= 'z'; c+=(char)2)
		{
			Console.Write("{0} ", c);
		}
	}
}
