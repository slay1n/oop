using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDraw
{
    class EllipsePainter : ShapePainter
    {
        protected Ellipse ellipse;

        public EllipsePainter(Form1 tFrm, Button tBtn, Graphics tGraph) : base(tFrm, tBtn, tGraph)
        {

        }

        protected override void Draw()
        {
            try
            {
                ellipse = new Ellipse();
                ellipse.p1 = new Point(Convert.ToInt32(frm.textBox28.Text), Convert.ToInt32(frm.textBox27.Text));
                ellipse.width = Convert.ToInt32(frm.textBox26.Text);
                ellipse.heigth = Convert.ToInt32(frm.textBox25.Text);

                graph.DrawEllipse(new Pen(Color.Black), ellipse.p1.X, ellipse.p1.Y, ellipse.width, ellipse.heigth);
                frm.picture.Refresh();
                graph.Save();
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка");
            }
        }
    }
}
