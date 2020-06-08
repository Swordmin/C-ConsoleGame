using System;

namespace TestGame
{
    class Start
    {

        static void Main(string[] args)
        {
            StartGame startGame = new StartGame();
            Console.WriteLine("StartGame");
            startGame.InitializationGame();
        }
    }
}
