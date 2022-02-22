using System.Collections.Generic;

namespace Lesson12
{
    public class Dungeon : IGame
    {
        public List<List<MapTile>> Map { get; set; }
        public short X { get; set; }
        public short Y { get; set; }

        public Dungeon()
        {
            var Map = new List<List<MapTile>>
            {
                new List<MapTile>() {MapTile.Wall, MapTile.Spawn, MapTile.Wall, MapTile.Wall, MapTile.Wall, MapTile.Wall,   },
                new List<MapTile>() {MapTile.Wall, MapTile.Empty, MapTile.Empty, MapTile.Empty, MapTile.Wall, MapTile.Wall, },
                new List<MapTile>() {MapTile.Wall, MapTile.Wall, MapTile.Wall, MapTile.Empty, MapTile.Wall, MapTile.Wall,   },
                new List<MapTile>() {MapTile.Exit, MapTile.Empty, MapTile.Wall, MapTile.Empty, MapTile.Wall, MapTile.Wall,  },
                new List<MapTile>() {MapTile.Wall, MapTile.Empty, MapTile.Empty, MapTile.Empty, MapTile.Wall, MapTile.Wall, },
                new List<MapTile>() {MapTile.Wall, MapTile.Wall, MapTile.Wall, MapTile.Wall, MapTile.Wall, MapTile.Wall,    }
            };
            
            X = 1;
            Y = 0;
        }

        public bool CanMoveUp()
        {
            return Map[Y][X] == MapTile.Empty;
        }
    }
}