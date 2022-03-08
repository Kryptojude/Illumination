using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Illumination
{
    public partial class Form1 : Form
    {
        Image ScreenBuffer;
        Graphics ScreenBufferGfx;
        Timer Timer;
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
            ScreenBuffer = new Bitmap(500, 500);
            ScreenBufferGfx = Graphics.FromImage(ScreenBuffer);
            Timer = new Timer { Interval = 16, Enabled = true };
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ScreenBuffer, 0, 0);
        }
    }
}
