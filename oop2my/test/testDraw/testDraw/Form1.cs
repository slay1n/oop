using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            picture.Image = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(picture.Image);

            ShapePainter LinePainter = new LinePainter(this, button2, graph);
            ShapePainter TrianglePainter = new TrianglePainter(this, button5, graph);
            ShapePainter QuadPainter = new QuadPainter(this, button3, graph);
            ShapePainter RectPainter = new RectPainter(this, button4, graph);
            ShapePainter EllipsePainter = new EllipsePainter(this, button6, graph);
            ShapePainter CirclePainter = new CirclePainter(this, button7, graph);
        }
    }
}
