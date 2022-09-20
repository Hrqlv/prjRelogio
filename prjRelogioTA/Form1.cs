using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRelogioTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string caminho = Environment.CurrentDirectory + "\\fundo.png";
        Graphics g; //area grafica do PictureBox
        Bitmap desenho; //desenho do relogio
        Color corPonteiro = Color.Black;

        int hora = 0;
        int min = 0;
        int seg = 0;

        int xseg, yseg; // ponteiro do segundo
        int xmin, ymin; // ponteiro do minuto
        int xhora, yhora; // ponteiro da hora

        private void Form1_Load(object sender, EventArgs e)
        {
            desenho = new Bitmap(pbRelogio.Width,
                pbRelogio.Height);
            g = Graphics.FromImage(desenho);

            if (!File.Exists(caminho))
            {
                relogio.Enabled = false;
                mnFundo_Click(sender, e);
                relogio.Enabled = true;
            }
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            hora = agora.Hour;
            min = agora.Minute;
            seg = agora.Second;
            DesenharRelogio();
            DesenharPonteiroSegundo();
            DesenharPonteiroMinuto();
            DesenharPonteiroHora();
            DesenharCentro();
            DesenharDigital();
            pbRelogio.CreateGraphics().DrawImage(
                desenho, 0, 0);
            GC.Collect(); // chamar a lixeira
        }

        private void DesenharDigital()
        {
            SolidBrush corSolida = new SolidBrush(Color.Red);
            g.DrawString(
                DateTime.Now.ToLongTimeString(),
                new Font("Arial",12),
                corSolida, 100, 100);
        }

        private void DesenharRelogio()
        {
            g.DrawImage(Image.FromFile(caminho), 0, 0,
                pbRelogio.Width, pbRelogio.Height);
        }

        private void DesenharCentro()
        {
            SolidBrush corSolida = new SolidBrush(Color.SaddleBrown);
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            g.FillEllipse(corSolida, cx - 10, cy - 10, 16, 16);
        }

        private void DesenharPonteiroHora()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 70;
            if (hora > 12) hora = hora - 12;
            double angulo = -90 + (hora * 30);
            Pen caneta = new Pen(Color.White, 8);
            caneta.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(caneta, cx, cy, cx + xhora, cy + yhora);
            double rad = Math.PI * angulo / 180;
            xhora = (int)(raio * Math.Cos(rad));
            yhora = (int)(raio * Math.Sin(rad));
            caneta.Color = corPonteiro;
            g.DrawLine(caneta, cx, cy, cx + xhora, cy + yhora);

        }

        private void DesenharPonteiroMinuto()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 110;
            double angulo = -90 + (min * 6);
            angulo += (min / 12) * 6;
            Pen caneta = new Pen(Color.White, 5);
            caneta.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(caneta, cx, cy, cx + xmin, cy + ymin);
            double rad = Math.PI * angulo / 180;
            xmin = (int)(raio * Math.Cos(rad));
            ymin = (int)(raio * Math.Sin(rad));
            caneta.Color = corPonteiro;
            g.DrawLine(caneta, cx, cy, cx + xmin, cy + ymin);
        }

        private void DesenharPonteiroSegundo()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 90;
            double angulo = -90 + (seg * 6);
            Pen caneta = new Pen(Color.Transparent, 5);
            caneta.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(caneta, cx, cy, cx + xseg, cy + yseg);
            double rad = Math.PI * angulo / 180;
            xseg = (int)(raio * Math.Cos(rad));
            yseg = (int)(raio * Math.Sin(rad));
            caneta.Color = corPonteiro;
            g.DrawLine(caneta, cx, cy, cx + xseg, cy + yseg);
        }

        private void mnPonteiro_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            corPonteiro = colorDialog1.Color;
        }

        private void mnFundo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            relogio.Stop();
            File.Delete(caminho);
            File.Copy(openFileDialog1.FileName,
                caminho);
            relogio.Start();
        }
    }
}
