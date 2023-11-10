using smallworld.src.controladoras;
using smallworld.src.interfaces.interactuable;
using smallworld.src.modelo.componentesForm;
using smallworld.src.modelo.estrategias;
using smallworld.src.modelo.estrategias.decoradoresConcretos;
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
    public partial class FormCrearItems : Form
    {
        EstrategiasController cntEstrategia = EstrategiasController.GetController();
        ItemController cntItem = ItemController.GetController();
        EstrategiaComponente componenteBase = new EstrategiaComponente();
        IDecorable decoradorBase;
        public FormCrearItems()
        {
            InitializeComponent();
            ComponentesForm.CargarComboBox(cntEstrategia.ESTRATEGIAS, cbbPoder);
            ComponentesForm.CargarComboBox(cntEstrategia.DECORADORES, cbbDecoradores);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void VaciarForm()
        {
            txtNombre.Text = "";
            cbbPoder.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            VaciarForm();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            cntItem.CrearItem(
              txtNombre.Text,
              (IEstrategia)cbbPoder.SelectedItem
              );
            VaciarForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var estrategia = (IDecorable)cbbDecoradores.SelectedItem;

            if (decoradorBase == null)
            {
                new DecoradorAumentarAtaque(new DecoradorAumentarEnergia(new EstrategiaComponente()));
                decoradorBase = (IDecorable)cbbDecoradores.SelectedItem;
            }else
            {               
                estrategia.Decorar(decoradorBase);
            }
            lblTexto.Text = estrategia.ToString();
        }
    }
}
