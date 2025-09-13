/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 03-12-2024
 * Descripción: Realiza un Main que reciba como primer parámetro una palabra entre: circulo, triangulo o 
 * cuadrado y calcule su área.
Según ese parámetro el/los siguientes serán:
circulo --> un número correspondiente al radio : area= (radio^2)*PI
triangulo --> dos números correspondientes a la base y la altura :area= (base * altura) / 2
cuadrado --> un número correspondiente con el lado: area= lado * lado
Se deberán revisar que los parámetros son correctos ( el primero es una de las opciones válidas y el 
resto de parámetros se corresponden con la opción elegida en el primer parámetro) y si no lo son se
 deberá sacar mensaje con el uso correcto y se devolverá al sistema operativo un 2. En caso de todo 
 ir correctamente se devolverá un 0.
 * 
 * 
 */

using System;
public class CalculadoraAreas
{
	public static double AreaCirculo(double radio)
	{
		return (radio * radio) * Math.PI;
	}
	
	public static double AreaTriangulo(double anchura, double altura)
	{
		return (anchura * altura) / 2;
	}
	
	public static double AreaCuadrado(double lado)
	{
		return lado * lado;
	}
	
	public static void Main(string[] args)
	{
		if (args.Length == 0)
		{
			Console.WriteLine("Debes introducir tipo de área a calcular (circulo, triangulo, cuadrado)");
		}
		else 
		{
			string eleccion = args[0];
		switch (eleccion)
		{
			case "circulo":
				if (args.Length == 2)
				{
					double radio = Convert.ToDouble(args[1]);
					Console.WriteLine(AreaCirculo(radio));
				} 
				else
				{
					Console.WriteLine("Debes introducir tan solo el radio del círculo");
				}
				break;
			case "triangulo":
				if (args.Length == 3)
				{
					double anchura = Convert.ToDouble(args[1]);
					double altura = Convert.ToDouble(args[2]);
					Console.WriteLine(AreaTriangulo(anchura, altura));
				}
				else
				{
					Console.WriteLine("Debes introducir tan solo la base y la altura del triángulo");
				}
				break;
			case "cuadrado":
				if (args.Length == 2)
				{
					double lado = Convert.ToDouble(args[1]);
					Console.WriteLine(AreaCuadrado(lado));
				}
				else
				{
					Console.WriteLine("Debes introducir tan solo el lado del cuadrado");
				}
				break;
			default:
				Console.WriteLine(eleccion + " no es un caso válido");
				break;
		}
		}
		
		
	}
}
