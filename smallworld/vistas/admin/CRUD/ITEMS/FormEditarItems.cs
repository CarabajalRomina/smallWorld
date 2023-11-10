using smallworld.src.controladoras;
using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.componentesForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallworld.vistas.admin.CRUD.ITEMS
{
    public partial class FormEditarItems : Form
    {
        EstrategiasController cntEstrategia = EstrategiasController.GetController();
        ItemController cntItem = ItemController.GetController();
        public FormEditarItems(int idItem)
        {
            InitializeComponent();
            ComponentesForm.CargarComboBox(cntEstrategia.ESTRATEGIAS, cbbPoder);
            CargarForm(idItem);
        }

        private void VaciarForm()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            cbbPoder.SelectedIndex = -1;
        }

        private void CargarForm(int idItem)
        {
            var item = cntItem.BuscarItemPorId(idItem);
            if (item != null)
            {
                txtId.Text = item.ID.ToString();
                txtNombre.Text = item.NOMBRE;
                cbbPoder.SelectedItem = item.ESTRATEGIAS;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            VaciarForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cntItem.EditarItem(
               Convert.ToInt32(txtId.Text),
               txtNombre.Text,
               (IEstrategia)cbbPoder.SelectedItem
               );
            Dispose();
        }
    }
}
