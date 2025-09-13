/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 01-10-2024
 * Descripción: Crea un programa en C# que nos diga cuántos 
 * números primos hay entre 2 números suministrados por el usuario.
 */ 
 


using System;
public class ContarPrimos2
{
	public static void Main()
	{
		int numero1, numero2, divisores = 0, primos = 0, i, menor, mayor;
		do
		{
			Console.Write("Introduce un número: ");
			numero1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduce otro número: ");
			numero2 = Convert.ToInt32(Console.ReadLine());
			
		}while(numero1 < 1 && numero2 < 1);
		
		mayor = numero1 > numero2 ? numero1 : numero2;
		menor = numero1 < numero2 ? numero1 : numero2;
		
		for(i = menor; i <= mayor; i++)
		{
			divisores = 0;
			for(int j = 2; j < i; j++)
			{
				if(i % j == 0)
				{
					divisores++;
				}
			}
			if (divisores < 1)
			{
				primos++;
			}
		}
		Console.Write("Desde {0} hasta {1} hay {2} números primos", numero1, numero2, primos);
	}
}
