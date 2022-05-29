using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using Microsoft.VisualBasic;

namespace Proiect_aproape_final
{
    public partial class MyPaint : Form
    {
        Pensula pensula;
        Forme[] forme = new Forme[3];
        Pensula pensulaRetea;
        Forme[] formeRetea = new Forme[3];
        bool estePensulaSetata = false;
        bool esteFormaSetata = false;
        bool esteMouseApasat = false;
        int indiceForma = 0;
        string numeClient;
        string serverIp;
        int serverPort;
        
       
        public MyPaint()
        {
            InitializeComponent();
            pensula = new Pensula(ref flowLayoutPanel1, Color.Black);
            pensulaRetea = new Pensula(ref flowLayoutPanel1, Color.Black);

            labelActualSize.Text = pensula.returneazaGrosimePensula();
            forme[0] = new Linie();
            forme[1] = new Dreptunghi();
            forme[2] = new Elipsa();
            for (int i = 0; i < 3; i++)
            {
                forme[i].seteazaGrafica(ref flowLayoutPanel1);
            }
            formeRetea[0] = new Linie();
            formeRetea[1] = new Dreptunghi();
            formeRetea[2] = new Elipsa();
            for (int i = 0; i < 3; i++)
            {
                formeRetea[i].seteazaGrafica(ref flowLayoutPanel1);
            }

            NetworkComms.AppendGlobalIncomingPacketHandler<string>("Message", ReceivedPacketsHandlers);
        }

        private void ReceivedPacketsHandlers(PacketHeader header, Connection connection, String message)
        {
            string mesajDecodat = message.Substring(1);
            Console.WriteLine(message);
            if (message[0] == '&')
            {
                writeConnectedLabelSafe(mesajDecodat);
            }
            else
            {
                receptieSiParsareDateEvent(mesajDecodat, message[0]);
            }
        }

        public void receptieSiParsareDateEvent(string message,char caracterulDeEncodare)
        {
            bool estePensulaSetataRetea = false;
            bool esteFormaSetataRetea = false;
            bool esteMouseSetatRetea = false;
            int XRetea = 0;
            int YRetea = 0;
            int indiceFormaRetea = 0;
            char caracterEveniment = message[0];
            string[] vectorVariabile;
            string numeVariabila;
            string valoareVariabila;
            vectorVariabile = message.Split(caracterulDeEncodare);
            foreach (string variabilaEncodata in vectorVariabile)
            {
                numeVariabila = variabilaEncodata.Split('=')[0];
                valoareVariabila = variabilaEncodata.Split('=')[1];
                if (numeVariabila == "pensula")
                {
                    estePensulaSetataRetea = bool.Parse(valoareVariabila);
                }
                if (numeVariabila == "forma")
                {
                    esteFormaSetataRetea = bool.Parse(valoareVariabila);
                }
                if (numeVariabila == "mouse")
                {
                    esteMouseSetatRetea = bool.Parse(valoareVariabila);
                }
                if (numeVariabila == "X")
                {
                    XRetea = Int32.Parse(valoareVariabila);
                }
                if (numeVariabila == "Y")
                {
                    YRetea = Int32.Parse(valoareVariabila);
                }
                if (numeVariabila == "indiceForma")
                {
                    indiceFormaRetea = Int32.Parse(valoareVariabila);
                }
            }
            if (caracterulDeEncodare == '#')
            {
                mouseDownRetea(estePensulaSetataRetea, esteFormaSetataRetea, esteMouseSetatRetea, XRetea, YRetea, indiceFormaRetea);
            }
            if (caracterulDeEncodare == '$')
            {
                mouseMoveRetea(estePensulaSetataRetea, esteFormaSetataRetea, esteMouseSetatRetea, XRetea, YRetea, indiceFormaRetea);
            }
            if (caracterulDeEncodare == '%')
            {
                mouseUpRetea(estePensulaSetataRetea, esteFormaSetataRetea, esteMouseSetatRetea, XRetea, YRetea, indiceFormaRetea);
            }
        }

        public void mouseDownRetea(bool estePensulaSetataRetea, bool esteFormaSetataRetea, bool esteMouseSetatRetea, int XRetea, int YRetea, int indiceFormaRetea)
        {
            if (estePensulaSetataRetea)
            {
                pensulaRetea.incepereDesenare(XRetea, YRetea);
            }
            if (esteFormaSetataRetea)
            {
                esteMouseSetatRetea = true;
                formeRetea[indiceFormaRetea].seteazaCoordonateInitiale(XRetea, YRetea);
            }
        }

        public void mouseMoveRetea(bool estePensulaSetataRetea, bool esteFormaSetataRetea, bool esteMouseSetatRetea, int XRetea, int YRetea, int indiceFormaRetea)
        {
            if (estePensulaSetataRetea)
            {
                pensulaRetea.desenare(XRetea, YRetea);
            }
            if (esteFormaSetataRetea)
            {
                if (esteMouseSetatRetea)
                {
                    formeRetea[indiceFormaRetea].seteazaCoordonateFinale(XRetea, YRetea);
                    formeRetea[indiceFormaRetea].deseneazaForma();
                    formeRetea[indiceFormaRetea].stergeForma();

                }
            }
        }

