// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

namespace gato
{

    class juego
    {
        public static char[,] activeboard = new char[3, 3];
        public static int selectindexfile = 0;
        public static int selectindexrow = 0;
        public static int loop = 0;
        public static bool gameover = false;

        static void Main()
        {

            char[,] board = new char[3, 3];


            Console.WriteLine("\t\t\t**********************Welcome to tic tac game**********************");


            DisplayBoardIndex();


            Console.WriteLine("\n\t\t\t\t Please introduce a O OR  X in the next indexes");


            DisplayInitialBoard();


            Console.WriteLine("\n\n\t\t\t\t\t++++++The game beigns++++++\n");

            while (!gameover)
            {

                
                    DisplayActiveBoard(); // shows the active board  

                    DisplayBoardIndex();  // shows the indexes in the board
                    
                



               // lastturn();

                //verifyWinnerOne();//verifica ganador 1 
                //verifyWinnerTwo();//verfica  ganador 2

            }



        }


        public static void DisplayBoardIndex() // This function displays the (indexes) in the board
        {
            int[,] board = new int[3, 3];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    board[i, j] = i;  //Como asignar i y j respectivamente 

                }

            }


            Console.WriteLine("\t\t\t\t\t\t ___ ___ ___");
            for (int k = 0; k < 3; k++)
            {

                Console.Write("\t\t\t\t\t\t|");
                for (int l = 0; l < 3; l++)
                {

                    Console.Write("" + board[k, l] + board[l, k] + " |");


                }
                Console.WriteLine("\n\t\t\t\t\t\t|___|___|___|");


            }



        }
        public static void DisplayActiveBoard()
        {
         
            Console.WriteLine("THE FIRST PLAYER BEGINS");


            Console.WriteLine("Introduce in which file do you want to introduce your mark");
            selectindexfile = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce in which row do you want to introduce your mark");
            selectindexrow = int.Parse(Console.ReadLine());


            activeboard[selectindexfile, selectindexrow] = 'O';  // POR QUE LAS FILAS Y LAS COLUMNAS ESTAN VOLTEADAS?

            verifyWinnerOne();
            verifyWinnerTwo();

            if (gameover == false)
            {
                Console.WriteLine("........");


                Console.WriteLine("THE SECOND PLAYER BEGINS");

                Console.WriteLine("Introduce in which file do you want to introduce your mark");
                selectindexfile = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduce in which row do you want to introduce your mark");

                selectindexrow = int.Parse(Console.ReadLine());


                activeboard[selectindexfile, selectindexrow] = 'X';

                verifyWinnerOne();
                verifyWinnerTwo();

                Console.WriteLine("\t\t\t\t\t\t ___ ___ ___");
                for (int k = 0; k < 3; k++)
                {

                    Console.Write("\t\t\t\t\t\t|");
                    for (int l = 0; l < 3; l++)
                    {



                        Console.Write(" " + activeboard[k, l] + " |");


                    }

                    Console.WriteLine("\n\t\t\t\t\t\t|___|___|___|");




                }
                

              
            }
            else
            {
                Console.WriteLine("\t\t\t\t\t\t ___ ___ ___");
                for (int k = 0; k < 3; k++)
                {

                    Console.Write("\t\t\t\t\t\t|");
                    for (int l = 0; l < 3; l++)
                    {



                        Console.Write(" " + activeboard[k, l] + " |");


                    }

                    Console.WriteLine("\n\t\t\t\t\t\t|___|___|___|");




                }
            }
        }
        public static void DisplayInitialBoard()
        {
            Console.WriteLine("\t\t\t\t\t\t ___ ___ ___");
            for (int k = 0; k < 3; k++)
            {

                Console.Write("\t\t\t\t\t\t|");
                for (int l = 0; l < 3; l++)
                {


                    activeboard[k, l] = '?';
                    Console.Write(" " + activeboard[k, l] + " |");


                }

                Console.WriteLine("\n\t\t\t\t\t\t|___|___|___|");




            }

        }// This function display the initial board its gonna be the playable board
        public static void lastturn()
        {
            Console.WriteLine("THE FIRST PLAYER BEGINS");

            Console.WriteLine("Introduce in which file do you want to introduce your mark");
            selectindexfile = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce in which row do you want to introduce your mark");
            selectindexrow = int.Parse(Console.ReadLine());
            activeboard[selectindexfile, selectindexrow] = 'O';

            Console.WriteLine("\t\t\t\t\t\t ___ ___ ___");
            for (int k = 0; k < 3; k++)
            {

                Console.Write("\t\t\t\t\t\t|");
                for (int l = 0; l < 3; l++)
                {



                    Console.Write(" " + activeboard[k, l] + " |");


                }

                Console.WriteLine("\n\t\t\t\t\t\t|___|___|___|");


            }
            
        }
       public static void verifyWinnerOne()
        {
            if ((activeboard[0, 0] == 'O') && (activeboard[1, 1] == 'O') && (activeboard[2, 2] == 'O'))
            {
                Console.WriteLine("\t\t\t++++++++++++++++++++++PLAYER ONE WINS RIGHT++++++++++++++++++++++");
                gameover = true;
                Console.WriteLine(gameover);
               
            }

            else if (activeboard[2, 0] == 'O' && activeboard[1, 1] == 'O' && activeboard[0, 2] == 'O') 
            {
                Console.WriteLine("\t\t\t-------------------------PLAYER ONE WINS LEFT---------------------");
                gameover = true;
                Console.WriteLine(gameover);
                
            }

            for (int i = 0; i < 2; i++)
            {
                if (activeboard[0, i] == 'O' && activeboard[1, i] == 'O' && activeboard[2, i] == 'O') //3 HORIZONTAL LINES VERIFICATION
                {
                    Console.WriteLine("\t\t\t***********************PLAYER ONE WINSHHHH*********************");
                    gameover = true;
                    Console.WriteLine(gameover);
                    
                }

                else if (activeboard[i, 0] == 'O' && activeboard[i, 1] == 'O' && activeboard[i, 2] == 'O') //3 VERTICAL LINES VERIFICATION
                {
                    Console.WriteLine("\t\t\t***********************PLAYER ONE WINSVVVV*********************");
                    gameover = true;
                    
                    Console.WriteLine(gameover);
                    
                }


               
            }
            
        }

        public static void verifyWinnerTwo()
        {


            if ((activeboard[0, 0] == 'X') && (activeboard[1, 1] == 'X') && (activeboard[2, 2] == 'X'))
            {
                Console.WriteLine("\t\t\t++++++++++++++++++++++PLAYER TWO WINS RIGHT++++++++++++++++++++++");
                gameover = true;
                Console.WriteLine(gameover);
                
            }

            else if (activeboard[2, 0] == 'X' && activeboard[1, 1] == 'X' && activeboard[0, 2] == 'X')
            {
                Console.WriteLine("\t\t\t-------------------------PLAYER TWO WINS LEFT---------------------");
                gameover = true;
                Console.WriteLine(gameover); 
                
            }

            for (int i = 0; i < 2; i++)
            {
                if (activeboard[0, i] == 'X' && activeboard[1, i] == 'X' && activeboard[2, i] == 'X') //3 HORIZONTAL LINES VERIFICATION
                {
                    Console.WriteLine("\t\t\t***********************PLAYER TWO WINSHHHH*********************");
                    gameover = true;
                    Console.WriteLine(gameover);
                   
                }

                else if (activeboard[i, 0] == 'X' && activeboard[i, 1] == 'X' && activeboard[i, 2] == 'X') //3 VERTICAL LINES VERIFICATION
                {
                    Console.WriteLine("\t\t\t***********************PLAYER TWO WINSVVVV*********************");
                    gameover = true;
                    Console.WriteLine(gameover);
                    break;
                }

            }
         


        }

    }

}

