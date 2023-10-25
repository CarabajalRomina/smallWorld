using smallworld.interfaces.habitat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallworld.modelo.componentesForm
{
    public static class ComponentesForm
    {
        public static void CargarComboBox<T>(List<T> lista, ComboBox cbb)
        {
            foreach (var elemento in lista)
            {
                cbb.Items.Add(elemento);
            }
        }

        public static void CargarCheckList<T>(List<T> lista, CheckedListBox cl)
        {
            foreach (var elemento in lista)
            {
                cl.Items.Add(elemento);
            }
        }

        public static void DesmarcarCheckList(CheckedListBox checkList)
        {
            for (int i = 0; i < checkList.Items.Count; i++)
            {
                checkList.SetItemChecked(i, false);
            }
        }

        /*
        private static void CrearDataGrid(int cantColum, List<string> nombresCabecera, DataGridView dv)
        {

            for (int i = 0; i < cantColum; i++)
            {
               DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();

                columna.HeaderText = nombresCabecera[i];

                dv.Columns.Add(columna);
            }
            dv.Columns[0].Visible = false;

        }*/


        public static void CargarDataGrid<T>(DataGridView dv, List<T> datosTabla)
        {
            dv.DataSource = datosTabla;
        }

      

    }
}
