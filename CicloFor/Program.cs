class Punto_14
{

    static void Main(string[]args)
    {
        /* Elabora un algoritmo que imprima los números del 1 al 100.
         * Que calcule la suma de todos los números pares por un lado, y por otro,
         * la de todos los impares.*/

        //1. Declaración de variables
        int sumaPares = 0, sumaImpares = 0;

        for (int i = 1; i <= 100; i++)
        {
            Console.Write($"{i} ");

            if (i % 2 == 0)
            {
                sumaPares += i; // sumaPares = sumaPares + 1
            }
        else
            {
                sumaImpares += i; //sumaImpares = sumaImpares + 1
            }

        }


        Console.Write("\n");
        Console.Write($"La suma de los pares es = {sumaPares}");
        Console.Write("\n");
        Console.Write(String.Format("La suma de los Impares es = {0}", sumaImpares));
    }


    }