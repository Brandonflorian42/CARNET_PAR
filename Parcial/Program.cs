using System;

namespace PrograNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Solicitar al usuario que ingrese un número entero positivo mayor que cero
            Console.Write("Por favor, Ingresar un número entero positivo mayor que cero: ");
            int n = int.Parse(Console.ReadLine());

            // 2) Declarar variable suma e inicializarla en cero
            int suma = 0;

            // 3) Calcular la suma de los primeros N números enteros positivos y alamacenar el resultado en una variable "suma"
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            // 4) Imprimir en la pantalla todos los números enteros positivos menores o iguales que N
            Console.WriteLine("Los números enteros positivos menores o iguales que {0} son:", n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            // 5) Imprimir en la pantalla todos los números enteros impares menores o iguales que N
            Console.WriteLine("Los números enteros impares menores o iguales que {0} son:", n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            // 6) Imprimir en la pantalla la tabla de multiplicar del número N, desde el 1 hasta el 10
            Console.WriteLine("La tabla de multiplicar del número {0} es:", n);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }

            // 7) Imprimir en la pantalla la secuencia de números enteros positivos que comienzan en N y se incrementan en 2 hasta que se alcance un valor mayor que 20
            Console.WriteLine("La secuencia de números enteros positivos que comienzan en {0} y se incrementan en 2 hasta que se alcance un valor mayor que 20 es:", n);
            int j = n;
            while (j <= 20)
            {
                Console.Write("{0} ", j);
                j += 2;
            }
            Console.WriteLine();

            // 8) Imprimir en la pantalla el valor de la variable suma al final del proceso
            Console.WriteLine("El valor de la variable suma es: {0}", suma);
        }
    }
}
