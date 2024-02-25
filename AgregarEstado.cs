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

namespace P122310540TV
{
    public partial class AgregarEstado : Form
    {
        ListView listView;
        public AgregarEstado(ListView listview)
        {
            InitializeComponent();
            this.listView = listview;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estado = estadoTxtBox.Text;
            string pri = priTxtBox.Text;
            string pan = panTxtBox.Text;
            string morena = morenaTxtBox.Text;
            string prd = prdTxtBox.Text;

            if (ComprobarTxt(estado, pri, pan, morena, prd))
            {
                controladores.ModificarListView.AgregarFila(listView, estado, int.Parse(pri), int.Parse(pan), int.Parse(morena), int.Parse(prd));
                this.Close();
            }
        }

        private bool ComprobarTxt(string estado, string pri, string pan, string morena, string prd)
        {
            if (estado == "" || pri == "" || pan == "" || morena == "" || prd == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
                return false;
            }

            if (!int.TryParse(pri, out int result)
                || !int.TryParse(pan, out int result2)
                || !int.TryParse(morena, out int result3)
                || !int.TryParse(prd, out int result4))
            {
                MessageBox.Show("Favor de ingresar solo números en los campos de votos");
                return false;
            }

            return true;
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

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
