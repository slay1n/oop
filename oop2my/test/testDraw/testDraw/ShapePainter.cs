using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDraw
{
    class ShapePainter
    {
        public static Form1 frm;
        public static Button btn;
        public static Graphics graph;

        public ShapePainter(Form1 tFrm, Button tBtn, Graphics tGraph)
        {
            frm = tFrm;
            btn = tBtn;
            graph = tGraph;
            btn.Click += new EventHandler(button_Click);
        }

        protected virtual void Draw()
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
