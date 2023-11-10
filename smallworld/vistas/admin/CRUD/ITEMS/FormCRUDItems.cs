using smallworld.src.controladoras;
using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.componentesForm;
using smallworld.vistas.admin.CRUD.ITEMS;

namespace smallworld.vistas.admin.interactuables
{
    public partial class FormCRUDItems : Form
    {
        EstrategiasController cntEstrategia = EstrategiasController.GetController();
        ItemController cntItem = ItemController.GetController();

        public FormCRUDItems()
        {
            InitializeComponent();
            ActualizarDatagridItems();
        }

        #region CRUD
        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearItems form = new FormCrearItems();
            form.ShowDialog();
            ActualizarDatagridItems();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvItem.SelectedRows[0].Cells[0].Value != null)
            {
                FormEditarItems form = new FormEditarItems(Convert.ToInt32(dgvItem.SelectedRows[0].Cells[0].Value));
                form.ShowDialog();
                ActualizarDatagridItems();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvItem.SelectedRows[0].Cells[0].Value != null)
            {
                cntItem.EliminarItem(Convert.ToInt32(dgvItem.SelectedRows[0].Cells[0].Value));
            }
            ActualizarDatagridItems();
        }
        #endregion


        private void CargarCheckList()
        {
            // ComponentesForm.CargarCheckList(cntEstrategia.GetEstrategias(), clbEstrategi);
        }

        /*private List<IEstrategia> ObtenerEstrategiasSeleccionadosCheckList()
       {
           var estrategia = new List<IEstrategia>();
           // Obténer los elementos seleccionados en el CheckedListBox
           //CheckedListBox.CheckedItemCollection selectedItems = clbEstrategi.CheckedItems;

          foreach (IEstrategia item in selectedItems)
           {
               estrategia.Add(item);
           }
           return estrategia;
       }*/

        private void MarcarCheckListSeleccionados(List<IEstrategia> estrategias)
        {
            /*foreach (var estrategia in estrategias)
            {
                for (int i = 0; i < clbEstrategi.Items.Count; i++)
                {
                    if (clbEstrategi.Items[i] == estrategia)
                    {
                        clbEstrategi.SetItemChecked(i, true);
                        break;
                    }
                }
            }*/
        }



        private void ActualizarDatagridItems()
        {
            dgvItem.Rows.Clear();
            CargarDataGridItems();
        }

        private void CargarDataGridItems()
        {
            foreach (var item in cntItem.ITEMS)
            {
                dgvItem.Rows.Add(item.ID, item.NOMBRE, item.ESTRATEGIAS);
            }
        }
    }
}
