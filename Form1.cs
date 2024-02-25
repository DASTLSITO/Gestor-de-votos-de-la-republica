using Microsoft.VisualBasic;
using P122310540TV.controladores;
using System;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace P122310540TV
{
    public partial class Form1 : Form
    {
        bool guardado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: Jesús Eduardo Álvarez Pérez\r\nContacto: alvarez270904@gmail.com", "Creditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LeerArchivos.LeerArchivo();
                ActivarBotones();
                LeerArchivos.MostrarContenidoEnListView(listView1);
                MostrarMensajeEnStatusStrip("Archivo cargado correctamente");
                guardado = false;
            }
            catch (Exception ex)
            {
                //DesactivarBotones();
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
                //listView1.Clear();
            }
        }

        private void ActivarBotones()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            guardarComoToolStripMenuItem.Enabled = true;
            guardarToolStripMenuItem.Enabled = true;
            opcionesToolStripMenuItem.Enabled = true;
        }

        private void DesactivarBotones()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            guardarComoToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
            opcionesToolStripMenuItem.Enabled = false;
        }

        public void MostrarMensajeEnStatusStrip(string mensaje)
        {
            statusStrip1.Items[0].Text = mensaje;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarEstado();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarEstado();
        }

        private void EliminarEstado()
        {
            ModificarListView.EliminarFila(listView1);
            MostrarMensajeEnStatusStrip("Estado eliminado correctamente");
            guardado = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEstado();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEstado();
        }

        private void AgregarEstado()
        {
            AgregarEstado form = new AgregarEstado(listView1);
            form.ShowDialog();
            MostrarMensajeEnStatusStrip("Estado agregado correctamente");
            guardado = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarEstado();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEstado();
        }

        private void ModificarEstado()
        {
            if (listView1.CheckedItems.Count != 1)
            {
                MessageBox.Show("Seleccione solo un elemento\r\nSeleccionalos con el cuadrado al lado del estado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ListViewItem item = listView1.CheckedItems[0];
                string estado = item.SubItems[0].Text;
                string pri = item.SubItems[1].Text;
                string pan = item.SubItems[2].Text;
                string morena = item.SubItems[3].Text;
                string prd = item.SubItems[4].Text;

                ModificarEstado form = new ModificarEstado(listView1, estado, pri, pan, morena, prd);
                form.ShowDialog();
                MostrarMensajeEnStatusStrip("Estado modificado correctamente");
                guardado = false;
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeerArchivos.guardarComo(listView1);
            MostrarMensajeEnStatusStrip("Archivo guardado correctamente correctamente");
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeerArchivos.guardar(listView1);
            MostrarMensajeEnStatusStrip("Archivo guardado correctamente");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graficar("barras");
        }

        private void graficarbarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graficar("barras");
        }

        private void graficarpastelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graficar("pastel");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graficar("pastel");
        }

        private void graficar(string tipo)
        {
            if (listView1.CheckedItems.Count != 1)
            {
                MessageBox.Show("Seleccione solo un elemento\r\nSeleccionalos con el cuadrado al lado del estado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Grafica forms = new Grafica(LeerArchivos.estadosConVotos, tipo, listView1.CheckedItems[0].SubItems[0].Text);
            forms.ShowDialog();
        }
    }
}
