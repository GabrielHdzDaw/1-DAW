/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 08-10-2024
 * Descripción: Crea un programa en C# que pidas números (notas) 
 * hasta que el usuario introduzca un -1 y luego diga cuantos son mayores de 5.
Además deberá sacar si hay más aprobados que suspendidos o no.
Necesitaréis saber cuantos números en total se han introducido para saber si hay más aprobados o suspendidos.
 */ 
 


using System;
public class ContarAprobados
{
	public static void Main()
	{
		int nota, contadorNotas = 0, contadorAprobados = 0, contadorSuspendidos;
		
		do
		{
			
			Console.Write("Introduce una nota: ");
			nota = Convert.ToInt32(Console.ReadLine());
			
			if (nota >= 5)
			{
				contadorAprobados++;
			}
			if (nota != -1)
			{
				contadorNotas++;
			}
		} while (nota != -1);
		
		contadorSuspendidos = contadorNotas - contadorAprobados;
		
		Console.WriteLine("Hay {0} aprobados.", contadorAprobados);
		Console.WriteLine(contadorSuspendidos > contadorAprobados ? "Hay más suspensos que aprobados." : "Hay más aprobados que suspendidos.1");
	}
}