        public void mouseUpRetea(bool estePensulaSetataRetea, bool esteFormaSetataRetea, bool esteMouseSetatRetea, int XRetea, int YRetea, int indiceFormaRetea)
        {
            if (estePensulaSetataRetea)
            {
                pensulaRetea.sfarsitDesenare();
            }
            if (esteFormaSetataRetea)
            {
                formeRetea[indiceForma].seteazaCoordonateFinale(XRetea, YRetea);
                formeRetea[indiceForma].deseneazaForma();
                esteMouseSetatRetea = false;
            }
        }

        public void writeConnectedLabelSafe(string text)
        {
            if (labelConnected.InvokeRequired)
            {
                Action safeWrite = delegate { writeConnectedLabelSafe(text); };
                labelConnected.Invoke(safeWrite);
            }
            else
            {
                labelConnected.Text = text;
            }
        }

        private void MyPaint_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            this.Refresh();
           

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            pensula.CresteMarimea();
            labelActualSize.Text = pensula.returneazaGrosimePensula();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            pensula.ScadeMarimea();
            labelActualSize.Text = pensula.returneazaGrosimePensula();
        }

        private void btnLinie_Click(object sender, EventArgs e)
        {
            estePensulaSetata = false;
            esteFormaSetata = true;
            indiceForma = 0;
        }

        private void btnDreptunghi_Click(object sender, EventArgs e)
        {
            estePensulaSetata = false;
            esteFormaSetata = true;
            indiceForma = 1;
        }

        private void btnElipsa_Click(object sender, EventArgs e)
        {
            estePensulaSetata = false;
            esteFormaSetata = true;
            indiceForma = 2;
        }

        private void btnPensula_Click(object sender, EventArgs e)
        {
            estePensulaSetata = true;
            esteFormaSetata = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            PictureBox imagineCuloare = (PictureBox)sender;
            pensula.schimbaCuloarea(imagineCuloare.BackColor);
            for (int i = 0; i < 3; i++)
            {
                forme[i].seteazaCuloare(imagineCuloare.BackColor);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            string encodedString = "";
            string coordonate = "";
            coordonate = "X=" + e.X.ToString() + "#" + "Y=" + e.Y.ToString();
            encodedString = "#" + "client=" + this.numeClient + "#" + "forma=" + esteFormaSetata.ToString() + "#" + "indiceForma=" + indiceForma.ToString() + "#" + "pensula=" + estePensulaSetata.ToString() + "#" + "mouse=" + esteMouseApasat.ToString() + "#" + coordonate;
            if (labelConnected.Text == "connectionEstablished")
            {
                NetworkComms.SendObject<string>("Message", this.serverIp, this.serverPort, encodedString);
            }
            if (estePensulaSetata)
            {
                pensula.incepereDesenare(e.X, e.Y);
            }
            if (esteFormaSetata)
            {
                esteMouseApasat = true;
                forme[indiceForma].seteazaCoordonateInitiale(e.X, e.Y);
            }
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            string coordonate = "";
            string encodedString = "";
            coordonate = "X=" + e.X.ToString() + "$" + "Y=" + e.Y.ToString();
            encodedString = "$" + "client=" + this.numeClient + "$" + "forma=" + esteFormaSetata.ToString() + "$" + "indiceForma=" + indiceForma.ToString() + "$" + "pensula=" + estePensulaSetata.ToString() + "$" + "mouse=" + esteMouseApasat.ToString() + "$" + coordonate;
            if (labelConnected.Text == "connectionEstablished")
            {
               
                NetworkComms.SendObject<string>("Message", this.serverIp, this.serverPort, encodedString);
            }
            if (estePensulaSetata)
            {
                pensula.desenare(e.X, e.Y);
            }
            if (esteFormaSetata)
            {
                if (esteMouseApasat)
                {
                    forme[indiceForma].seteazaCoordonateFinale(e.X, e.Y);
                     forme[indiceForma].deseneazaForma();
                    forme[indiceForma].stergeForma();
                    
                }
            }
        }

        private void labelActualSize_Click(object sender, EventArgs e)
        {
            labelActualSize.Text = pensula.returneazaGrosimePensula();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ip, stringPort;
            int port;
            string ipSiPort = Interaction.InputBox("Enter ip and port of the client", "Client box", "ex : 10.10.10.10:123");
            this.numeClient = Interaction.InputBox("Enter a client name", "Client Name Box", "ex : Bob");
            this.serverIp = ipSiPort.Split(':')[0];
            stringPort = ipSiPort.Split(':')[1];
            this.serverPort = Int32.Parse(stringPort);
            NetworkComms.SendObject<string>("Message", this.serverIp, this.serverPort, "@" +  this.numeClient);
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            string coordonate = "";
            string encodedString = "";
            coordonate = "X=" + e.X.ToString() + "%" + "Y=" + e.Y.ToString();
            encodedString = "%" + "client=" + this.numeClient + "%" + "forma=" + esteFormaSetata.ToString() + "%" + "indiceForma=" + indiceForma.ToString() + "%" + "pensula=" + estePensulaSetata.ToString() + "%" + "mouse=" + esteMouseApasat.ToString() + "%" + coordonate;
            if (labelConnected.Text == "connectionEstablished")
            {
                NetworkComms.SendObject<string>("Message", this.serverIp, this.serverPort, encodedString);
            }
            if (estePensulaSetata)
            {
                pensula.sfarsitDesenare();
            }
            if (esteFormaSetata)
            {
                forme[indiceForma].seteazaCoordonateFinale(e.X, e.Y);
                forme[indiceForma].deseneazaForma();
                esteMouseApasat = false;
            }
        }       
    }
}
