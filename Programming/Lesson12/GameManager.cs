using System;

namespace Lesson12
{
    public class GameManager
    {
        private bool _isRunning = true;
        private IGame _game;

        public GameManager(IGame game)
        {
            _game = game;
        }

        public void Loop()
        {
            Console.WriteLine("Welcome lol");
            while (_isRunning)
            {
                Console.WriteLine("haha");
            }
        }
        
    }
}