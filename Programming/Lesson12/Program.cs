namespace Lesson12
{
    public static class Program
    {
        private static void Main()
        {
            var gameManager = new GameManager(
                new Dungeon()
            );
            gameManager.Loop();
        }
    }
}