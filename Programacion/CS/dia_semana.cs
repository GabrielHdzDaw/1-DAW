/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 08-10-2024
 * Descripción: Crea un programa en C# que le pida al usuario un
 *  número entre 1 y 7 y saque por pantalla el día de la semana correspondiente. ("Lunes", "Martes"...)

Crea otra versión donde se compruebe que el número está entre 1 y 7 y se siga pidiendo hasta que el número sea correcto
 */ 
 


using System;
public class DiaSemana
{
	public static void Main()
	{
		int numero = 0; 
		
		do
		{
			Console.Write("Introduce un número entre 1 y 7: ");
			numero = Convert.ToInt32(Console.ReadLine());
			
		} while (numero < 1 || numero > 7);
		
		
		switch (numero)
		{
			case 1:
				Console.WriteLine("Lunes");
				break;
			case 2:
				Console.WriteLine("Martes");
				break;
			case 3:
				Console.WriteLine("Miércoles");
				break;
			case 4:
				Console.WriteLine("Jueves");
				break;
			case 5:
				Console.WriteLine("Viernes");
				break;
			case 6:
				Console.WriteLine("Sábado");
				break;
			case 7:
				Console.WriteLine("Domingo");
				break;
			default:
				Console.WriteLine("No es un número válido");
				break;
		}
		
	}
}
