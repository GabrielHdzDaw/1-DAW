/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 11-10-2024
 * Descripción: Crea un fragmento de programa en C# que asigne a la variable
 * “multiplo” (entera) el valor 2 si las variables “a”
y “b” tienen valores múltiplos de 7, el valor 1 si sólo una es múltiplo de 7, 
o el valor 0 si ambas no son múltiplos de
7. Hazlo de dos formas: primero con “if” y luego usando el 
operador condicional (?) (2 puntos).
 */ 
 


using System;
public class Ejercicio3
{
	public static void Main()
	{
		int a = 14, b = 3, multiplo;
		
		if(a % 7 == 0 && b % 7 == 0)
		{
			multiplo = 2;
		}
		else
		{
			if(a % 7 == 0 || b % 7 == 0)
			{
				multiplo = 1;
			}
			else
			{
				multiplo = 0;
			}
		}
		
		multiplo = a % 7 == 0 && b % 7 == 0 ? 2: a % 7 == 0 || b % 7 == 0 ? 1 : 0;
	}
}
