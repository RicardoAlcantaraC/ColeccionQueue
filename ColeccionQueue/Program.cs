using System;
using System.Collections.Generic;

namespace ColeccionQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ejemplo1();              
        }

        public static void ejemplo1()
        {
            Queue<int> numeros = new Queue<int>();

            //Agregar elementos
            foreach (int item in new int[5] {1,2,3,4,5})
            {
                numeros.Enqueue(item);
            }

            Console.WriteLine("Cola original");
            imprimir(numeros);

            //Eliminando elementos
            numeros.Dequeue();
            Console.WriteLine("Cola después de eliminar elementos");
            imprimir(numeros);
        }

        public static void imprimir(Queue<int> cola)
        {
            foreach (int item in cola)
            {
                Console.WriteLine(item);
            }

        }


    }
}
