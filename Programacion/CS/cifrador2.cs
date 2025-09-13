/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-10-2024
 * Descripción: Ahora se ampliará el cifrador de la tarea anterior de forma
 *  que al principio pregunta si se va a cifrar o descifrar y el número de la clave.
A partir de ahí se irán pidiendo letras y se irá cifrando y descifrando según lo que se haya dicho al principio.


 * 
 */

using System;
public class Cifrador
{
	public static void Main()
	{
		byte numero;
		string letraString;
		char letra, cifrar;
		
		Console.Write("Introduce 'd' para descrifrar o 'c' para cifrar: ");
		cifrar = Convert.ToChar(Console.ReadLine());
		
		Console.Write("Introduce la clave: ");
		numero = Convert.ToByte(Console.ReadLine());
		do
		{
			Console.Write("Introduce una letra: ");
			letraString = Console.ReadLine();
			if (letraString != "fin")
			{
				if(cifrar == 'c')
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
				else
				{
					if (cifrar == 'd')
					{
						letra = Convert.ToChar(letraString);
						if (letra - numero < 97)
						{	
							Console.WriteLine("cifrada: {0}", (char)((letra - numero) + 122 - 96));
						}
						else
						{
							Console.WriteLine("cifrada: {0}", (char)(letra - numero));
						}
					}
				}
			}
		} while (letraString != "fin");
	}
}
