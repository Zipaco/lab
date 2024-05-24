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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        


        bool _canceled = false;
        public bool Canceled
        {
            get { return _canceled; }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            _canceled = true;
            Close();
        }


        public int W
        {
            get
            {
                string text = widthT.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        

    public int H
        {
            get
            {
                string text = heightT.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        //public string FileName
        //{
        //    get
        //    {
        //        string text = fileNameT.Text;
        //        return text;
        //    }
        //}

        

        private void confirmB_Click(object sender, EventArgs e)
        {
            PictureBox drawingArea = new PictureBox();
            drawingArea.Size = new Size(W, H);
            drawingArea.BackColor = Color.White;
            this.Controls.Add(drawingArea);

            this.Close();
        }
    }
}
