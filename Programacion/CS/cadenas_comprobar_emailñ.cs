/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-11-2024
 * Descripción: Crea un programa en C# que pida una cadena y responda si es un email válido o no.

    uppercase and lowercase Latin letters A to Z and a to z;
    digits 0 to 9;
    special characters !#$%&'*+-/=?^_`{|}~;

Tiene que tener una @ y un punto que no serán ni el primer ni el último carácter.
 * 
 */

using System;
public class ComprobarEmail
{
	
	const string caracteresValidos = "!#$%&'*+-/=?^_`{|}~;@.";
	public static void Main()
	{
		string email;
		bool valido = true;
		
		Console.Write("introduce un email: ");
		email = Console.ReadLine().ToLower();
		
		for (int i  = 0; i < email.Length && valido; i++)
		{
			if (!(email[i] <= 'z' && email[i] >= 'a'))
			{
				if (!(email[i] >= '0' && email[i] <= '9'))
				{
					if (!caracteresValidos.Contains(Convert.ToString(email[i])))
					{
						valido = false;	
					}
				}
			}
		}
		if (valido)
		{
			valido = email.IndexOf("@") > 0
			&& email.IndexOf("@") < email.Length - 1
			&& email.IndexOf("@") == email.LastIndexOf("@") 
			&& email.IndexOf(".") > 0
			&& email.LastIndexOf(".") < email.Length - 1;
		}
		
		Console.WriteLine(valido ? "Email válido" : "Email no válido");
	}
}
