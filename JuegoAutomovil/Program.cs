using System;
using System.Threading;


namespace JuegoAutomovil
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Jueguito";
            Console.CursorSize = 50;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = true;
            
            string cochecito = "\t";
            Console.Write(cochecito);
            int x = 0, y=0;

            while(true)
            {
                Console.SetCursorPosition(x+=1,y+=1);
                Console.Write("x");
                Thread.Sleep(500);
                Console.Clear();

            }


            Console.ReadLine();

        }
    }
}
