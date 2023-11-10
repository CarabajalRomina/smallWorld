
using smallworld.src.modelo.entidades;
using System.Windows.Forms;

namespace smallworld.src.modelo.componentesForm
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

        public static void CargarDataGridConBinding<T>(DataGridView dv, BindingSource bs, List<T> datosTabla, bool resetSiNo)
        {
            bs.ResetBindings(resetSiNo);
            bs.DataSource = datosTabla;
            dv.DataSource = bs;
        }

        /*private List<IHabitat> ObtenerHabitatsSeleccionadosCheckList()
        {
            var habitat = new List<IHabitat>();
            // Obténer los elementos seleccionados en el CheckedListBox
            CheckedListBox.CheckedItemCollection selectedItems = checkListHabitat.CheckedItems;

            foreach (IHabitat item in selectedItems)
            {
                habitat.Add(item);
            }
            return habitat;
        }*/
        /*private void MarcarCheckListSeleccionados(Entidad entidad)
            {
                foreach (var habitat in entidad.HABITATS)
                {
                    for (int i = 0; i < checkListHabitat.Items.Count; i++)
                    {
                        if (checkListHabitat.Items[i] == habitat)
                        {
                            checkListHabitat.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }*/

    }
}
