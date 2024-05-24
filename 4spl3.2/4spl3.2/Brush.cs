using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4spl3._2
{
    abstract class Brush
    {
        public Color BrushColor { get; set; }
        public int Size { get; set; }
        public void SetSize(int size)
        {
            Size = size;
        }
        public Brush(Color brushColor, int size)
        {
            BrushColor = brushColor;
            Size = size;
        }
        public abstract void Draw(Bitmap image, int x, int y);
       
    }
    class QuadBrush : Brush
    {
        public QuadBrush(Color brushColor, int size)
            : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if (x0 >= 0 && x0 < image.Width && y0 >= 0 && y0 < image.Height)
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                }

            }

        }
    }

    class CircleBrush : Brush
    {
        public CircleBrush(Color brushColor, int size)
            : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 <= y + Size; ++y0)
            {
                double dy = y0 - (double)y;
                for (int x0 = x - Size; x0 <= x + Size; ++x0)
                {
                    double dx = x0 - (double)x;
                    if (dx * dx + dy * dy <= Size * Size)
                    {
                        if (x0 >= 0 && x0 < image.Width && y0 >= 0 && y0 < image.Height)
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }
                    }
                }
            }
        }
    }

    class RingBrush : Brush
    {
        public RingBrush(Color brushColor, int size)
            : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 <= y + Size; ++y0)
            {
                double dy = y0 - (double)y;
                for (int x0 = x - Size; x0 <= x + Size; ++x0)
                {
                    double dx = x0 - (double)x;
                    if (Math.Abs(dx * dx + dy * dy - Size * Size) < 2 * Math.Sqrt(2) * Size)
                    {
                        if (x0 >= 0 && x0 < image.Width && y0 >= 0 && y0 < image.Height)
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }
                    }
                }
            }
        }
    }

    class RhombusBrush : Brush
    {
        public RhombusBrush(Color brushColor, int size)
            : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 <= y + Size; ++y0)
            {
                double dy = y0 - (double)y;
                for (int x0 = x - Size; x0 <= x + Size; ++x0)
                {
                    double dx = x0 - (double)x;
                    if (Math.Abs(dx) + Math.Abs(dy) <= Size && Math.Abs(dx) + Math.Abs(dy) >= Math.Abs(dx - dy))
                    {
                        if (x0 >= 0 && x0 < image.Width && y0 >= 0 && y0 < image.Height)
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }
                    }
                }
            }
        }
    }

    class EreserBrush : Brush
    {
        public EreserBrush(Color brushColor, int size)
            : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if (x0 >= 0 && x0 < image.Width && y0 >= 0 && y0 < image.Height)
                    {
                        image.SetPixel(x0, y0, Color.White);
                    }
                }
            }
        }
    }

}
