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
    public partial class ModificarEstado : Form
    {
        ListView listView;
        public ModificarEstado(ListView listView, string estado, string pri, string pan, string morena, string prd)
        {
            InitializeComponent();
            this.listView = listView;
            estadoTxtBox.Text = estado;
            priTxtBox.Text = pri;
            panTxtBox.Text = pan;
            morenaTxtBox.Text = morena;
            prdTxtBox.Text = prd;
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComprobarTxt(estadoTxtBox.Text, priTxtBox.Text, panTxtBox.Text, morenaTxtBox.Text, prdTxtBox.Text))
            {
                controladores.ModificarListView.ModificarFila(listView, estadoTxtBox.Text, int.Parse(priTxtBox.Text), int.Parse(panTxtBox.Text), int.Parse(morenaTxtBox.Text), int.Parse(prdTxtBox.Text));
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
    }
}
