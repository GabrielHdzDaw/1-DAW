using System;

public class Ejercicios
{
	public static void Main()
	{	
		/*Console.Write("Introduce un número de segundos: ");
		int segundos = Convert.ToInt32(Console.ReadLine());
		int segundosRestantes = segundos % 60;
		int minutos = segundos / 60;
		int minutosRestantes = minutos % 60;
		int horas = minutos / 60;
		Console.WriteLine("{0} horas, {1} minutos, {2} segundos.", horas, minutosRestantes, segundosRestantes);
		*/
		
		/*Console.Write("Introduce un número de millas náuticas: ");
		int millas = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("{0} millas = {1} metros", millas, millas * 1852);
		*/
		
		Console.Write("Introduce un número de grados centígrados: ");
		float centigrados = float.Parse(Console.ReadLine());
		Console.WriteLine("{0} ºC = {1} ºF", centigrados, (centigrados * 1.8) + 32);
	}
}
