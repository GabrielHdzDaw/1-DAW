/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Realiza un programa en C# que calcule la media aritmética de 5 notas
 * introducidas por el usuario. Las notas tienen decimales y la media también.
 */ 
 


using System;
public class MediaDecimales
{
	public static void Main()
	{
		double nota1, nota2, nota3, nota4, nota5, media;
		Console.Write("Introduce nota: ");
		nota1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce nota: ");
		nota2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce nota: ");
		nota3 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce nota: ");
		nota4 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce nota: ");
		nota5 = Convert.ToDouble(Console.ReadLine());
		
		media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
		Console.WriteLine("La media es: {0}", media);
	}
}
