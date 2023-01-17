namespace DnD_MapGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawTest_Button = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.TileSelect_GroupBox = new System.Windows.Forms.GroupBox();
            this.Color_checkBox = new System.Windows.Forms.CheckBox();
            this.Water_Checkbox = new System.Windows.Forms.CheckBox();
            this.ForestHeavy_CheckBox = new System.Windows.Forms.CheckBox();
            this.GrassSquare_CheckBox = new System.Windows.Forms.CheckBox();
            this.Grid_GroupBox = new System.Windows.Forms.GroupBox();
            this.TileAlpha_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.Pen_Alpha_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.PenWidth_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.Y_Reduction_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.X_Reduction_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.Y_Offset_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.X_Offset_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.TileSize_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.CreateGrid_GroupBox = new System.Windows.Forms.GroupBox();
            this.CreateGrid_Button = new System.Windows.Forms.Button();
            this.Y_Tiles_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.X_Tiles_NS = new DnD_MapGenerator.Controllers.NumericSelection();
            this.MapPictureBox = new System.Windows.Forms.PictureBox();
            this.Color_PictureBox = new System.Windows.Forms.PictureBox();
            this.Water_PictureBox = new System.Windows.Forms.PictureBox();
            this.ForestHeavy_PictureBox = new System.Windows.Forms.PictureBox();
            this.GrassSquare_PictureBox = new System.Windows.Forms.PictureBox();
            this.ControlPanel.SuspendLayout();
            this.TileSelect_GroupBox.SuspendLayout();
            this.Grid_GroupBox.SuspendLayout();
            this.CreateGrid_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Color_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForestHeavy_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrassSquare_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawTest_Button
            // 
            this.DrawTest_Button.Location = new System.Drawing.Point(115, 20);
            this.DrawTest_Button.Name = "DrawTest_Button";
            this.DrawTest_Button.Size = new System.Drawing.Size(75, 23);
            this.DrawTest_Button.TabIndex = 1;
            this.DrawTest_Button.Text = "Draw Grid";
            this.DrawTest_Button.UseVisualStyleBackColor = true;
            this.DrawTest_Button.Click += new System.EventHandler(this.DrawTest_Button_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.TileSelect_GroupBox);
            this.ControlPanel.Controls.Add(this.Grid_GroupBox);
            this.ControlPanel.Controls.Add(this.CreateGrid_GroupBox);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(1604, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(300, 1041);
            this.ControlPanel.TabIndex = 2;
            // 
            // TileSelect_GroupBox
            // 
            this.TileSelect_GroupBox.Controls.Add(this.Color_PictureBox);
            this.TileSelect_GroupBox.Controls.Add(this.Color_checkBox);
            this.TileSelect_GroupBox.Controls.Add(this.Water_Checkbox);
            this.TileSelect_GroupBox.Controls.Add(this.ForestHeavy_CheckBox);
            this.TileSelect_GroupBox.Controls.Add(this.GrassSquare_CheckBox);
            this.TileSelect_GroupBox.Controls.Add(this.Water_PictureBox);
            this.TileSelect_GroupBox.Controls.Add(this.ForestHeavy_PictureBox);
            this.TileSelect_GroupBox.Controls.Add(this.GrassSquare_PictureBox);
            this.TileSelect_GroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TileSelect_GroupBox.Location = new System.Drawing.Point(0, 498);
            this.TileSelect_GroupBox.Name = "TileSelect_GroupBox";
            this.TileSelect_GroupBox.Size = new System.Drawing.Size(300, 458);
            this.TileSelect_GroupBox.TabIndex = 3;
            this.TileSelect_GroupBox.TabStop = false;
            this.TileSelect_GroupBox.Text = "Tile Select";
            // 
            // Color_checkBox
            // 
            this.Color_checkBox.AutoSize = true;
            this.Color_checkBox.Location = new System.Drawing.Point(27, 60);
            this.Color_checkBox.Name = "Color_checkBox";
            this.Color_checkBox.Size = new System.Drawing.Size(50, 17);
            this.Color_checkBox.TabIndex = 4;
            this.Color_checkBox.Text = "Color";
            this.Color_checkBox.UseVisualStyleBackColor = true;
            this.Color_checkBox.CheckedChanged += new System.EventHandler(this.Color_checkBox_CheckedChanged);
            // 
            // Water_Checkbox
            // 
            this.Water_Checkbox.AutoSize = true;
            this.Water_Checkbox.Location = new System.Drawing.Point(27, 384);
            this.Water_Checkbox.Name = "Water_Checkbox";
            this.Water_Checkbox.Size = new System.Drawing.Size(55, 17);
            this.Water_Checkbox.TabIndex = 1;
            this.Water_Checkbox.Text = "Water";
            this.Water_Checkbox.UseVisualStyleBackColor = true;
            this.Water_Checkbox.CheckedChanged += new System.EventHandler(this.Water_Checkbox_CheckedChanged);
            // 
            // ForestHeavy_CheckBox
            // 
            this.ForestHeavy_CheckBox.AutoSize = true;
            this.ForestHeavy_CheckBox.Location = new System.Drawing.Point(27, 275);
            this.ForestHeavy_CheckBox.Name = "ForestHeavy_CheckBox";
            this.ForestHeavy_CheckBox.Size = new System.Drawing.Size(89, 17);
            this.ForestHeavy_CheckBox.TabIndex = 1;
            this.ForestHeavy_CheckBox.Text = "Forest Heavy";
            this.ForestHeavy_CheckBox.UseVisualStyleBackColor = true;
            this.ForestHeavy_CheckBox.CheckedChanged += new System.EventHandler(this.ForestHeavy_CheckBox_CheckedChanged);
            // 
            // GrassSquare_CheckBox
            // 
            this.GrassSquare_CheckBox.AutoSize = true;
            this.GrassSquare_CheckBox.Location = new System.Drawing.Point(27, 166);
            this.GrassSquare_CheckBox.Name = "GrassSquare_CheckBox";
            this.GrassSquare_CheckBox.Size = new System.Drawing.Size(53, 17);
            this.GrassSquare_CheckBox.TabIndex = 1;
            this.GrassSquare_CheckBox.Text = "Grass";
            this.GrassSquare_CheckBox.UseVisualStyleBackColor = true;
            this.GrassSquare_CheckBox.CheckedChanged += new System.EventHandler(this.GrassSquare_CheckBox_CheckedChanged);
            // 
            // Grid_GroupBox
            // 
            this.Grid_GroupBox.Controls.Add(this.TileAlpha_NS);
            this.Grid_GroupBox.Controls.Add(this.Pen_Alpha_NS);
            this.Grid_GroupBox.Controls.Add(this.PenWidth_NS);
            this.Grid_GroupBox.Controls.Add(this.Y_Reduction_NS);
            this.Grid_GroupBox.Controls.Add(this.X_Reduction_NS);
            this.Grid_GroupBox.Controls.Add(this.Y_Offset_NS);
            this.Grid_GroupBox.Controls.Add(this.X_Offset_NS);
            this.Grid_GroupBox.Controls.Add(this.TileSize_NS);
            this.Grid_GroupBox.Controls.Add(this.DrawTest_Button);
            this.Grid_GroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grid_GroupBox.Location = new System.Drawing.Point(0, 218);
            this.Grid_GroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.Grid_GroupBox.Name = "Grid_GroupBox";
            this.Grid_GroupBox.Size = new System.Drawing.Size(300, 280);
            this.Grid_GroupBox.TabIndex = 2;
            this.Grid_GroupBox.TabStop = false;
            this.Grid_GroupBox.Text = "Grid Controls";
            // 
            // TileAlpha_NS
            // 
            this.TileAlpha_NS.Description = "Tile Alpha";
            this.TileAlpha_NS.Location = new System.Drawing.Point(15, 234);
            this.TileAlpha_NS.Margin = new System.Windows.Forms.Padding(1);
            this.TileAlpha_NS.Max = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TileAlpha_NS.Min = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TileAlpha_NS.Name = "TileAlpha_NS";
            this.TileAlpha_NS.Size = new System.Drawing.Size(275, 25);
            this.TileAlpha_NS.TabIndex = 8;
            this.TileAlpha_NS.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.TileAlpha_NS.ValueChanged += new System.EventHandler(this.TileAlpha_NS_ValueChanged);
            // 
            // Pen_Alpha_NS
            // 
            this.Pen_Alpha_NS.Description = "Pen Alpha";
            this.Pen_Alpha_NS.Location = new System.Drawing.Point(15, 180);
            this.Pen_Alpha_NS.Margin = new System.Windows.Forms.Padding(1);
            this.Pen_Alpha_NS.Max = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Pen_Alpha_NS.Min = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pen_Alpha_NS.Name = "Pen_Alpha_NS";
            this.Pen_Alpha_NS.Size = new System.Drawing.Size(275, 25);
            this.Pen_Alpha_NS.TabIndex = 7;
            this.Pen_Alpha_NS.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Pen_Alpha_NS.ValueChanged += new System.EventHandler(this.Pen_Alpha_NS_ValueChanged);
            // 
            // PenWidth_NS
            // 
            this.PenWidth_NS.Description = "Pen Width";
            this.PenWidth_NS.Location = new System.Drawing.Point(15, 207);
            this.PenWidth_NS.Margin = new System.Windows.Forms.Padding(1);
            this.PenWidth_NS.Max = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.PenWidth_NS.Min = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PenWidth_NS.Name = "PenWidth_NS";
            this.PenWidth_NS.Size = new System.Drawing.Size(275, 25);
            this.PenWidth_NS.TabIndex = 6;
            this.PenWidth_NS.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.PenWidth_NS.ValueChanged += new System.EventHandler(this.PenWidth_NS_ValueChanged);
            // 
            // Y_Reduction_NS
            // 
            this.Y_Reduction_NS.Description = "Y Reduction";
            this.Y_Reduction_NS.Location = new System.Drawing.Point(15, 153);
            this.Y_Reduction_NS.Margin = new System.Windows.Forms.Padding(1);
            this.Y_Reduction_NS.Max = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Y_Reduction_NS.Min = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Y_Reduction_NS.Name = "Y_Reduction_NS";
            this.Y_Reduction_NS.Size = new System.Drawing.Size(275, 25);
            this.Y_Reduction_NS.TabIndex = 5;
            this.Y_Reduction_NS.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.Y_Reduction_NS.ValueChanged += new System.EventHandler(this.Y_Reduction_NS_ValueChanged);
            // 
            // X_Reduction_NS
            // 
            this.X_Reduction_NS.Description = "X Reduction";
            this.X_Reduction_NS.Location = new System.Drawing.Point(15, 126);
            this.X_Reduction_NS.Margin = new System.Windows.Forms.Padding(1);
            this.X_Reduction_NS.Max = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.X_Reduction_NS.Min = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.X_Reduction_NS.Name = "X_Reduction_NS";
            this.X_Reduction_NS.Size = new System.Drawing.Size(275, 25);
            this.X_Reduction_NS.TabIndex = 5;
            this.X_Reduction_NS.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.X_Reduction_NS.ValueChanged += new System.EventHandler(this.X_Reduction_NS_ValueChanged);
            // 
            // Y_Offset_NS
            // 
            this.Y_Offset_NS.Description = "Y Offset";
            this.Y_Offset_NS.Location = new System.Drawing.Point(15, 99);
            this.Y_Offset_NS.Margin = new System.Windows.Forms.Padding(1);
            this.Y_Offset_NS.Max = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Y_Offset_NS.Min = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Y_Offset_NS.Name = "Y_Offset_NS";
            this.Y_Offset_NS.Size = new System.Drawing.Size(275, 25);
            this.Y_Offset_NS.TabIndex = 5;
            this.Y_Offset_NS.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.Y_Offset_NS.ValueChanged += new System.EventHandler(this.Y_Offset_NS_ValueChanged);
            // 
            // X_Offset_NS
            // 
            this.X_Offset_NS.Description = "X Offset";
            this.X_Offset_NS.Location = new System.Drawing.Point(15, 72);
            this.X_Offset_NS.Margin = new System.Windows.Forms.Padding(1);
            this.X_Offset_NS.Max = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.X_Offset_NS.Min = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.X_Offset_NS.Name = "X_Offset_NS";
            this.X_Offset_NS.Size = new System.Drawing.Size(275, 25);
            this.X_Offset_NS.TabIndex = 5;
            this.X_Offset_NS.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.X_Offset_NS.ValueChanged += new System.EventHandler(this.X_Offset_NS_ValueChanged);
            // 
            // TileSize_NS
            // 
            this.TileSize_NS.Description = "Tile Size";
            this.TileSize_NS.Location = new System.Drawing.Point(15, 45);
            this.TileSize_NS.Margin = new System.Windows.Forms.Padding(1);
            this.TileSize_NS.Max = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TileSize_NS.Min = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TileSize_NS.Name = "TileSize_NS";
            this.TileSize_NS.Size = new System.Drawing.Size(275, 25);
            this.TileSize_NS.TabIndex = 4;
            this.TileSize_NS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TileSize_NS.ValueChanged += new System.EventHandler(this.TileSize_NS_ValueChanged);
            // 
            // CreateGrid_GroupBox
            // 
            this.CreateGrid_GroupBox.Controls.Add(this.CreateGrid_Button);
            this.CreateGrid_GroupBox.Controls.Add(this.Y_Tiles_NS);
            this.CreateGrid_GroupBox.Controls.Add(this.X_Tiles_NS);
            this.CreateGrid_GroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateGrid_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.CreateGrid_GroupBox.Name = "CreateGrid_GroupBox";
            this.CreateGrid_GroupBox.Size = new System.Drawing.Size(300, 218);
            this.CreateGrid_GroupBox.TabIndex = 4;
            this.CreateGrid_GroupBox.TabStop = false;
            this.CreateGrid_GroupBox.Text = "Create Grid";
            // 
            // CreateGrid_Button
            // 
            this.CreateGrid_Button.Location = new System.Drawing.Point(99, 14);
            this.CreateGrid_Button.Name = "CreateGrid_Button";
            this.CreateGrid_Button.Size = new System.Drawing.Size(106, 23);
            this.CreateGrid_Button.TabIndex = 1;
            this.CreateGrid_Button.Text = "Create New Grid";
            this.CreateGrid_Button.UseVisualStyleBackColor = true;
            this.CreateGrid_Button.Click += new System.EventHandler(this.CreateGrid_Button_Click);
            // 
            // Y_Tiles_NS
            // 
            this.Y_Tiles_NS.Description = "Vertical Tiles";
            this.Y_Tiles_NS.Location = new System.Drawing.Point(15, 68);
            this.Y_Tiles_NS.Margin = new System.Windows.Forms.Padding(1);
            this.Y_Tiles_NS.Max = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.Y_Tiles_NS.Min = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Y_Tiles_NS.Name = "Y_Tiles_NS";
            this.Y_Tiles_NS.Size = new System.Drawing.Size(275, 25);
            this.Y_Tiles_NS.TabIndex = 0;
            this.Y_Tiles_NS.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // X_Tiles_NS
            // 
            this.X_Tiles_NS.Description = "Horizontal Tiles";
            this.X_Tiles_NS.Location = new System.Drawing.Point(15, 40);
            this.X_Tiles_NS.Margin = new System.Windows.Forms.Padding(1);
            this.X_Tiles_NS.Max = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.X_Tiles_NS.Min = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.X_Tiles_NS.Name = "X_Tiles_NS";
            this.X_Tiles_NS.Size = new System.Drawing.Size(275, 25);
            this.X_Tiles_NS.TabIndex = 0;
            this.X_Tiles_NS.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // MapPictureBox
            // 
            this.MapPictureBox.BackgroundImage = global::DnD_MapGenerator.Properties.Resources._2880x1800_paper;
            this.MapPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MapPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MapPictureBox.Name = "MapPictureBox";
            this.MapPictureBox.Size = new System.Drawing.Size(1604, 1041);
            this.MapPictureBox.TabIndex = 3;
            this.MapPictureBox.TabStop = false;
            this.MapPictureBox.Click += new System.EventHandler(this.MapPictureBox_Click);
            this.MapPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MapPictureBox_Paint);
            this.MapPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapPictureBox_MouseMove);
            // 
            // Color_PictureBox
            // 
            this.Color_PictureBox.BackColor = System.Drawing.Color.White;
            this.Color_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_PictureBox.Location = new System.Drawing.Point(126, 25);
            this.Color_PictureBox.Name = "Color_PictureBox";
            this.Color_PictureBox.Size = new System.Drawing.Size(100, 101);
            this.Color_PictureBox.TabIndex = 5;
            this.Color_PictureBox.TabStop = false;
            this.Color_PictureBox.Click += new System.EventHandler(this.Color_PictureBox_Click);
            // 
            // Water_PictureBox
            // 
            this.Water_PictureBox.BackgroundImage = global::DnD_MapGenerator.Properties.Resources.Water_Square_Small;
            this.Water_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Water_PictureBox.Location = new System.Drawing.Point(126, 343);
            this.Water_PictureBox.Name = "Water_PictureBox";
            this.Water_PictureBox.Size = new System.Drawing.Size(100, 101);
            this.Water_PictureBox.TabIndex = 0;
            this.Water_PictureBox.TabStop = false;
            // 
            // ForestHeavy_PictureBox
            // 
            this.ForestHeavy_PictureBox.BackgroundImage = global::DnD_MapGenerator.Properties.Resources.Forest_Heavy_Square_Small;
            this.ForestHeavy_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForestHeavy_PictureBox.Location = new System.Drawing.Point(126, 237);
            this.ForestHeavy_PictureBox.Name = "ForestHeavy_PictureBox";
            this.ForestHeavy_PictureBox.Size = new System.Drawing.Size(100, 101);
            this.ForestHeavy_PictureBox.TabIndex = 0;
            this.ForestHeavy_PictureBox.TabStop = false;
            // 
            // GrassSquare_PictureBox
            // 
            this.GrassSquare_PictureBox.BackgroundImage = global::DnD_MapGenerator.Properties.Resources.Grass_Square_Small;
            this.GrassSquare_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrassSquare_PictureBox.Location = new System.Drawing.Point(126, 131);
            this.GrassSquare_PictureBox.Name = "GrassSquare_PictureBox";
            this.GrassSquare_PictureBox.Size = new System.Drawing.Size(100, 101);
            this.GrassSquare_PictureBox.TabIndex = 0;
            this.GrassSquare_PictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.MapPictureBox);
            this.Controls.Add(this.ControlPanel);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D&D Map Creator";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ControlPanel.ResumeLayout(false);
            this.TileSelect_GroupBox.ResumeLayout(false);
            this.TileSelect_GroupBox.PerformLayout();
            this.Grid_GroupBox.ResumeLayout(false);
            this.CreateGrid_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Color_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Water_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForestHeavy_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrassSquare_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DrawTest_Button;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.GroupBox Grid_GroupBox;
        private Controllers.NumericSelection TileSize_NS;
        private Controllers.NumericSelection Y_Reduction_NS;
        private Controllers.NumericSelection X_Reduction_NS;
        private Controllers.NumericSelection Y_Offset_NS;
        private Controllers.NumericSelection X_Offset_NS;
        private Controllers.NumericSelection Pen_Alpha_NS;
        private Controllers.NumericSelection PenWidth_NS;
        private System.Windows.Forms.PictureBox MapPictureBox;
        private System.Windows.Forms.GroupBox TileSelect_GroupBox;
        private System.Windows.Forms.CheckBox Water_Checkbox;
        private System.Windows.Forms.CheckBox ForestHeavy_CheckBox;
        private System.Windows.Forms.CheckBox GrassSquare_CheckBox;
        private System.Windows.Forms.PictureBox Water_PictureBox;
        private System.Windows.Forms.PictureBox ForestHeavy_PictureBox;
        private System.Windows.Forms.PictureBox GrassSquare_PictureBox;
        private System.Windows.Forms.GroupBox CreateGrid_GroupBox;
        private Controllers.NumericSelection Y_Tiles_NS;
        private Controllers.NumericSelection X_Tiles_NS;
        private System.Windows.Forms.Button CreateGrid_Button;
        private Controllers.NumericSelection TileAlpha_NS;
        private System.Windows.Forms.PictureBox Color_PictureBox;
        private System.Windows.Forms.CheckBox Color_checkBox;
    }
}

