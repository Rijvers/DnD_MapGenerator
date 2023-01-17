using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_MapGenerator.Settings
{
    public enum GridType { Square, Hexagon }

    class Grid_Settings
    {
        //int)SquareSize_NS.Value, (int) X_Offset_NS.Value, (int) Y_Offset_NS.Value, (int) X_Reduction_NS.Value, (int) Y_Reduction_NS.Value
        //Data Settings
        GridType gridType = GridType.Square;

        //Graphic Settings
        public int TileSize { get; set; }
        public int X_Offset { get; set; }
        public int Y_Offset { get; set; }
        public int X_Reduction { get; set; }
        public int Y_Reduction { get; set; }
        public float Hightlight_Opacity { get; set; }
        public float TileTexture_Opacity { get; set; }

        public Grid_Settings(GridType gridType, int TileSize, int X_Offset, int Y_Offset, int X_Reduction, int Y_Reduction, float Hightlight_Opacity, float TileTexture_Opacity)
        {
            this.gridType = gridType;
            this.TileSize = TileSize;
            this.X_Offset = X_Offset;
            this.Y_Offset = Y_Offset;
            this.X_Reduction = X_Reduction;
            this.Y_Reduction = Y_Reduction;
            this.Hightlight_Opacity = Hightlight_Opacity;
            this.TileTexture_Opacity = TileTexture_Opacity;
        }
    }
}
