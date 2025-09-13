/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 25-11-2024
 * Descripción: Crea una función llamada NormalizarTexto que reciba un array de strings y devuelva
 *  un solo string consistente en todas esas cadenas concatenadas, separadas por puntos y cada una 
 * de esas cadenas deberán empezar por mayúscula. Además, si alguna de las cadenas tiene algún punto, 
 * después de ese punto también deberá estar en mayúscula.
Se probará desde un main donde podéis rellenar el array de cadenas en el código si queréis.
Podéis hacer más funciones aparte de la que os pido para realizar subtareas, por ejemplo:

    Separar por puntos las cadenas individuales
    Poner la 1ª en mayúscula
    Concatenar todas
 * 
 */

using System;
public class Normalizar
{
	public static string NormalizarTexto(string[] cadenas)
	{
		
	}
	
	public static string Mayuscula(string cadena)
	{
		return cadena[0].ToString().ToUpper() + cadena.Substring(1);
	}
	
	public static string ConcatenarPorPuntos(string[] cadenas)
	{
		return String.Join('.', cadenas);
	}
	
	public static string SplitCadenas(string cadena)
	{
		
	}
	
	public static void Main()
	{
		string[] cadenas = {"patatas fritas", "magnolia de bacon", "Mortadelo.filemón", "pan", "poliamor en tiempos de guerra"};
	}
}
