
//Enunciado:
// * Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números.
// * Imprimir en pantalla el resultado de cada operación.

// #1: Definir el nombre de mi clase con su respectivo método Main.

public class Calculator
{
    static void Main(string[] args)
    { 
        // #2: Declaración de mis variables (Datos de entrada)
        int num1, num2, suma, resta, producto, cociente;

        // #3: Pedir los valores por pantalla (Consola):
        Console.WriteLine("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());        // Solamente recibe tipos de datos String

        Console.WriteLine("Ingrese su segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());        // Solamente recibe tipos de datos String

        // #4: Cálculos (Procesos)
        suma = num1 + num2;
        resta = num1 - num2;
        producto = num1 * num2;
        cociente = num1 / num2;

        // #5: Imprimer los resultados (Datos de salida)
        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("\n");
        Console.WriteLine("La resta es: " + resta);
        Console.WriteLine("\n");
        Console.WriteLine("El producto es: " + producto);
        Console.WriteLine("\n");
        Console.WriteLine("El cociente es: " + cociente);
    }
}
