using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proiect_aproape_final
{
   public abstract class Forme
    {
        protected int x1, y1;
        protected int x2, y2;
        protected Graphics grafica;
        protected Color culoareForma;
        protected Pen creion;

        public void seteazaCuloare(Color culoareSetata)
        {
            this.culoareForma = culoareSetata;
            creion.Color = culoareSetata;
        }
        public void seteazaGrafica(ref FlowLayoutPanel tabla)
        {
            grafica = tabla.CreateGraphics();
            creion = new Pen(Color.Black);
        }
        public void seteazaCoordonateInitiale(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public void seteazaCoordonateFinale(int x2, int y2)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public abstract void deseneazaForma();

        public abstract void stergeForma();

    };

    public class Linie : Forme
    {
        public override void deseneazaForma()
        {
            creion.Color = culoareForma;

            grafica.DrawLine(creion, x1, y1, x2, y2);
        }

        public override void stergeForma()
        {
            creion.Color = Color.White;
            grafica.DrawLine(creion, x1, y1, x2, y2);
        }
    };

    public class Dreptunghi : Forme
    {
        public override void deseneazaForma()
        {
            creion.Color = culoareForma;
            if (x2 < x1 && y2 < y1)
                grafica.DrawRectangle(creion, x1, y1, x1 - x2, y1 - y2);
            if (x1 < x2 && y1 < y2)
                grafica.DrawRectangle(creion, x1, y1, x2 - x1, y2 - y1);
        }

        public override void stergeForma()
        {
            creion.Color = Color.White;
            if (x2 < x1 && y2 < y1)
                grafica.DrawRectangle(creion, x1, y1, x1 - x2, y1 - y2);
            if (x1 < x2 && y1 < y2)
                grafica.DrawRectangle(creion, x1, y1, x2 - x1, y2 - y1);
        }
    };

    public class Elipsa : Forme
    {
        public override void deseneazaForma()
        {
            Rectangle rect = new Rectangle(x1, y1, x2, y2);
            creion.Color = culoareForma;
            grafica.DrawEllipse(creion, rect);
        }

        public override void stergeForma()
        {
            Rectangle rect = new Rectangle(x1, y1, x2, y2);
            creion.Color = Color.White;
            grafica.DrawEllipse(creion, rect);
        }
    }
}

