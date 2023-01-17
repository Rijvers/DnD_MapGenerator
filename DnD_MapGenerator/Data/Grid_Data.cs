using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_MapGenerator.Data
{

    class Grid_Data
    {
        public Tile_Data[,] Tile_Data_Array { get; set; }

        public Grid_Data(int X_Tiles, int Y_Tiles)
        {
            Tile_Data_Array = new Tile_Data[X_Tiles, Y_Tiles];
        }

    }
}
