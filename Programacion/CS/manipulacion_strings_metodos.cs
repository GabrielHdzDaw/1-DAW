/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 07-11-2024
 * Descripción: Crea un programa que pida al usuario una cadena y: (guardando los resultados en una nueva cadena cada vez)

    La convierte a mayúscula
    La convierte a minúscula
    Borra la segunda y la tercera letra.
    Inserta "yo" después de la segunda letra.
    Reemplaza todos los espacios por barras _
    Quita todos los espacios a la izquierda
    Quita todos los espacios de la derecha.
    Reemplaza todas las "a" minúsculas por mayúsculas.
    Trocea la cadena (split) en un array de palabras(separadas por espacios). Y muestra cada palabra en una línea.
 * 
 */

using System;
public class ManipulacionStringsMetodos
{
	public static void Main()
	{
		string cadena;
		Console.Write("Introduce una cadena: ");
		cadena = Console.ReadLine();
		
		string cadenaMayuscula = cadena.ToUpper();
		Console.WriteLine(cadenaMayuscula);
		string cadenaMinuscula = cadena.ToLower();
		Console.WriteLine(cadenaMinuscula);
		string cadenaBorrada = cadena.Remove(1,2);
		Console.WriteLine(cadenaBorrada);
		string cadenaInsertada = cadena.Insert(2, "yo");
		Console.WriteLine(cadenaInsertada);
		string cadenaReemplazada = cadena.Replace(" ", "_");
		Console.WriteLine(cadenaReemplazada);
		string cadenaTrimeada1  = cadena.TrimStart();
		Console.WriteLine(cadenaTrimeada1);
		string cadenaTrimeada2  = cadena.TrimEnd();
		Console.WriteLine(cadenaTrimeada2);
		string cadenaTrimeada3  = cadena.Trim();
		Console.WriteLine(cadenaTrimeada3);
		string cadenaReemplazadaA = cadena.Replace("a", "A");
		Console.WriteLine(cadenaReemplazadaA);
		string[] cadenaSplit = cadena.Split();
		for (int i = 0; i < cadenaSplit.Length; i++)
		{
			Console.WriteLine(cadenaSplit[i]);
		}
		string resultado = "";
		//Iniciales de palabra en mayúscula
		for (int i = 0; i < cadenaSplit.Length; i++)
		{
			resultado += cadenaSplit[i].Substring(0,1).ToUpper() + cadenaSplit[i].Substring(1) + " ";
		}
		Console.Write(resultado);
	}
}
