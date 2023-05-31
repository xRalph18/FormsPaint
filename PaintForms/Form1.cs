using System.Numerics;

namespace PaintForms
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(1920, 1080);
        Color penColor = Color.Black;
        Pen pen = new Pen(Color.Black, 1);
        bool isDrawing = false;
        int toolSize = 1;
        Vector2 startPos;

        enum Tools
        {
            Pencil,
            Line,
            Rectangle,
            Ellipse
        }

        Tools tool = Tools.Pencil;

        public Form1()
        {
            InitializeComponent();

            SaveCanvas.Filter = "PNG (*.png)|*.png|JPG (*.jpg; *.jpeg)|*.jpg;*.jpeg|GIF (*.gif)|*.gif|BMP (*.bmp)|*.bmp|TIFF (*.tif; *.tiff)|*.tif;*.tiff|" + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.webp";

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.White);
                }
            }
            PaintBox.Image = bitmap;
        }

        private void PaintBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;

            if (tool == Tools.Line || tool == Tools.Rectangle || tool == Tools.Ellipse)
            {
                startPos = new Vector2(e.X, e.Y);
            }
        }

        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true && tool == Tools.Pencil)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawRectangle(pen, e.X, e.Y, toolSize, toolSize);
                PaintBox.Image = bitmap;
            }
        }

        private void PaintBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing == true && tool == Tools.Line)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawLine(pen, startPos.X, startPos.Y, e.X, e.Y);
                PaintBox.Image = bitmap;
            }
            else if (isDrawing == true && tool == Tools.Rectangle)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                var width = e.X - startPos.X;
                var height = e.Y - startPos.Y;

                if (width < 0 && height < 0)
                {
                    graphics.DrawRectangle(pen, startPos.X + width, startPos.Y + height, startPos.X - (startPos.X + width), startPos.Y - (startPos.Y + height));
                    PaintBox.Image = bitmap;
                }
                else if (width < 0)
                {
                    graphics.DrawRectangle(pen, startPos.X + width, startPos.Y, startPos.X - (startPos.X + width), height);
                    PaintBox.Image = bitmap;
                }
                else if (height < 0)
                {
                    graphics.DrawRectangle(pen, startPos.X, startPos.Y + height, width, startPos.Y - (startPos.Y + height));
                    PaintBox.Image = bitmap;
                }
                else
                {
                    graphics.DrawRectangle(pen, startPos.X, startPos.Y, width, height);
                    PaintBox.Image = bitmap;
                }
            }
            else if (isDrawing == true && tool == Tools.Ellipse)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawEllipse(pen, startPos.X, startPos.Y, e.X - startPos.X, e.Y - startPos.Y);
                PaintBox.Image = bitmap;
            }

            isDrawing = false;
        }

        private void SetColorBlack_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
            penColor = Color.Black;
        }

        private void SetColorWhite_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            penColor = Color.White;
        }

        private void SetColorRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
            penColor = Color.Red;
        }

        private void SetColorLime_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Lime;
            penColor = Color.Lime;
        }

        private void SetColorCyan_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Cyan;
            penColor = Color.Cyan;
        }

        private void SetColorFushia_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Fuchsia;
            penColor = Color.Fuchsia;
        }

        private void SetSize1_Click(object sender, EventArgs e)
        {
            toolSize = 1;
            pen = new Pen(penColor, toolSize);
        }

        private void SetSize2_Click(object sender, EventArgs e)
        {
            toolSize = 2;
            pen = new Pen(penColor, toolSize);
        }

        private void SetSize4_Click(object sender, EventArgs e)
        {
            toolSize = 4;
            pen = new Pen(penColor, toolSize);
        }

        private void SetSize8_Click(object sender, EventArgs e)
        {
            toolSize = 8;
            pen = new Pen(penColor, toolSize);
        }

        private void SetSize16_Click(object sender, EventArgs e)
        {
            toolSize = 16;
            pen = new Pen(penColor, toolSize);
        }

        private void SetSize32_Click(object sender, EventArgs e)
        {
            toolSize = 32;
            pen = new Pen(penColor, toolSize);
        }

        private void ClearCanvas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.Transparent);
                }
            }
            PaintBox.Image = bitmap;
        }

        private void SetPencil_Click(object sender, EventArgs e)
        {
            tool = Tools.Pencil;
        }

        private void SetLine_Click(object sender, EventArgs e)
        {
            tool = Tools.Line;
        }

        private void SetRectangle_Click(object sender, EventArgs e)
        {
            tool = Tools.Rectangle;
        }

        private void SetEllipse_Click(object sender, EventArgs e)
        {
            tool = Tools.Ellipse;
        }

        private void OpenColorPicker_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            pen.Color = ColorPicker.Color;
            OpenColorPicker.BackColor = ColorPicker.Color;
            penColor = ColorPicker.Color;
        }

        private void NewCanvas_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(1920, 1080);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.White);
                }
            }
            PaintBox.Image = bitmap;
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenCanvas.Filter = "PNG (*.png)|*.png|JPG (*.jpg; *.jpeg)|*.jpg;*.jpeg|GIF (*.gif)|*.gif|BMP (*.bmp)|*.bmp|TIFF (*.tif; *.tiff)|*.tif;*.tiff|" + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.webp";
            var dialogStatus = OpenCanvas.ShowDialog();

            if (dialogStatus == DialogResult.OK)
            {
                bitmap = new Bitmap(OpenCanvas.FileName);
                PaintBox.Image = bitmap;
            }
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            var dialogStatus = SaveCanvas.ShowDialog();

            if (dialogStatus == DialogResult.OK)
            {
                bitmap.Save(SaveCanvas.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you want to save it", "Save before closing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                var dialogStatus = SaveCanvas.ShowDialog();

                if (dialogStatus == DialogResult.OK)
                {
                    bitmap.Save(SaveCanvas.FileName);
                }

                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}