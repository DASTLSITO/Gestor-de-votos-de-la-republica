using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P122310540TV
{
    public partial class Grafica : Form
    {
        private System.Windows.Forms.Timer timer;
        private int progress;

        Dictionary<string, List<int>> estadosConVotos = new Dictionary<string, List<int>>();
        string estado;
        public Grafica(Dictionary<string, List<int>> estadosConVotos, string tipoDeGrafica, string estado)
        {
            InitializeComponent();
            this.estadosConVotos = estadosConVotos;
            this.estado = estado;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;

            // Inicializa la barra de progreso
            progress = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            timer.Start();

            if (tipoDeGrafica == "pastel")
            {
                GraficarPastel();
            }
            else
            {
                GraficarBarras();
            }
        }

        public void GraficarPastel()
        {
            chart1.Series.Clear();
            Series seriePastel = chart1.Series.Add($"Votos por partido - {estado}");
            chart1.Titles.Add("Votos por partido");
            seriePastel.Points.AddXY("PRI", estadosConVotos[estado][0]);
            seriePastel.Points.AddXY("PAN", estadosConVotos[estado][1]);
            seriePastel.Points.AddXY("MORENA", estadosConVotos[estado][2]);
            seriePastel.Points.AddXY("PRD", estadosConVotos[estado][3]);
            chart1.Series[0].ChartType = SeriesChartType.Pie;
        }

        public void GraficarBarras()
        {
            chart1.Series.Clear();

            Series seriesPri = new("PRI");
            Series seriesPan = new("PAN");
            Series seriesMor = new("Morena");
            Series seriesPrd = new("PRD");

            seriesPri.ChartType = SeriesChartType.Column;
            seriesPan.ChartType = SeriesChartType.Column;
            seriesMor.ChartType = SeriesChartType.Column;
            seriesPrd.ChartType = SeriesChartType.Column;

            chart1.Series.Add(seriesPri);
            chart1.Series.Add(seriesPan);
            chart1.Series.Add(seriesMor);
            chart1.Series.Add(seriesPrd);

            chart1.Series["PRI"].Points.AddY(estadosConVotos[estado][0]);
            chart1.Series["PAN"].Points.AddY(estadosConVotos[estado][1]);
            chart1.Series["Morena"].Points.AddY(estadosConVotos[estado][2]);
            chart1.Series["PRD"].Points.AddY(estadosConVotos[estado][3]);

            chart1.Series["PRI"].Points[0].AxisLabel = "PRI";
            chart1.Series["PAN"].Points[0].AxisLabel = "PAN";
            chart1.Series["Morena"].Points[0].AxisLabel = "MORENA";
            chart1.Series["PRD"].Points[0].AxisLabel = "PRD";

            chart1.Titles.Add($"Votos por partido - {estado}");
            chart1.ChartAreas[0].AxisX.Title = "Partidos";
            chart1.ChartAreas[0].AxisY.Title = "Votos";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progress += 10;

            if (progress >= progressBar1.Maximum)
            {
                timer.Stop();
                progressBar1.Visible = false;
                label1.Visible = false;
                chart1.Visible = true;
            }
            else
            {
                progressBar1.Value = progress;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
