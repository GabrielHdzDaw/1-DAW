/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 15-10-2024
 * Descripción: Calcula la superficie y el volumen de una esfera, a partir de su radio
(superficie = 4 * pi * radio al cuadrado; volumen = 4/3 * pi * radio al cubo). Usa
datos "doble" y muestra los resultados con 5 cifras decimales.
 * 
 */

using System;
public class Esfera
{
	public static void Main()
	{
		double radio = 4, superficie, volumen;
		superficie = 4 * Math.PI * (radio * radio);
		volumen = (4.0 / 3.0) * Math.PI * (radio * radio * radio);
		
		Console.WriteLine("Superficie: {0}", superficie.ToString("N5"));
		Console.WriteLine("Volumen: {0}", volumen.ToString("N5"));
		Console.WriteLine("\a");
	}
}
