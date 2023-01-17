using DnD_MapGenerator.Data;
using DnD_MapGenerator.Properties;
using DnD_MapGenerator.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace DnD_MapGenerator
{
    public partial class MainForm : Form
    {
        //Pen pen = new Pen(Color.Black);
        //Brush brush = new SolidBrush(Color.Black);
        Random rdm = new Random();
        Image NextTileTexture;
        Color TextureColor = Color.White; bool Use_TextureColor = false;

        Grid_Settings grid_Settings;
        Grid_Data grid_Data;

        public MainForm()
        {
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            InitializeComponent();

            grid_Settings = new Grid_Settings(GridType.Square, (int)TileSize_NS.Value, (int)X_Offset_NS.Value, (int)Y_Offset_NS.Value, (int)X_Reduction_NS.Value, (int)Y_Reduction_NS.Value, 0.35f, 0.65f);
            Update_NewGrid_Tiles(MapPictureBox, grid_Settings);
            //grid_Data = new Grid_Data((int)X_Tiles_NS.Value, (int)Y_Tiles_NS.Value);

            Create_Grid();
        }

        private void Update_NewGrid_Tiles(PictureBox pictureBox, Grid_Settings grid_Settings)
        {
            X_Tiles_NS.Value = Math.Min(X_Tiles_NS.Max, Math.Max(X_Tiles_NS.Min, (int)Math.Floor((double)(pictureBox.Width - (grid_Settings.X_Offset + grid_Settings.X_Reduction)) / (double)grid_Settings.TileSize)));
            Y_Tiles_NS.Value = Math.Min(Y_Tiles_NS.Max, Math.Max(Y_Tiles_NS.Min, (int)Math.Floor((double)(pictureBox.Height - (grid_Settings.Y_Offset + grid_Settings.Y_Reduction)) / (double)grid_Settings.TileSize)));
        }

        private void UpdateGridSettings(Grid_Settings gridSettings)
        {
            //GridType
            gridSettings.TileSize = (int)TileSize_NS.Value;
            gridSettings.X_Offset = (int)X_Offset_NS.Value;
            gridSettings.Y_Offset = (int)Y_Offset_NS.Value;
            gridSettings.X_Reduction = (int)X_Reduction_NS.Value;
            gridSettings.Y_Reduction = (int)Y_Reduction_NS.Value;
            gridSettings.TileTexture_Opacity = ((int)TileAlpha_NS.Value) / 100f;

        }

        private void DrawTest_Button_Click(object sender, EventArgs e)
        {
            //MapPictureBox.Refresh(); //this will call for Paint event, so need to call for Call_Draw_Grid
            Call_Draw_Grid(MapPictureBox, grid_Settings, grid_Data);
            //draw call is getting called twiche
        }

        private void Call_Draw_Grid(PictureBox pictureBox, Grid_Settings grid_Settings, Grid_Data grid_Data)
        {
            //pictureBox.Invalidate();
            //pictureBox.Refresh();
            //Graphics g = Graphics.FromImage(pictureBox.Image);
            MapPictureBox.Refresh(); //this will call for Paint event, so need to call for Call_Draw_Grid
            //Draw_Grid(pictureBox.CreateGraphics(), pictureBox, grid_Settings, grid_Data);
            //Draw_Grid(g, pictureBox, grid_Settings, grid_Data);
        }

        private void Draw_Grid(Graphics g, PictureBox DrawPictureBox, Grid_Settings grid_Settings, Grid_Data grid_Data)
        {
            //DrawPictureBox.Image = BackGround_Image;
            //g.Clear(Color.White);

            Pen pen = Get_Pen();
            int Max_X = 0, Max_Y = 0;
            if (grid_Data != null)
            {
                Max_X = Math.Min(DrawPictureBox.Width - grid_Settings.X_Reduction, grid_Settings.X_Offset + (grid_Settings.TileSize * grid_Data.Tile_Data_Array.GetLength(0)));
                Max_Y = Math.Min(DrawPictureBox.Height - grid_Settings.Y_Reduction, grid_Settings.Y_Offset + (grid_Settings.TileSize * grid_Data.Tile_Data_Array.GetLength(1)));
            }
            else
            {
                Max_X = DrawPictureBox.Width - grid_Settings.X_Reduction;
                Max_Y = DrawPictureBox.Height - grid_Settings.Y_Reduction;
            }

            if (grid_Data != null)
            {
                for (int x = 0; x < grid_Data.Tile_Data_Array.GetLength(0); x++)
                {
                    for (int y = 0; y < grid_Data.Tile_Data_Array.GetLength(1); y++)
                    {
                        //Console.WriteLine("X:" + x + "/" + grid_Data.Tile_Data_Array.GetLength(0) + "| Y:" + y + "/" + grid_Data.Tile_Data_Array.GetLength(1));

                        if (grid_Data.Tile_Data_Array[x, y] != null)
                        {
                            if (grid_Data.Tile_Data_Array[x, y].UseColor)
                            {
                                //            SolidBrush Brush = new SolidBrush(Color.FromArgb((int)Pen_Alpha_NS.Value, 0, 0, 0));
                                Point Graphic_Coords = TranslateToGraphicCoords(new Point(x,y), this.grid_Settings);
                                g.FillRectangle( new SolidBrush(grid_Data.Tile_Data_Array[x, y].color), Graphic_Coords.X, Graphic_Coords.Y, grid_Settings.TileSize, grid_Settings.TileSize);
                            }
                            else
                            {
                                //grid_Data.Tile_Data_Array[x, y].tileTexture
                                Image image;
                                switch (grid_Data.Tile_Data_Array[x, y].tileTexture)
                                {
                                    case TileTexture.NoTexture:
                                        image = null;
                                        break;
                                    case TileTexture.Desert_Caves_Square:
                                        image = Resources.Desert_Caves_Square;
                                        break;
                                    case TileTexture.Desert_Mountain1_Square:
                                        image = Resources.Desert_Mountain1_Square;
                                        break;
                                    case TileTexture.Desert_Mountain2_Sqaure:
                                        image = Resources.Desert_Mountain2_Sqaure;
                                        break;
                                    case TileTexture.Desert_Pit_Square:
                                        image = Resources.Desert_Pit_Square;
                                        break;
                                    case TileTexture.Desert_Rock_Square:
                                        image = Resources.Desert_Rock_Square;
                                        break;
                                    case TileTexture.Desert_Sand1_Square:
                                        image = Resources.Desert_Sand1_Square;
                                        break;
                                    case TileTexture.Desert_Sand2_Square:
                                        image = Resources.Desert_Sand2_Square;
                                        break;
                                    case TileTexture.Desert_Stone1_Square:
                                        image = Resources.Desert_Stone1_Square;
                                        break;
                                    case TileTexture.Desert_Stone2_Square:
                                        image = Resources.Desert_Stone2_Square;
                                        break;
                                    case TileTexture.Deset_Rock1_Square:
                                        image = Resources.Deset_Rock1_Square;
                                        break;
                                    case TileTexture.Forest_Heavy_Square_Small:
                                        image = Resources.Forest_Heavy_Square_Small;
                                        break;
                                    case TileTexture.Forest_Light_Square:
                                        image = Resources.Forest_Light_Square;
                                        break;
                                    case TileTexture.Grass_Clearing_Square:
                                        image = Resources.Grass_Clearing_Square;
                                        break;
                                    case TileTexture.Grass_Mountain1_Square:
                                        image = Resources.Grass_Mountain1_Square;
                                        break;
                                    case TileTexture.Grass_Mountain2_Square:
                                        image = Resources.Grass_Mountain2_Square;
                                        break;
                                    case TileTexture.Grass_Rock1_Square:
                                        image = Resources.Grass_Rock1_Square;
                                        break;
                                    case TileTexture.Grass_Rock2_Square:
                                        image = Resources.Grass_Rock2_Square;
                                        break;
                                    case TileTexture.Grass_Square_Small:
                                        image = Resources.Grass_Square_Small;
                                        break;
                                    case TileTexture.Ice_Mountain1_Square:
                                        image = Resources.Ice_Mountain1_Square;
                                        break;
                                    case TileTexture.Ice_Mountain2_Square:
                                        image = Resources.Ice_Mountain2_Square;
                                        break;
                                    case TileTexture.Ice_Mountain3_Square:
                                        image = Resources.Ice_Mountain3_Square;
                                        break;
                                    case TileTexture.Ice1_Square:
                                        image = Resources.Ice1_Square;
                                        break;
                                    case TileTexture.Ice2_Square:
                                        image = Resources.Ice2_Square;
                                        break;
                                    case TileTexture.Mountain1_Square:
                                        image = Resources.Mountain1_Square;
                                        break;
                                    case TileTexture.Mountain2_Square:
                                        image = Resources.Mountain2_Square;
                                        break;
                                    case TileTexture.Mountain3_Square:
                                        image = Resources.Mountain3_Square;
                                        break;
                                    case TileTexture.Forest_Mountain1_Square:
                                        image = Resources.Forest_Mountain1_Square;
                                        break;
                                    case TileTexture.Forest_Mountain2_Square:
                                        image = Resources.Forest_Mountain2_Square;
                                        break;
                                    case TileTexture.Water_Deep_Square:
                                        image = Resources.Water_Deep_Square;
                                        break;
                                    case TileTexture.Water_Square_Small:
                                        image = Resources.Water_Square_Small;
                                        break;
                                    default:
                                        image = null;
                                        break;
                                }
                                if (image != null)
                                {
                                    //Console.WriteLine("Drawing on:" + x + "," + y);
                                    Texture_Tile(g, SetImageOpacity(image, grid_Settings.TileTexture_Opacity), new Point(x, y), grid_Settings);
                                }
                            }
                        }
                    }
                }
            }

            for (int X = grid_Settings.X_Offset; X <= Max_X; X += grid_Settings.TileSize)
            {
                g.DrawLine(pen, new Point(X, grid_Settings.Y_Offset), new Point(X, Max_Y)); //vertical lines
            }
            for (int Y = grid_Settings.Y_Offset; Y <= Max_Y; Y += grid_Settings.TileSize)
            {
                g.DrawLine(pen, new Point(grid_Settings.X_Offset, Y), new Point(Max_X, Y)); //horizontal lines
            }

            //Texture_Tile(SetImageOpacity(Resources.Desert_Mountain1_Square, grid_Settings.TileTexture_Opacity), new Point(0, 0), grid_Settings);
            //Texture_Tile(Resources.Forest_Mountain1_Square, new Point(1, 1), grid_Settings);
        }

        private Pen Get_Pen()
        {
            Pen pen = new Pen(Get_Brush(), (float)PenWidth_NS.Value);
            return pen;
        }

        private Brush Get_Brush()
        {
            SolidBrush Brush = new SolidBrush(Color.FromArgb((int)Pen_Alpha_NS.Value, 0, 0, 0));
            return Brush;
        }

        private void MapPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Draw_Grid(e.Graphics, MapPictureBox, grid_Settings, grid_Data);
        }

        private void TileSize_NS_ValueChanged(object sender, EventArgs e)
        {
            Grid_Update();
        }

        private void X_Offset_NS_ValueChanged(object sender, EventArgs e)
        {
            Grid_Update();
        }

        private void Y_Offset_NS_ValueChanged(object sender, EventArgs e)
        {
            Grid_Update();
        }

        private void X_Reduction_NS_ValueChanged(object sender, EventArgs e)
        {
            Grid_Update();
        }

        private void Y_Reduction_NS_ValueChanged(object sender, EventArgs e)
        {
            Grid_Update();
        }

        private void Pen_Alpha_NS_ValueChanged(object sender, EventArgs e)
        {
            Grid_Update();
        }

        private void PenWidth_NS_ValueChanged(object sender, EventArgs e)
        {
            Grid_Update();
        }

        private void TileAlpha_NS_ValueChanged(object sender, EventArgs e)
        {
            Grid_Update();
        }

        private void Grid_Update()
        {
            UpdateGridSettings(grid_Settings);
            Update_NewGrid_Tiles(MapPictureBox, grid_Settings);
            //MapPictureBox.Refresh(); //this will call for Paint event, so need to call for Call_Draw_Grid
            Call_Draw_Grid(MapPictureBox, grid_Settings, grid_Data);
        }

        private void MapPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("start Mouse move " + DateTime.Now.ToString());
            ////MapPictureBox.Invalidate();
            //MapPictureBox.Refresh();

            ////Circle around mouse
            ////Graphics g = MapPictureBox.CreateGraphics();
            ////g.FillEllipse(Get_Brush(), e.X - (int)SquareSize_NS.Value / 2, e.Y - (int)SquareSize_NS.Value / 2, (int)SquareSize_NS.Value, (int)SquareSize_NS.Value);

            //Point SquareCoords = TranslateToGridCoords(e.X, e.Y, grid_Settings);
            ////List<Image> Images = Get_Active_Tile_Images();

            //if (NextTileTexture != null)
            //{
            //    //hightlight current Tile, with Texture
            //    Texture_Tile(SetImageOpacity(NextTileTexture, grid_Settings.Hightlight_Opacity), SquareCoords, grid_Settings);
            //}
            //else
            //{
            //    //highlight current Tile, with black
            //    Highlight_Square(SquareCoords, grid_Settings);
            //}
            //Console.WriteLine("end Mouse move " + DateTime.Now.ToString());

            if (e.Button == MouseButtons.Left)
            {
                SetTexture(new Point(e.X, e.Y));
                Call_Draw_Grid(MapPictureBox, grid_Settings, grid_Data);
            }
            else
            {
                MapPictureBox.Refresh();
                Point SquareCoords = TranslateToGridCoords(e.X, e.Y, grid_Settings);
                Highlight_Square(MapPictureBox.CreateGraphics(), SquareCoords, grid_Settings);
            }
        }

        public Image SetImageOpacity(Image image, float opacity)
        {
            try
            {
                Bitmap bmp = new Bitmap(image.Width, image.Height);
                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    ColorMatrix matrix = new ColorMatrix();
                    matrix.Matrix33 = opacity;
                    ImageAttributes attributes = new ImageAttributes();
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Height, bmp.Width), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }

                return bmp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private void Highlight_Square(Graphics g, Point point, Grid_Settings grid_Settings)
        {
            //Graphics g = MapPictureBox.CreateGraphics();

            Point GraphicCoods = TranslateToGraphicCoords(point, this.grid_Settings);
            g.FillRectangle(Get_Brush(), GraphicCoods.X, GraphicCoods.Y, grid_Settings.TileSize, grid_Settings.TileSize);
        }

        private void Texture_Tile(Graphics g, Image Tile_Image, Point Grid_Coords, Grid_Settings grid_Settings)
        {
            Point Graphic_Coords = TranslateToGraphicCoords(Grid_Coords, this.grid_Settings);
            //Graphics g = MapPictureBox.CreateGraphics();
            g.DrawImage(Tile_Image, Graphic_Coords.X, Graphic_Coords.Y, grid_Settings.TileSize, grid_Settings.TileSize);
        }

        private Point TranslateToGridCoords(int X, int Y, Grid_Settings grid_Settings)
        {//translates MapPictureBox coords to Grid Coords

            int Translated_X = (int)Math.Floor((double)(X - grid_Settings.X_Offset) / (double)grid_Settings.TileSize);
            int Translated_Y = (int)Math.Floor((double)(Y - grid_Settings.Y_Offset) / (double)grid_Settings.TileSize);

            return new Point(Translated_X, Translated_Y);
        }

        private Point TranslateToGraphicCoords(Point point, Grid_Settings grid_Settings)
        {//translates Gird Coords to Graphic Coords (in the MapPictureBox)

            int Translated_X = grid_Settings.X_Offset + (point.X * grid_Settings.TileSize);
            int Translated_Y = grid_Settings.Y_Offset + (point.Y * grid_Settings.TileSize);

            return new Point(Translated_X, Translated_Y);
        }

        private void MapPictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs MouseEvent = (MouseEventArgs)e;
            SetTexture(new Point(MouseEvent.X, MouseEvent.Y));
            //Call_Draw_Grid(MapPictureBox, grid_Settings, grid_Data);
            //Texture_Tile(SetImageOpacity(image, grid_Settings.TileTexture_Opacity), new Point(x,y), grid_Settings);

            //List<Image> Images = Get_Active_Tile_Images();
            //if (NextTileTexture != null)
            //{
            //    MouseEventArgs MouseEvent = (MouseEventArgs)e;

            //    Point Click_Tile_Coords = TranslateToGridCoords(MouseEvent.X, MouseEvent.Y, grid_Settings);
            //    Point Graphic_Coords = TranslateToGraphicCoords(Click_Tile_Coords, grid_Settings);

            //    Graphics g = MapPictureBox.CreateGraphics();
            //    g.DrawImage(NextTileTexture, Graphic_Coords.X, Graphic_Coords.Y, (int)TileSize_NS.Value, (int)TileSize_NS.Value);

            //    if (grid_Data != null)
            //    {
            //        Enum.TryParse(NextTileTexture.Tag.ToString(), out TileTexture texture);
            //        if (grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y] == null)
            //        {
            //            grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y] = new Tile_Data();
            //        }
            //        grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y].tileTexture = texture;
            //    }

            //    Update_NextTileTexture(Get_Active_Tile_Images()); //set Next Tile Texture
            //}
        }

        private void SetTexture(Point Graphic_Coords_Raw)
        {
            List<Image> Images = Get_Active_Tile_Images();
            if (NextTileTexture != null)
            {
                Point Click_Tile_Coords = TranslateToGridCoords(Graphic_Coords_Raw.X, Graphic_Coords_Raw.Y, grid_Settings);
                //Point Graphic_Coords = TranslateToGraphicCoords(Click_Tile_Coords, grid_Settings);

                //Graphics g = MapPictureBox.CreateGraphics();
                //g.DrawImage(NextTileTexture, Graphic_Coords.X, Graphic_Coords.Y, (int)TileSize_NS.Value, (int)TileSize_NS.Value);
                //g.DrawImage(SetImageOpacity(NextTileTexture, grid_Settings.TileTexture_Opacity), Graphic_Coords.X, Graphic_Coords.Y, (int)TileSize_NS.Value, (int)TileSize_NS.Value);

                if (grid_Data != null)
                {
                    Enum.TryParse(NextTileTexture.Tag.ToString(), out TileTexture texture);
                    if (Click_Tile_Coords.X >= 0 && Click_Tile_Coords.X < grid_Data.Tile_Data_Array.GetLength(0) && Click_Tile_Coords.Y >= 0 && Click_Tile_Coords.Y < grid_Data.Tile_Data_Array.GetLength(1))
                    {

                        if (grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y] == null)
                        {
                            grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y] = new Tile_Data();
                        }
                        if (Use_TextureColor)
                        {
                            grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y].UseColor = true;
                            grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y].color = Color.FromArgb((int)(grid_Settings.TileTexture_Opacity * 255), TextureColor);
                        }
                        else
                        {
                            grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y].UseColor = false;
                            grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y].tileTexture = texture;
                        }
                    }
                }

                Update_NextTileTexture(Get_Active_Tile_Images()); //set Next Tile Texture
            }
            else if (Use_TextureColor)
            {
                Point Click_Tile_Coords = TranslateToGridCoords(Graphic_Coords_Raw.X, Graphic_Coords_Raw.Y, grid_Settings);
                if (grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y] == null)
                {
                    grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y] = new Tile_Data();
                }
                grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y].UseColor = true;
                grid_Data.Tile_Data_Array[Click_Tile_Coords.X, Click_Tile_Coords.Y].color = Color.FromArgb((int)(grid_Settings.TileTexture_Opacity * 255), TextureColor); ;
            }
        }

        private List<Image> Get_Active_Tile_Images()
        {
            List<Image> Images = new List<Image>();
            if (GrassSquare_CheckBox.Checked)
            {
                Images.Add(Resources.Grass_Square);
                Images.Last().Tag = nameof(Properties.Resources.Grass_Square_Small);
            }
            if (ForestHeavy_CheckBox.Checked)
            {
                Images.Add(Resources.Forest_Heavy_Square);
                Images.Last().Tag = nameof(Properties.Resources.Forest_Heavy_Square_Small);
            }
            if (Water_Checkbox.Checked)
            {
                Images.Add(Resources.Water_Square);
                Images.Last().Tag = nameof(Properties.Resources.Water_Square_Small);
            }


            return Images;
        }

        private void Update_NextTileTexture(List<Image> Textures)
        {
            if (Textures != null && Textures.Count > 0)
            {
                NextTileTexture = Textures[rdm.Next(0, Textures.Count)];
            }
            else
            {
                NextTileTexture = null;
            }
        }

        private void Color_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Use_TextureColor = Color_checkBox.Checked;
        }

        private void GrassSquare_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Update_NextTileTexture(Get_Active_Tile_Images());
        }

        private void ForestHeavy_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Update_NextTileTexture(Get_Active_Tile_Images());
        }

        private void Water_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Update_NextTileTexture(Get_Active_Tile_Images());
        }

        private void CreateGrid_Button_Click(object sender, EventArgs e)
        {
            Create_Grid();
        }

        private void Create_Grid()
        {
            grid_Data = new Grid_Data((int)X_Tiles_NS.Value, (int)Y_Tiles_NS.Value);
            //MapPictureBox.Refresh(); //this will call for Paint event, so need to call for Call_Draw_Grid
            Call_Draw_Grid(MapPictureBox, grid_Settings, grid_Data);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Update_NewGrid_Tiles(MapPictureBox, grid_Settings);
        }

        private void Color_PictureBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.AnyColor = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color_PictureBox.BackColor = colorDialog.Color;
                TextureColor = colorDialog.Color;
            }
        }

    }
}
