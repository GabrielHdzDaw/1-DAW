/*
 * Autor: Gabriel Hernández Collado
 * Fecha: 21-10-2024
 * Descripción: OTRA CALCULADORA
Crea una calculadora que reciba del usuario un número, una operación y otro número y
 muestre el resultado de la operación:

Número? 5
Operación? +
Número? 3
5 + 3 = 8

Consideraciones:

    Las operaciones básicas permitidas deberán ser + (suma), - (resta), * 
    (multipliación), / (división)
    También debe permitir la potencia (P), que se calculará de forma
     repetitiva mediante un "while", y la raíz cuadrada (R), que se calculará 
     usando Math.Sqrt (para la raíz cuadrada no se pedirá un segundo número).
    Debe repetirse hasta que se teclee "fin" en lugar del primer número.
    Debe emplear números "double"


Otros ejemplos de ejecución:

Número? 2
Operación? P
Número? 8
2 ^8 = 256

Número? 9
Operación? R
R 9 = 3

Número? 5
Operación? *
Número? 3
5 * 3 = 15

Número? fin
Hasta otra...
 *  
 */

using System;
public class OtraCalculadora
{
	public static void Main()
	{
			double operando1, operando2 = 0, resultado = 0;
			string operando1String;
			char operador;
			
			do
			{
				Console.Write("Introduce el primero operando: ");
				operando1String = Console.ReadLine();
				if (operando1String != "fin")
				{
					operando1 = Convert.ToDouble(operando1String);
					Console.Write("Introduce el operador (+, -, *, /, P, R): ");
					operador = Convert.ToChar(Console.ReadLine());
					if (operador != 'R')
					{
						Console.Write("Introduce el segundo operando: ");
						operando2 = Convert.ToDouble(Console.ReadLine());
					}
				
					switch (operador)
					{
						case '+':
							resultado = operando1 + operando2;
							break;
						case '-':
							resultado = operando1 - operando2;
							break;
						case '*':
							resultado = operando1 * operando2;
							break;
						case '/':
							resultado = operando1 / operando2;
							break;
						case 'P':
							int i = 1;
							resultado = operando1;
							while(i < operando2)
							{
								resultado *= operando1;
								i++;
							}
							break;
						case 'R':
							resultado = Math.Sqrt(operando1);
							break;
						default:
							Console.WriteLine("Operador no válido.");
							break;
					}
					if (operador != 'R')
					{
						Console.WriteLine("{0} {1} {2} = {3}", operando1, operador, operando2, resultado);
					}
					else
					{
						Console.WriteLine("{0} ^ 2 = {1}", operando1, resultado);
					}
				}
			}while(operando1String != "fin");
		}
}	


