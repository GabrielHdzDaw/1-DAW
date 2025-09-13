/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 16-12-2024
 * Descripción:
 * 
 */

using System;
using System.IO;
public class Test
{
	public static void Main()
	{
		string path = "file.txt";
		
	
		File.AppendAllText(path, "Filigrana\n");
		
		StreamReader reader = new StreamReader(path);
		using(reader)
		{
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				Console.WriteLine(line);
			}
		}
	}
}
