using System.Collections;
using System.Collections.Generic;

namespace OOAD
{
    public class Board
    {
        private int _height;
        private int _width;
        private ArrayList tiles;
        public Board(int width, int height)
        {
            this._width = width;
            this._height = height;
            InitializeTiles();
        }

        private void InitializeTiles()
        {
            tiles = new ArrayList(_width);
            for (int i = 0; i < _width; i++)
            {
                tiles.Insert(i, new ArrayList(_height));
                for (int j = 0; j < _height; j++)
                {
                    ((ArrayList)tiles[i])?.Insert(j,new Tile());
                }
            }
        }
    }
}
