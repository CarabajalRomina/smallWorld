using smallworld.src.controladoras;
using smallworld.src.interfaces.dieta;
using smallworld.src.modelo.componentesForm;
using smallworld.vistas.admin.CRUD.COMIDA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallworld.vistas.admin.interactuables
{
    public partial class FormCRUDComida : Form
    {
        ComidaController cntComida = ComidaController.GetComidaController();

        public FormCRUDComida()
        {
            InitializeComponent();
            ActualizarDGVComidas();
        }


        #region CRUD

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CRUD.COMIDA.FormCrearComida form = new CRUD.COMIDA.FormCrearComida();
            form.ShowDialog();
            ActualizarDGVComidas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvComidas.SelectedRows[0].Cells[0].Value != null)
            {
                FormEditarComida form = new FormEditarComida(Convert.ToInt32(dgvComidas.SelectedRows[0].Cells[0].Value));
                form.ShowDialog();
                ActualizarDGVComidas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComidas.SelectedRows[0].Cells[0].Value != null)
            {
                cntComida.EliminarComida(Convert.ToInt32(dgvComidas.SelectedRows[0].Cells[0].Value));
                ActualizarDGVComidas();
            }
        }

        #endregion


        private void ActualizarDGVComidas()
        {
            dgvComidas.Rows.Clear();
            CargarDGVComidas();
        }

        private void CargarDGVComidas()
        {
            if (cntComida.COMIDAS.Count > 0)
            {
                foreach (var comida in cntComida.COMIDAS)
                {
                    dgvComidas.Rows.Add(comida.ID, comida.NOMBRE, comida.CALORIAS, comida.TIPODIETA);
                }
            }
        }

    }
}
