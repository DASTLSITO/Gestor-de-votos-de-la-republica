using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P122310540TV.controladores
{
    internal static class ModificarListView
    {
        public static void EliminarFila(ListView listView)
        {
            var selected = listView.CheckedItems;

            if(selected.Count == 0)
            {
                MessageBox.Show("No hay elementos seleccionados\r\nSeleccionalos con el cuadrado al lado del estado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            foreach (ListViewItem item in selected)
            {
                listView.Items.Remove(item);
            }
        }

        public static void AgregarFila(ListView listView, string estado, int pri, int pan, int morena, int prd)
        {
            ListViewItem item = new ListViewItem(estado);
            item.SubItems.Add(pri.ToString());
            item.SubItems.Add(pan.ToString());
            item.SubItems.Add(morena.ToString());
            item.SubItems.Add(prd.ToString());
            listView.Items.Add(item);
        }

        public static void ModificarFila(ListView listView, string estado, int pri, int pan, int morena, int prd)
        {
            int indice = listView.Items.IndexOf(listView.CheckedItems[0]);
            listView.Items.RemoveAt(indice);

            ListViewItem items = new ListViewItem(estado);
            items.SubItems.Add(pri.ToString());
            items.SubItems.Add(pan.ToString());
            items.SubItems.Add(morena.ToString());
            items.SubItems.Add(prd.ToString());

            listView.Items.Insert(indice, items);
        }
    }
}
