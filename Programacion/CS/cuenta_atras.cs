/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 26-09-2024
 * Descripción: Crea un programa que muestre una cuenta atrás (3 2 1 0) desde el número
 *  que introduzca el usuario hasta cero. Ese número debe estar entre 1 y 10 (y el programa 
 * debe comprobar que realmente lo está, y volverlo a pedir tantas veces como sea necesario, en caso de que no sea así).

Por tanto:

1.- Pedir un número al usuario

2.- Comprobar que está entre 1 y 10, si no es así volverlo a pedir

3.- Mostrar cuenta atrás desde el número suministrado por el usuario hasta 0.
 */ 
 


using System;
public class CuentaAtras
{
	public static void Main()
	{
		int numero;
		do
		{
			Console.Write("Introduce un número entre el 1 y el 10: ");
			numero = Convert.ToInt32(Console.ReadLine());
				
		} while (numero < 1 || numero > 10);
		
		for(int i = numero; i >= 0; i--)
		{
			Console.Write(i + " ");
		}
		
	}
}
