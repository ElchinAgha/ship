using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PcbShip.Left = this.Width - 280;
        }

        private void PcbShip_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void MyTimer_Tick(object sender,EventArgs eArgs)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
          for(int i = this.Width - 280; i > 10; i--)
            {
                PcbShip.Left = i;
            }
            PcbShip.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);

        }
    }
}
