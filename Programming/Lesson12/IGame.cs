using System.Collections.Generic;

namespace Lesson12
{
    public enum MapTile
    {
        Spawn,
        Wall,
        Empty,
        Exit,
    }
    
    public interface IGame
    {
        List<List<MapTile>> Map { get; set; }
        
        short X { get; set; }
        short Y { get; set; }
        
        bool CanMoveUp();
        bool CanMoveDown();
        bool CanMoveLeft();
        bool CanMoveRight();

        void DisplayMap();
    }
}