using System;
using System.Collections.Generic;

namespace P4_ListasYNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");

            //Inicialización del array

            string[] numeros = new string[5] {"1", "2", "3", "4", "5"};

            //Modificaciones del array

            numeros[1] = "6";

            numeros[4] = "7";

            numeros[0] = null;

            //Reasignación de valores del array

            for (int i = 0; i < 4; i++)
            {
                numeros[i] = numeros[i+1];
            }

            numeros[4] = "8";   

            //Mostrar los valores del array        

            for (int i = 0; i < numeros.Length; i++)

            {
                Console.Write(numeros[i] + " ");
            } 

            //Creación de la lista de numeros 

            List<int> listaNumeros = new List<int>();

            Console.WriteLine(" ");

            Console.WriteLine(" ");

            //Asignacion de valores a la lista del 1 al 5

            for (int i = 0; i < 5; i++)
            {
                listaNumeros.Add(i + 1);
            }

            listaNumeros[1] = 6;

            listaNumeros[4] = 7;

            //Remover el primer número

            listaNumeros.RemoveAt(0);

            //Añadir el 8 al final

            listaNumeros.Add(8);

            //Añadir el 9 al final

            listaNumeros.Add(9);
            
            //Multiplicar los números de la lista *3

            for (int i = 0; i < listaNumeros.Count; i++)
            {
                listaNumeros[i] = listaNumeros[i] * 3;

            }

            // Eliminar los numeros de la lista que sean mayores a 20

            for (int i = 0; i < listaNumeros.Count; i++)
            {
                if (listaNumeros[i] > 20)
                {
                    listaNumeros.RemoveAt(i);

                    i--;

                }
            }     

            //Mostrar los valores de la lista
            
            for (int i = 0; i < listaNumeros.Count; i++)
            {

                Console.Write(listaNumeros[i] + " ");

            }
    
            // Crear una lista de números enteros

            List<int> listaNumeros1 = new List<int>();

            // Asignarle los numeros: 2, 6, 19, 34, 65, 12, 42, 33, 40, 15

            listaNumeros1.Add(2);
            listaNumeros1.Add(6);
            listaNumeros1.Add(19);
            listaNumeros1.Add(34);
            listaNumeros1.Add(65);
            listaNumeros1.Add(12);
            listaNumeros1.Add(42);
            listaNumeros1.Add(33);
            listaNumeros1.Add(40);
            listaNumeros1.Add(15);

            int NumeroMayor1 = 0;

            Console.WriteLine(" ");

            //Verificar el número mayor de la primer lista
          
            for(int i = 0; i < listaNumeros1.Count; i++)
            {
                if(listaNumeros1[i] > NumeroMayor1)
                {
                    NumeroMayor1 = listaNumeros1[i];
                }
            }       

            Console.WriteLine(" ");

            for(int i = 0; i < listaNumeros1.Count; i++)
            {
                Console.Write(listaNumeros1[i] + " ");
            }
            
            Console.WriteLine(" ");

            Console.WriteLine("El numero mayor de la lista es: " + NumeroMayor1);
            
        }
    }
}
