/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 14-10-2024
 * Descripción: Calcula el área, el perímetro y la diagonal de un
 *  rectángulo dados su base y altura por el usuario. Debemos usar double.

Utiliza Math.Sqrt(x) para calcular la raiz cuadrada.
 */ 
 


using System;
public class AreaRectangulo
{
	public static void Main()
	{
		double anchura, altura, area, perimetro, diagonal;
		Console.Write("Introduce la base: ");
		anchura = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduce la altura: ");
		altura = Convert.ToDouble(Console.ReadLine());
		
		area = anchura * altura;
		perimetro = 2 * anchura + 2 * altura;
		diagonal = Math.Sqrt(anchura * anchura + altura * altura);
		
		Console.WriteLine("Area: {0} perimetro: {1} diagonal: {2}", area, perimetro, diagonal);
	}
}
