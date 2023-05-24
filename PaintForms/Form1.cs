using System.Numerics;

namespace PaintForms
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(1920, 1080);
        Pen pen = new Pen(Color.Black, 1);
        Brush brush = new SolidBrush(Color.Black);
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

                //finish

                if (width < 0)
                {
                    graphics.DrawRectangle(pen, startPos.X + width, startPos.Y, startPos.X, height);
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
            brush = new SolidBrush(Color.Black);
        }

        private void SetColorWhite_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            brush = new SolidBrush(Color.White);
        }

        private void SetColorRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
            brush = new SolidBrush(Color.Red);
        }

        private void SetColorLime_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Lime;
            brush = new SolidBrush(Color.Lime);
        }

        private void SetColorCyan_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Cyan;
            brush = new SolidBrush(Color.Cyan);
        }

        private void SetColorFushia_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Fuchsia;
            brush = new SolidBrush(Color.Fuchsia);
        }

        private void SetSize1_Click(object sender, EventArgs e)
        {
            toolSize = 1;
        }

        private void SetSize2_Click(object sender, EventArgs e)
        {
            toolSize = 2;
        }

        private void SetSize4_Click(object sender, EventArgs e)
        {
            toolSize = 4;
        }

        private void SetSize8_Click(object sender, EventArgs e)
        {
            toolSize = 8;
        }

        private void SetSize16_Click(object sender, EventArgs e)
        {
            toolSize = 16;
        }

        private void SetSize32_Click(object sender, EventArgs e)
        {
            toolSize = 32;
        }

        private void ClearCanvas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.White);
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
    }
}