using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAlbumView
{
    public partial class PhotoDetail : Form
    {
        public PhotoDetail()
        {
            InitializeComponent();
            this.sourceImg = this.pictureBox1.Image;
        }
        private int changeSize = 100;
        private int picWidth;
        private int picHeight;
        private Image sourceImg;
        private void button1_Click(object sender, EventArgs e)
        {
            this.picWidth = this.pictureBox1.Image.Width;
            this.picHeight = this.pictureBox1.Image.Height;

            Image image = new Bitmap(this.sourceImg, this.picWidth + this.changeSize, this.picHeight + this.changeSize);
            this.pictureBox1.Image = image;
        }
    }
}
