using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace testDraw
{
    class LinePainter : ShapePainter
    {
        private Line line;

        public LinePainter(Form1 tFrm, Button tBtn, Graphics tGraph) : base(tFrm, tBtn, tGraph)
        {

        }

        protected override void Draw()
        {
            try
            {
                line = new Line();
                line.p1 = new Point(Convert.ToInt32(frm.textBox3.Text), Convert.ToInt32(frm.textBox4.Text));
                line.p2 = new Point(Convert.ToInt32(frm.textBox5.Text), Convert.ToInt32(frm.textBox6.Text));

                graph.DrawLine(new Pen(Color.Black), line.p1, line.p2);
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
