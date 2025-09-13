/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 24-10-2024
 * Descripción: 

Un garaje cobra 2,20 euros por cada hora de aparcamiento. Crea un programa que pida la hora 
de entrada (como un número de 4 cifras: 1000 para las 10:00) y la hora de salida (1350 para la 1.50 de la tarde),
 y muestre el importe a pagar, en dos supuestos distintos:

- Si cada hora o fracción se cobra completa (de 1000 a 1105 se cobrarían dos horas).

- Si se paga por minutos (de 1000 a 1105 se cobrarían 65 minutos).

El programa se debe repetir hasta que el usuario introduzca "fin" como hora inicial. 
Ten presente que desde las 1000 hasta las 1100 no hay 100 minutos, sino 60 (te puede interesar 
descomponer esas cifras en dos, usando los operadores / y %).

 * 
 */

using System;
public class Parking
{
	const double PRECIO_HORA = 2.20;
	const double PRECIO_MINUTO = 0.03;
	public static void Main()
	{
		string horaEntradaString;
		int horaEntrada, horaSalida, horaEntradaSeparada, minutosEntradaSeparados, horaSalidaSeparada, 
		minutosSalidaSeparados, totalHoras, totalMinutos;
		
		do
		{
			Console.Write("Introduce hora de entrada: ");
			horaEntradaString = Console.ReadLine();
			if(horaEntradaString != "fin")
			{
				horaEntrada = Convert.ToInt32(horaEntradaString);
				Console.Write("Introduce hora de salida: ");
				horaSalida = Convert.ToInt32(Console.ReadLine());
				
				horaEntradaSeparada = horaEntrada / 100;
				minutosEntradaSeparados = horaEntrada % 100;
				horaSalidaSeparada = horaSalida / 100;
				minutosSalidaSeparados = horaSalida % 100;
				
				totalHoras = minutosSalidaSeparados - minutosEntradaSeparados > 0 ? horaSalidaSeparada - horaEntradaSeparada + 1 : horaSalidaSeparada - horaEntradaSeparada;
				totalMinutos = (horaSalidaSeparada * 60 + (minutosSalidaSeparados - minutosEntradaSeparados));
				Console.WriteLine(totalMinutos);
				Console.WriteLine("Importe precio por horas: {0}", totalHoras * PRECIO_HORA);
				Console.WriteLine("Importe precio por minutos: {0}", totalMinutos * PRECIO_MINUTO);
				
			}
		} while (horaEntradaString != "fin");
		
	}
}
