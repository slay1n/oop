using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDraw
{
    class RectPainter : QuadPainter
    {
        public RectPainter(Form1 tFrm, Button tBtn, Graphics tGraph) : base(tFrm, tBtn, tGraph)
        {

        }

        protected override void Draw()
        {
            try
            {
                quad = new Quadrangle();
                quad.p1 = new Point(Convert.ToInt32(frm.textBox11.Text), Convert.ToInt32(frm.textBox12.Text));
                quad.p2 = new Point(Convert.ToInt32(frm.textBox13.Text), Convert.ToInt32(frm.textBox12.Text));
                quad.p3 = new Point(Convert.ToInt32(frm.textBox13.Text), Convert.ToInt32(frm.textBox14.Text));
                quad.p4 = new Point(Convert.ToInt32(frm.textBox11.Text), Convert.ToInt32(frm.textBox14.Text));

                graph.DrawLine(new Pen(Color.Black), quad.p1, quad.p2);
                graph.DrawLine(new Pen(Color.Black), quad.p2, quad.p3);
                graph.DrawLine(new Pen(Color.Black), quad.p3, quad.p4);
                graph.DrawLine(new Pen(Color.Black), quad.p4, quad.p1);
                frm.picture.Refresh();
                graph.Save();
            }
            catch
            {
                MessageBox.Show("Некорректные даныне", "Ошибка");
            }
        }
    }
}
