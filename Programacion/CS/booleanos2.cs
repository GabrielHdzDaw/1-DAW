/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 18-10-2024
 * Descripción: Realiza un programa que pida cuantos componentes había en almacén esta mañana y cuantos se 
 * han vendido hoy y nos dirá si tendremos que pedir al proveedor en la próxima semana.

Debemos coger los que hay hoy y restarle los vendidos esta mañana por 7, si el resultado de 
esta operación es menor o igual a 0, se asignará true a una variable booleana llamada
 APedir y sino se le asignará false.

Esta comprobación se realizará con el operador condicional.
 * 
 */

using System;
public class Booleanos2
{
	public static void Main()
	{
		int componentesAlmacen, componentesVendidos;
		bool aPedir;
		Console.Write("Introduce número de componentes en almacén: ");
		componentesAlmacen = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduce número de componentes vendidos: ");
		componentesVendidos = Convert.ToInt32(Console.ReadLine());
		
		aPedir = componentesAlmacen - componentesVendidos * 7 <= 0;
		Console.WriteLine(aPedir);
	}
}
