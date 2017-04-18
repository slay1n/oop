using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDraw
{
    class TrianglePainter : ShapePainter
    {
        private Triangle triangle;

        public TrianglePainter(Form1 tFrm, Button tBtn, Graphics tGraph) : base(tFrm, tBtn, tGraph)
        {

        }

        protected override void Draw()
        {
            try
            {
                triangle = new Triangle();
                triangle.p1 = new Point(Convert.ToInt32(frm.textBox22.Text), Convert.ToInt32(frm.textBox21.Text));
                triangle.p2 = new Point(Convert.ToInt32(frm.textBox20.Text), Convert.ToInt32(frm.textBox19.Text));
                triangle.p3 = new Point(Convert.ToInt32(frm.textBox24.Text), Convert.ToInt32(frm.textBox23.Text));
                Point[] points = new Point[3];
                points[0] = triangle.p1;
                points[1] = triangle.p2;
                points[2] = triangle.p3;

                graph.DrawPolygon(new Pen(Color.Black), points);
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
