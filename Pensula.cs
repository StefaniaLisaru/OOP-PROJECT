using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Proiect_aproape_final
{
    class Pensula
    {
        private LineCap StartCap;
        private LineCap EndCap;

        private Graphics grafica;
        private Pen pen;

        private int pen_x = -1, pen_y = -1;
        private bool pen_moving = false;
        private bool puncte = true;
        private Label caseta;
        public Pensula(ref FlowLayoutPanel tabla, Color color)
        {
            grafica = tabla.CreateGraphics();
            pen = new Pen(color);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        public string returneazaGrosimePensula()
        {
            return pen.Width.ToString();
        }
        public void incepereDesenare(int X,int Y)
        {
            pen_moving = true;
            pen_x = X;
            pen_y = Y;
        }
        public void sfarsitDesenare()
        {
            pen_moving = false;
            pen_x = -1;
            pen_y = -1;
        }
        public void desenare(int X, int Y)
        {
            if (pen_moving == true && pen_x != -1 && pen_y != -1)
            {
                
                    grafica.DrawLine(pen, new Point(pen_x, pen_y), new Point(X,Y));
                    pen_x = X;
                    pen_y = Y;
               
            }
        }
        public void schimbaCuloarea(Color culoareSetata)
        {
            pen.Color = culoareSetata;
        }
        public void CresteMarimea()
        {
            pen.Width += 2;
            if (pen.Width > 0 && pen.Width <= 10)
                returneazaGrosimePensula();
            else
            {
                caseta.Text = Convert.ToString(1);
            }
        }
        public void ScadeMarimea()
        {
            pen.Width -= 2;
            if (pen.Width > 0)
                returneazaGrosimePensula();
            else
            {
                caseta.Text = Convert.ToString(1);
                pen.Width = 1;
            }
        }

    }
}

