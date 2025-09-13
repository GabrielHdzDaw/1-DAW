/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 04-10-2024
 * Descripción: Crea un programa en C# que enseñe los múltiplos de 3 entre -30 y -10 que no son múltiplos de 7.

        - Usando "for" contando de 1 en 1

        - Usando "for" contando de 3 en 3

        - Usando "while"

        - Usando "do while"
 */ 
 


using System;
public class Repetitivo
{
	public static void Main()
	{
		//for(int i = -30; i <= -10; i++)
		//{
			//if(i % 3 == 0 && i % 7 != 0)
			//{
				//Console.Write("{0} ", i);
			//}
		//}
		
		
		
		//for(int i = -30; i <= -10; i+=3)
		//{
			//if(i % 3 == 0 && i % 7 != 0)
			//{
				//Console.Write("{0} ", i);
			//}
		//}
		
		
		
		int i = -30;
		while(i <= -10)
		{
			if(i % 3 == 0 && i % 7 != 0)
			{
				Console.Write("{0} ", i);
			}
			i++;
		}
		
		i = -30;
		while(i <= -10)
		{
			if(i % 3 == 0 && i % 7 != 0)
			{
				Console.Write("{0} ", i);
			}
			i+=3;
		}
		
		i = -30;
		do
		{
			if(i % 3 == 0 && i % 7 != 0)
			{
				Console.Write("{0} ", i);
			}
			i++;
		}while(i <= -10);
		
		i = -30;
		do
		{
			if(i % 3 == 0 && i % 7 != 0)
			{
				Console.Write("{0} ", i);
			}
			i+=3;
		}while(i <= -10);
	}
}
