using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P122310540TV.controladores
{
    internal static class LeerArchivos
    {
        static StringBuilder contenidoDelArchivo = new StringBuilder();
        static StringBuilder directorioDelArchivo = new StringBuilder();
        public static Dictionary<string, List<int>> estadosConVotos = new Dictionary<string, List<int>>();

        public static void LeerArchivo()
        {
            estadosConVotos.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt";
            openFileDialog.Title = "Abrir archivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                contenidoDelArchivo.Clear();
                directorioDelArchivo.Clear();

                directorioDelArchivo.Append(openFileDialog.FileName);
                contenidoDelArchivo.Append(File.ReadAllText(directorioDelArchivo.ToString()));
                ParsearContenido();
            }
        }

        public static void ParsearContenido()
        {
            contenidoDelArchivo.Replace(contenidoDelArchivo.ToString(), contenidoDelArchivo.ToString().Trim());
            string[] lineas = contenidoDelArchivo.ToString().Split("\r\n");
            foreach (string linea in lineas)
            {
                List<int> votosPorEstado = new List<int>();
                string[] palabras = linea.Trim().Split(" ");

                if (palabras.Length != 5) throw new Exception("El archivo no tiene el formato correcto");

                votosPorEstado.Add(int.Parse(palabras[1]));
                votosPorEstado.Add(int.Parse(palabras[2]));
                votosPorEstado.Add(int.Parse(palabras[3]));
                votosPorEstado.Add(int.Parse(palabras[4]));

                estadosConVotos.Add(palabras[0], votosPorEstado);
            }
        }

        public static void MostrarContenidoEnListView(System.Windows.Forms.ListView listView)
        {
            if (contenidoDelArchivo.ToString() != "")
            {
                listView.Items.Clear();

                ColumnHeader ESTADO = new ColumnHeader();
                ColumnHeader PRI = new ColumnHeader();
                ColumnHeader PAN = new ColumnHeader();
                ColumnHeader MORENA = new ColumnHeader();
                ColumnHeader PRD = new ColumnHeader();

                ESTADO.Width = 166;
                PRI.Width = 166;
                PAN.Width = 166;
                MORENA.Width = 166;
                PRD.Width = 166;

                // Establecer el texto de las columnas
                ESTADO.Text = "Estado";
                PRI.Text = "PRI";
                PAN.Text = "PAN";
                MORENA.Text = "MORENA";
                PRD.Text = "PRD";

                listView.Columns.Add(ESTADO);
                listView.Columns.Add(PRI);
                listView.Columns.Add(PAN);
                listView.Columns.Add(MORENA);
                listView.Columns.Add(PRD);

                foreach (var item in estadosConVotos)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Key);
                    listViewItem.SubItems.Add(item.Value[0].ToString());
                    listViewItem.SubItems.Add(item.Value[1].ToString());
                    listViewItem.SubItems.Add(item.Value[2].ToString());
                    listViewItem.SubItems.Add(item.Value[3].ToString());
                    listView.Items.Add(listViewItem);
                }
            } 
        }

        public static void guardarComo(System.Windows.Forms.ListView listView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar archivo";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ListViewItem item in listView.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            writer.Write(item.SubItems[i].Text);
                            if (i < item.SubItems.Count - 1)
                            {
                                writer.Write(" ");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        public static void guardar(System.Windows.Forms.ListView listView)
        {
            using (StreamWriter writer = new StreamWriter(directorioDelArchivo.ToString()))
            {
                foreach (ListViewItem item in listView.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        writer.Write(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1)
                        {
                            writer.Write(" "); 
                        }
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
