
/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 13 - 12 - 2024
 * Descripción: Main donde se recibirán por parámetros los datos necesarios para llamar a las funciones anteriores.
 */

using System;
public class ExamenTema5
{
	public static int Cuantas(string cadena, char letra)
	{
		if (cadena[cadena.Length - 1] == letra && cadena.Length == 1)
		{
			return 1;
		}
		else
		{
			if (cadena[cadena.Length - 1] != letra && cadena.Length == 1)
			{
				return 0;
			}
		}
		if (cadena[cadena.Length - 1] == letra)
		{
			return 1 + Cuantas(cadena.Substring(0, cadena.Length - 1), letra);
		}
		return 0 + Cuantas(cadena.Substring(0, cadena.Length - 1), letra);
	}
	
	public static int CuantosNumeros(int numero)
	{
		return numero.ToString().Length;
	}
	
	public static int SumaElevados(int numero, int exponente)
	{
		int suma = 0;
		while (numero > 0)
		{
			suma += (int)Math.Pow(numero % 10, exponente);
			numero /= 10;
		}
		return suma;
	}
	
	public static bool EsFresnillense(int numero)
	{
		int digitos = CuantosNumeros(numero);
		int suma = 0;
		for (int i = 1; i <= digitos; i++)
		{
			suma += SumaElevados(numero, i);
		}
		return suma == numero;
	}
	
	public static bool Contiene(string cadena, char letra, out int posicion)
	{
		posicion = 0;
		if (cadena.Contains(letra.ToString()))
		{
			posicion = cadena.IndexOf(letra);
			return true;
		}
		return false;
	}
	
	public static void Dividir(string cadenaOriginal, out string primeraParte, out string segundaParte, int posicion)
	{
		primeraParte = cadenaOriginal.Substring(0, posicion);
		segundaParte = cadenaOriginal.Substring(posicion);
	}
	
	public static void DivideCadena(string cadena, char letra, out int posicion, out string primeraParte, out string segundaParte)
	{
		if (Contiene(cadena, letra, out posicion))
		{
			Dividir(cadena, out primeraParte, out segundaParte, posicion);
		}
		else
		{
			primeraParte = cadena;
			segundaParte = "";
		}
	}
	
	public static string MayusMinus(string cadena)
	{
		string mayusMinus = "";
		if (cadena.Length > 10)
		{
			for (int i = 0; i < cadena.Length; i++)
			{
				if (i < 10)
				{
					mayusMinus += cadena[i].ToString().ToUpper();
				}
				else
				{
					mayusMinus += cadena[i].ToString().ToLower();
				}
			}
		}
		else
		{
			mayusMinus = cadena.ToUpper();
		}
		return mayusMinus;
	}
	
	public static void Main(string[] args)
	{
		
		if (args.Length > 0)
		{
			switch (args[0])
			{
				case "cuantas":
					if (args.Length == 3)
					{
						Console.WriteLine(Cuantas(args[1], Convert.ToChar(args[2])));
					}
					else
					{
						Console.WriteLine("Debes introducir una cadena y un carácter");
					}
					break;
				case "fresnillense":
					if (args.Length == 2)
					{
						Console.WriteLine(EsFresnillense(Convert.ToInt32(args[1]))? "Es fresnillense" : "No es fresnillense");
					}
					else
					{
						Console.WriteLine("Debes introducir un número");
					}
					break;
				case "divide":
					if (args.Length == 3)
					{
						int posicion = 0;
						string primeraParte = "";
						string segundaParte = "";
						DivideCadena(args[1], Convert.ToChar(args[2]), out posicion, out primeraParte, out segundaParte);
						Console.WriteLine(primeraParte);
						Console.WriteLine(segundaParte);
					}
					else
					{
						Console.WriteLine("Debes introducir una cadena y un carácter");
					}
					break;
					
				case "mayusminus":
					if (args.Length == 2)
					{
						Console.WriteLine(MayusMinus(args[1]));
					} 
					else
					{
						Console.WriteLine("Debes introducir una cadena");
					}
					break;
				default:
					Console.WriteLine("Elige entre cuantas, fresnillense, divide y mayusminus");
					break;
			}
			
		}
		else
		{
			Console.WriteLine("Debes introducir la función a ejecutar con sus parámetros: cuantas, fresnillense, divide o mayusminus");
		}
	}
}
