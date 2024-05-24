using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4spl3._2
{
    public partial class Form1 : Form
    {

        int _x;
        int _y;
        bool _mouseClicked = false;


        Color SelectedColor
        {
            get {

                if (_selectedBrush != null)
                {
                     return _selectedBrush.BrushColor;
                }
                return Color.Black;
            }
        }

        int SelectedSize
        {
            get { return sizeBrush.Value; }
        }

        Brush _selectedBrush;

        Brush SelectedBrush
        {
            get { return _selectedBrush; }
            set
            {
                _selectedBrush = value;
                _selectedBrush.SetSize(SelectedSize);
                _selectedBrush.BrushColor = SelectedColor;
            }
        }


        private void ChangeBrushColor(Color newColor)
        {
            if (_selectedBrush != null)
            {
                _selectedBrush.BrushColor = newColor;
            }
        }

        //private void ChangeFillColor(Color newColor)
        //{
        //    if (_selectedFill != null)
        //    {
        //        _selectedFill.Dispose();
        //    }
        //    _selectedFill = new SolidBrush(newColor);
        //    pictureBox1.Invalidate();
        //}

        //SolidBrush _selectedFill;

        Color DefaultColor
        {
            get
            {
                return Color.White;
            }
        }

        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }

            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }

        }

        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);

            

        }

        private void selectBrush_Click(object sender, EventArgs e)
        {
            
            if (settingBrush.Visible == false)
            {
                settingBrush.Visible = true;
            }
            else
            {
                settingBrush.Visible = false;
            }
        }

        private void settingBrush_Paint(object sender, PaintEventArgs e)
        {

        }

        private void squareBrush_MouseClick(object sender, MouseEventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }

            _selectedBrush.Draw (pictureBox1.Image as Bitmap,  _x,  _y);
            pictureBox1.Refresh();

            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;

            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void cBlack_Click(object sender, EventArgs e)
        {

            ChangeBrushColor(Color.Black);

        }

        private void cWhite_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.White);
        }

        private void cRed_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.Red);
        }

        private void cOrange_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.Orange);
        }

        private void cYellow_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.Yellow);
        }

        private void cGreen_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.Green);
        }

        private void cLime_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.Lime);
        }

        private void cBlue_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.Blue);
        }

        private void cPurple_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.Purple);
        }

        private void cGray_Click(object sender, EventArgs e)
        {
            ChangeBrushColor(Color.Gray);
        }

        private void circleBrush_MouseClick(object sender, MouseEventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void rectangleBrush_MouseClick(object sender, MouseEventArgs e)
        {
            _selectedBrush = new RingBrush(SelectedColor, SelectedSize);
        }

        private void squareBrush2_MouseClick(object sender, MouseEventArgs e)
        {
            _selectedBrush = new RhombusBrush(SelectedColor, SelectedSize);
        }

        private void eraserBrush_MouseClick(object sender, MouseEventArgs e)
        {
            _selectedBrush = new EreserBrush(SelectedColor, SelectedSize);
        }

        private void sizeBrush_Scroll(object sender, EventArgs e)
        {
            SelectedBrush.SetSize(SelectedSize);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create form = new Create();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);

            //this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "PNG files ( * .png)| * .png|JPEG files ( * .jpg)| * .jpg";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileExtension = Path.GetExtension(saveDialog.FileName).ToLower();
                if (fileExtension == ".png")
                {
                    bitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (fileExtension == ".jpg" || fileExtension == ".jpeg")
                {
                    bitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void selectFill_Click(object sender, EventArgs e)
        {
            if (settingFilling.Visible == false)
            {
                settingFilling.Visible = true;
            }
            else
            {
                settingFilling.Visible = false;
            }
        }

        private void backGroundBlack_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void backGroundWhite_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void backGroundRed_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void backGroundOrange_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void backGroundYellow_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void backGroundGreen_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void backGroundLimeGreen_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void backGroundBlue_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void backGroundPurple_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void backGroundGray_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }
    }
}
