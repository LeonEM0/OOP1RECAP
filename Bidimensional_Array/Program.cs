using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidimensional_Array
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo1d = new int[3]; //arreglo unidimensional

            int[,] arreglo2d = new int[3, 3];
            int[,] arreglo2_2d = new int[3, 3] {{10,10,10},{20,20,20},{30,30,30} };

            int[,] sumarray2d = new int[3,3];

            float[,] arreglofloat = new float[2,4];
            string[,] arreglostring2d = new string[2,5];


            for (int i = 0; i < arreglo1d.Length; i++)
            {
                Console.WriteLine("Introduce a number in the position " + i);

                arreglo1d[i] = int.Parse(Console.ReadLine());
            
            }

            for (int i = 0; i < arreglo1d.Length; i++)
            {
                Console.WriteLine(" [" + i + "]" + arreglo1d[i]);

            }

            
            FillArrayString(arreglostring2d);
            /*
            FillArray2DFloat(arreglofloat);

            FillArray1D(arreglo1d);
            */
            //array2d
            /*
            FillArray2D(arreglo2d);

            sumarray2d = SumArray2d(arreglo2d, arreglo2_2d);
           
            for(int i = 0; i<sumarray2d.GetLength(0);i++)
            {
                for(int j = 0; j<sumarray2d.GetLength(1);j++)
                {
                    Console.Write(sumarray2d[i,j]);
                }
                Console.WriteLine();
            }

            */
            Console.ReadKey();


        }
        public static void FillArray1D(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introduce a number in the position " + i);

                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" [" + i + "]" + array[i]);

            }

        }
        public static void FillArray2D(int[,] array2d)
        {
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.WriteLine("Introduce the number in the position " + i + j);
                    array2d[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < array2d.GetLength(0); i++)  // corre el programa y despues aumenta 1
            {
                for (int j = 0; j < array2d.GetLength(1); j++)  // primero se ejecuta lo de adentro 
                {
                    Console.Write(array2d[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void FillArray2DFloat(float[,] arreglofloat)
        {
            for(int i = 0; i <arreglofloat.GetLength(0); i++)
            {
                for(int j = 0; j <arreglofloat.GetLength(1);j++)
                {
                    Console.WriteLine("Introduce the number in the index: "+i+j);
                    arreglofloat[i, j] = float.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arreglofloat.GetLength(0); i++)
            {
                for (int j = 0; j < arreglofloat.GetLength(1); j++)
                {
                    Console.Write("["+i+"]"+ "["+j+"]" + arreglofloat[i, j]);
                }
                Console.WriteLine();
            }

        }
        public static void FillArrayString(string[,] arraystr2d)
        {
            for(int i = 0; i<arraystr2d.GetLength(0);i++)
            {
                for(int j = 0; j<arraystr2d.GetLength(1);j++)
                {
                    Console.WriteLine("Introduce a name in the position: "+i+j);
                    arraystr2d[i, j] = Console.ReadLine();
                }
            }

           for(int i = 0; i<arraystr2d.GetLength(0);i++)
           {
                for (int j = 0; j < arraystr2d.GetLength(1); j++)
                {
                    Console.Write("[" + arraystr2d[i, j] +"]");
                }

                Console.WriteLine();
           }

        }
        public static int[,] SumArray2d(int[,] array1, int[,]array2)
        {
            int[,] arraysum = new int[3, 3];

            for(int i = 0; i<array1.GetLength(0);i++)
            {
                for (int j = 0; j < array1.GetLength(1);j++)
                {
                    arraysum[i, j] = array1[i, j] + array2[i, j];
                }
            }
            return arraysum ;


        }


    }
}


/* Ways to declare an array
 
 array1d
 int[] arreglo1 = new int[3];
 int[] arreglo2 = new int[] {1,2,3};
 int[] arreglo3 = new int[] {1,2,3};
 int[] arreglo4 = {1,2,3};
 array2d
 int[,] arreglo2d = new int[3,3];
 int[,] arreglo2d = new int[,] {{1,2,3},{4,5,6},{7,8,9}};
 int[,] arreglo2d = {{1,2,3},{4,5,6},{7,8,9}};

 property
 GetLength(0) = indicates the number of files in the 2d array [4,3] [4]
 GetLength(1) = indicates the number of columns in the 2d array [4,3] [3]         


*/
