using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Ingresa un operador (+, -, *, /): ");
        string operador = Console.ReadLine();

        // Variable para almacenar el resultado
        double resultado = 0;

        // Determinar la operación a realizar utilizando if-else
        if (operador == "+")
        {
            resultado = num1 + num2;
        }
        else if (operador == "-")
        {
            resultado = num1 - num2;
        }
        else if (operador == "*")
        {
            resultado = num1 * num2;
        }
        else if (operador == "/")
        {
            if (num2 != 0)
            {
                resultado = num1 / num2;
            }
            else
            {
                Console.WriteLine("División por cero.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Operador no válido.");
            return;
        }

        // Imprimir el resultado
        Console.WriteLine($"Resultado: {resultado}");
    }
}
