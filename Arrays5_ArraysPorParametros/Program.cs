using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En esta practica se va a crear un array en el cual se pediran datos al usuario a traves de un metodo y se va a pasar por parametros el array al metodo
namespace Arrays5_ArraysPorParametros
{


    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 3               ;
            numeros[2] = 4;
            numeros[3] = 1;


            ProcessDatos(numeros);

           foreach(int num in numeros)
           {
                Console.WriteLine(num);
           }
             */
            #endregion   //Inicializacion e impresion de array a traves del metodo 

            int[] arraymain = LeerDatos();

            foreach(int num in arraymain)
            {
                Console.WriteLine(num);
            }
            



        }
        static void ProcessDatos(int[] datos)
        {

            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = datos[i] + 10;

            }


        }

        static int[] LeerDatos()
        {
            int[] array ;
            int tamano_array;
            int dato;
            Console.WriteLine(" Ingresa la cantidad de elementos en el array ");
            tamano_array = int.Parse(Console.ReadLine());
            array = new int[tamano_array];


            for(int i=0; i<tamano_array;i++)
            {
                Console.WriteLine("Introduce el dato para la posicion "+ i);
                dato = int.Parse(Console.ReadLine());
                array[i] = dato;


            }


            return array;
        }
        static void PedirDosNumeros()
        {
            int valor1, valor2;
            Console.WriteLine("Introduce the first value");
            valor1 = int.Parse(Console.ReadLine()); // 1 opcion
                                                    //value1 = Convert.ToInt32(Console.ReadLine()); // 2opcion
            Console.WriteLine("Introduce the second value");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(valor1) ;
            Console.WriteLine(valor2);
        }

    }
}
