using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_MapGenerator.Data
{
    public enum TileTexture { NoTexture, Desert_Caves_Square, Desert_Mountain1_Square, Desert_Mountain2_Sqaure, Desert_Pit_Square, Desert_Rock_Square, Desert_Sand1_Square, Desert_Sand2_Square, Desert_Stone1_Square, Desert_Stone2_Square, Deset_Rock1_Square,
        Forest_Heavy_Square_Small, Forest_Light_Square, Grass_Clearing_Square, Grass_Mountain1_Square, Grass_Mountain2_Square, Grass_Rock1_Square, Grass_Rock2_Square, Grass_Square_Small, Ice_Mountain1_Square, Ice_Mountain2_Square, Ice_Mountain3_Square,
        Ice1_Square, Ice2_Square, Mountain1_Square, Mountain2_Square, Mountain3_Square, Forest_Mountain1_Square, Forest_Mountain2_Square, Water_Deep_Square, Water_Square_Small}

    class Tile_Data
    {
        public TileTexture tileTexture { get; set; } = TileTexture.NoTexture;
        public Color color { get; set; } = Color.White;
        public bool UseColor { get; set; } = false;

        public Tile_Data()
        {

        }

    }
}
