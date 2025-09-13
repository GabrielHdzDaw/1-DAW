/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 20-09-2024
 * Descripción: Crea un programa que lea una letra tecleada por el usuario y diga si se trata 
 * de un signo de puntuación ". , ; :", una cifra numérica (del 0 al 9) o algún otro carácter,
 *  usando "switch" (pista: necesitarás que usar un dato de tipo "char").
	Hazlo con if y con switch.
 * 
 */

using System;
public class ReconocerCaracter
{
	public static void Main()
	{
		char caracter;
		string resultado;
		Console.Write("Introduce un carácter: ");
		caracter = Convert.ToChar(Console.ReadLine());
		
		//switch(caracter)
		//{
			//case '.':
			//case ',':
			//case ';':
			//case ':':
				//resultado = "es un signo de puntuación.";
				//break;
			//case '0':
			//case '1':
			//case '2':
			//case '3':
			//case '4':
			//case '5':
			//case '6':
			//case '7':
			//case '8':
			//case '9':
				//resultado = "es un número.";
				//break;
			//default:
				//resultado = "es otro tipo de carácter.";
				//break;
		//}
		//Console.WriteLine("{0} {1}", caracter, resultado);
		
		if (caracter == '.' || caracter == ',' || caracter == ';' || caracter == ':')
		{
			resultado = "es un signo de puntuación.";
		}
		else
		{
			if (caracter >= '0' && caracter <= '9')
			 {
				 resultado = "es un número.";
			 }
			 else 
			 {
				 resultado = "es otro tipo de carácter.";
			 }
		}
		Console.WriteLine("{0} {1}", caracter, resultado);
	}
}
