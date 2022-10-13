// See https://aka.ms/new-console-template for more information


              // Vincenzi  Alberto   4E    2022-09-22

using System;
using System.Threading;
using static System.Console;

namespace ConsolAppCorsa
{
    class program
    {
        static int posAndrea = 0;
        static int posBaldo = 0;
        static int posCarlo = 0;

        static void Pronti()
        {
            SetCursorPosition(posAndrea, 2);
            Write("Andrea");
            SetCursorPosition(posAndrea, 3);
            Write(" []");
            SetCursorPosition(posAndrea, 4);
            Write(@" /\");
            SetCursorPosition(posAndrea, 5);
            Write(@" /\");
            SetCursorPosition(posBaldo, 6);
            Write("Baldo");
            SetCursorPosition(posAndrea, 7);
            Write(@" /\");
            SetCursorPosition(posAndrea, 8);
            Write(@" /\");


        }

        static void Main(string[] args)
        {

            Console.WriteLine("Vincenzi  Alberto   4E    2022-09-22");

            CursorVisible = false;
            //

            Pronti();


            ReadLine();













        }



    }

}