using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDraw
{
    class CirclePainter : EllipsePainter
    {
        protected Circle circle;

        public CirclePainter(Form1 tFrm, Button tBtn, Graphics tGraph) : base(tFrm, tBtn, tGraph)
        {

        }

        protected override void Draw()
        {
            try
            {
                circle = new Circle();
                circle.p1 = new Point(Convert.ToInt32(frm.textBox32.Text), Convert.ToInt32(frm.textBox31.Text));
                circle.radius = Convert.ToInt32(frm.textBox30.Text);
                circle.width = circle.radius * 2;
                circle.heigth = circle.width;

                graph.DrawEllipse(new Pen(Color.Black), circle.p1.X - circle.radius, circle.p1.Y - circle.radius, circle.width, circle.heigth);
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
