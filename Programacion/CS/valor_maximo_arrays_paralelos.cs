/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 04-11-2024
 * Descripción: Crea dos arrays paralelos. Uno guardará el nombre de 5 estudiantes y el
 *  otro sus notas, como en el ejemplo:

Sergio, 8.2

Fernando, 8.1

Antonio, 7.9

Irene, 8.0

Samuel, 8.0

Enseña el nombre del estudiante con la nota más alta.
 * 
 */

using System;
public class ValorMaximoArraysParalelos
{
	public static void Main()
	{
		string[] estudiantes = {"Sergio", "Fernando", "Antonio", "Irene", "Samuel"};
		double[] notas = {6.7, 8.9, 4.3, 10, 9.5};
		double mayor = notas[0];
		for (int i = 0; i < notas.Length; i++)
		{
			mayor = notas[i] > mayor ? notas[i] : mayor;
		}
		int contador = 0;
		while (notas[contador] != mayor)
		{
			contador++;
		}
		
		Console.WriteLine("{0} tiene la nota más alta.", estudiantes[contador]);
	}
}
