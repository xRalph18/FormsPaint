namespace PaintForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            SetColorBlack = new ToolStripButton();
            SetColorWhite = new ToolStripButton();
            SetColorRed = new ToolStripButton();
            SetColorLime = new ToolStripButton();
            SetColorCyan = new ToolStripButton();
            SetColorFushia = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            SetSize = new ToolStripDropDownButton();
            SetSize1 = new ToolStripMenuItem();
            SetSize2 = new ToolStripMenuItem();
            SetSize4 = new ToolStripMenuItem();
            SetSize8 = new ToolStripMenuItem();
            SetSize16 = new ToolStripMenuItem();
            SetSize32 = new ToolStripMenuItem();
            SetTool = new ToolStripDropDownButton();
            SetPencil = new ToolStripMenuItem();
            SetLine = new ToolStripMenuItem();
            SetRectangle = new ToolStripMenuItem();
            SetEllipse = new ToolStripMenuItem();
            ClearCanvas = new ToolStripButton();
            PaintBox = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaintBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SetColorBlack, SetColorWhite, SetColorRed, SetColorLime, SetColorCyan, SetColorFushia, toolStripSeparator1, SetSize, SetTool, ClearCanvas });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // SetColorBlack
            // 
            SetColorBlack.BackColor = Color.Black;
            SetColorBlack.DisplayStyle = ToolStripItemDisplayStyle.None;
            SetColorBlack.Image = (Image)resources.GetObject("SetColorBlack.Image");
            SetColorBlack.ImageTransparentColor = Color.Magenta;
            SetColorBlack.Name = "SetColorBlack";
            SetColorBlack.Size = new Size(29, 24);
            SetColorBlack.Text = "toolStripButton1";
            SetColorBlack.Click += SetColorBlack_Click;
            // 
            // SetColorWhite
            // 
            SetColorWhite.BackColor = Color.White;
            SetColorWhite.DisplayStyle = ToolStripItemDisplayStyle.None;
            SetColorWhite.Image = (Image)resources.GetObject("SetColorWhite.Image");
            SetColorWhite.ImageTransparentColor = Color.Magenta;
            SetColorWhite.Name = "SetColorWhite";
            SetColorWhite.Size = new Size(29, 24);
            SetColorWhite.Text = "toolStripButton1";
            SetColorWhite.Click += SetColorWhite_Click;
            // 
            // SetColorRed
            // 
            SetColorRed.BackColor = Color.Red;
            SetColorRed.DisplayStyle = ToolStripItemDisplayStyle.None;
            SetColorRed.Image = (Image)resources.GetObject("SetColorRed.Image");
            SetColorRed.ImageTransparentColor = Color.Magenta;
            SetColorRed.Name = "SetColorRed";
            SetColorRed.Size = new Size(29, 24);
            SetColorRed.Text = "toolStripButton2";
            SetColorRed.Click += SetColorRed_Click;
            // 
            // SetColorLime
            // 
            SetColorLime.BackColor = Color.Lime;
            SetColorLime.DisplayStyle = ToolStripItemDisplayStyle.None;
            SetColorLime.Image = (Image)resources.GetObject("SetColorLime.Image");
            SetColorLime.ImageTransparentColor = Color.Magenta;
            SetColorLime.Name = "SetColorLime";
            SetColorLime.Size = new Size(29, 24);
            SetColorLime.Text = "toolStripButton3";
            SetColorLime.Click += SetColorLime_Click;
            // 
            // SetColorCyan
            // 
            SetColorCyan.BackColor = Color.Cyan;
            SetColorCyan.DisplayStyle = ToolStripItemDisplayStyle.None;
            SetColorCyan.Image = (Image)resources.GetObject("SetColorCyan.Image");
            SetColorCyan.ImageTransparentColor = Color.Magenta;
            SetColorCyan.Name = "SetColorCyan";
            SetColorCyan.Size = new Size(29, 24);
            SetColorCyan.Text = "toolStripButton4";
            SetColorCyan.Click += SetColorCyan_Click;
            // 
            // SetColorFushia
            // 
            SetColorFushia.BackColor = Color.Fuchsia;
            SetColorFushia.DisplayStyle = ToolStripItemDisplayStyle.None;
            SetColorFushia.Image = (Image)resources.GetObject("SetColorFushia.Image");
            SetColorFushia.ImageTransparentColor = Color.Magenta;
            SetColorFushia.Name = "SetColorFushia";
            SetColorFushia.Size = new Size(29, 24);
            SetColorFushia.Text = "toolStripButton5";
            SetColorFushia.Click += SetColorFushia_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // SetSize
            // 
            SetSize.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SetSize.DropDownItems.AddRange(new ToolStripItem[] { SetSize1, SetSize2, SetSize4, SetSize8, SetSize16, SetSize32 });
            SetSize.Image = (Image)resources.GetObject("SetSize.Image");
            SetSize.ImageTransparentColor = Color.Magenta;
            SetSize.Name = "SetSize";
            SetSize.Size = new Size(75, 24);
            SetSize.Text = "Set Size";
            // 
            // SetSize1
            // 
            SetSize1.Name = "SetSize1";
            SetSize1.Size = new Size(108, 26);
            SetSize1.Text = "1";
            SetSize1.Click += SetSize1_Click;
            // 
            // SetSize2
            // 
            SetSize2.Name = "SetSize2";
            SetSize2.Size = new Size(108, 26);
            SetSize2.Text = "2";
            SetSize2.Click += SetSize2_Click;
            // 
            // SetSize4
            // 
            SetSize4.Name = "SetSize4";
            SetSize4.Size = new Size(108, 26);
            SetSize4.Text = "4";
            SetSize4.Click += SetSize4_Click;
            // 
            // SetSize8
            // 
            SetSize8.Name = "SetSize8";
            SetSize8.Size = new Size(108, 26);
            SetSize8.Text = "8";
            SetSize8.Click += SetSize8_Click;
            // 
            // SetSize16
            // 
            SetSize16.Name = "SetSize16";
            SetSize16.Size = new Size(108, 26);
            SetSize16.Text = "16";
            SetSize16.Click += SetSize16_Click;
            // 
            // SetSize32
            // 
            SetSize32.Name = "SetSize32";
            SetSize32.Size = new Size(108, 26);
            SetSize32.Text = "32";
            SetSize32.Click += SetSize32_Click;
            // 
            // SetTool
            // 
            SetTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SetTool.DropDownItems.AddRange(new ToolStripItem[] { SetPencil, SetLine, SetRectangle, SetEllipse });
            SetTool.Image = (Image)resources.GetObject("SetTool.Image");
            SetTool.ImageTransparentColor = Color.Magenta;
            SetTool.Name = "SetTool";
            SetTool.Size = new Size(77, 24);
            SetTool.Text = "Set Tool";
            // 
            // SetPencil
            // 
            SetPencil.Name = "SetPencil";
            SetPencil.Size = new Size(158, 26);
            SetPencil.Text = "Pencil";
            SetPencil.Click += SetPencil_Click;
            // 
            // SetLine
            // 
            SetLine.Name = "SetLine";
            SetLine.Size = new Size(158, 26);
            SetLine.Text = "Line";
            SetLine.Click += SetLine_Click;
            // 
            // SetRectangle
            // 
            SetRectangle.Name = "SetRectangle";
            SetRectangle.Size = new Size(158, 26);
            SetRectangle.Text = "Rectangle";
            SetRectangle.Click += SetRectangle_Click;
            // 
            // SetEllipse
            // 
            SetEllipse.Name = "SetEllipse";
            SetEllipse.Size = new Size(158, 26);
            SetEllipse.Text = "Ellipse";
            SetEllipse.Click += SetEllipse_Click;
            // 
            // ClearCanvas
            // 
            ClearCanvas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ClearCanvas.Image = (Image)resources.GetObject("ClearCanvas.Image");
            ClearCanvas.ImageTransparentColor = Color.Magenta;
            ClearCanvas.Name = "ClearCanvas";
            ClearCanvas.Size = new Size(47, 24);
            ClearCanvas.Text = "Clear";
            ClearCanvas.Click += ClearCanvas_Click;
            // 
            // PaintBox
            // 
            PaintBox.Dock = DockStyle.Fill;
            PaintBox.Location = new Point(0, 55);
            PaintBox.Name = "PaintBox";
            PaintBox.Size = new Size(800, 395);
            PaintBox.TabIndex = 1;
            PaintBox.TabStop = false;
            PaintBox.MouseDown += PaintBox_MouseDown;
            PaintBox.MouseMove += PaintBox_MouseMove;
            PaintBox.MouseUp += PaintBox_MouseUp;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PaintBox);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaintBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton SetColorBlack;
        private ToolStripButton SetColorWhite;
        private ToolStripButton SetColorRed;
        private ToolStripButton SetColorLime;
        private ToolStripButton SetColorCyan;
        private ToolStripButton SetColorFushia;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton SetSize;
        private ToolStripMenuItem SetSize1;
        private ToolStripMenuItem SetSize2;
        private ToolStripMenuItem SetSize4;
        private ToolStripMenuItem SetSize8;
        private ToolStripMenuItem SetSize16;
        private ToolStripMenuItem SetSize32;
        private PictureBox PaintBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripDropDownButton SetTool;
        private ToolStripMenuItem SetLine;
        private ToolStripMenuItem SetRectangle;
        private ToolStripMenuItem SetEllipse;
        private ToolStripMenuItem SetPencil;
        private ToolStripButton ClearCanvas;
    }
}