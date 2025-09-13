using System;
using System.Threading;


public class Test
{
   

    public static void Main()
    {
        // Maximiza la ventana de la consola
       

        Random generator = new Random();

        while (true)
        {
            // Verifica el tamaño de la ventana en cada iteración para asegurarse de que esté actualizado
            int anchura = Console.WindowWidth;
            int altura = Console.WindowHeight;

            ConsoleColor[] colores = {
                ConsoleColor.Black,
                ConsoleColor.DarkBlue,
                ConsoleColor.DarkGreen,
                ConsoleColor.DarkCyan,
                ConsoleColor.DarkRed,
                ConsoleColor.DarkMagenta,
                ConsoleColor.DarkYellow,
                ConsoleColor.Gray,
                ConsoleColor.DarkGray,
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Red,
                ConsoleColor.Magenta,
                ConsoleColor.Yellow,
                ConsoleColor.White
            };

            // Dibuja caracteres de colores aleatorios
            for (int i = 0; i < 100; i++)
            {
                int x = generator.Next(0, anchura);
                int y = generator.Next(0, altura);

                // Asegurarse de que las coordenadas están dentro de los límites de la ventana
                if (x < anchura && y < altura)
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = colores[generator.Next(colores.Length)];
                    Console.BackgroundColor = colores[generator.Next(colores.Length)];
                    Console.Write('*');
                }
            }

            Thread.Sleep(1);
            Console.Clear();
        }
    }

    
}
