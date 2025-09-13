/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 08-11-2024
 * Descripción: Crea un programa en C# que pida al usuario un
 *  nombre y apellido y cree una nueva cadena donde se añada al principio
 *  Sr/Sra y después el apellido una coma  un espacio y el nombre. (José López -> Sr/Sra López, José)
 * 
 */

using System;
public class CadenasPrefijos
{
	public static void Main()
	{
		string nombreApellido, resultado;
		string[] nombreSplit;
		Console.Write("Introduce tu nombre y apellido: ");
		nombreApellido = Console.ReadLine();
		nombreSplit = nombreApellido.Split();
		
		resultado = "Sr/Sra " +  nombreSplit[1] + ", "  + nombreSplit[0];
		Console.WriteLine(resultado);
		
	}
}
