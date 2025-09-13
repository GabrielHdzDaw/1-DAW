/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Realiza un programa en C# que calcule el área lateral(AL),área Total(AT) y volumen de un cilindro 
 * pidiendo al usuario la altura y el radio. Utilizando float (recordad poned una f cuando asigneis el valor de pi)
 */ 
 


using System;
public class CalcularVolumen
{
	public static void Main()
	{
		float altura, radio, areaLateral, areaTotal, volumen, pi = 3.1415f;
		Console.Write("Introduce la altura: ");
		altura = Convert.ToSingle(Console.ReadLine());
		Console.Write("Introduce el radio: ");
		radio = Convert.ToSingle(Console.ReadLine());
		
		areaLateral = 2 * pi * radio * altura;
		areaTotal =  2 * pi * radio * (altura * radio);
		volumen = pi * (radio * radio) * altura;
		
		Console.WriteLine("Área lateral: {0}", areaLateral);
		Console.WriteLine("Área Total: {0}", areaTotal);
		Console.WriteLine("Volumen: {0}", volumen);
	}
}
