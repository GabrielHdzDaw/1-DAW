/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-10-2024
 * Descripción: Se le pedirá al usuario un número llamado clave entre 1 y 25 (elige el tipo de dato más adecuado)

Con ese número se realizará un programa para cifrar mensajes.
A continuación el usuario irá introduciento letras y le debemos indicar esa letra cifrada
letra +clave -->cifrar.
Hay que controlar que si nos pasamos de la 'z' debemos empezar de nuevo por la 'a' cuando ciframos.
Se terminará de pedir letras cuanto introduzcamos la palabra "fin".
Ejemplo:
Clave: 3
letra: a
cifrada: d
letra: h
cifrada: k
letra: fin
Cifrado completado.
 * 
 */

using System;
public class Cifrador
{
	public static void Main()
	{
		byte numero;
		string letraString;
		char letra;
		
		Console.Write("Introduce la clave: ");
		numero = Convert.ToByte(Console.ReadLine());
		do
		{
			Console.Write("Introduce una letra: ");
			letraString = Console.ReadLine();
			if (letraString != "fin")
			{
				letra = Convert.ToChar(letraString);
				if (letra + numero > 122)
				{
					Console.WriteLine("cifrada: {0}", (char)((letra + numero) - 122 + 96));
				}
				else
				{
					Console.WriteLine("cifrada: {0}", (char)(letra + numero));
				}
			}
		} while (letraString != "fin");
	}
}
