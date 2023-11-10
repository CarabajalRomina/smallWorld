using smallworld.Properties;
using smallworld.src.controladoras;
using smallworld.vistas.admin.CRUD.COMIDA;
using smallworld.vistas.admin.CRUD.ENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallworld.vistas.admin
{
    public partial class FormCRUDEntidad : Form
    {
        EntidadController cntEntidad = EntidadController.GetEntidadController();

        public FormCRUDEntidad()
        {
            InitializeComponent();
            ActualizarDGVEntidad();
        }


        #region CRUD
        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearEntidad form = new FormCrearEntidad();
            form.ShowDialog();
            ActualizarDGVEntidad();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEntidades.SelectedRows[0].Cells[0].Value != null)
            {
                FormEditarEntidad form = new FormEditarEntidad(Convert.ToInt32(dgvEntidades.SelectedRows[0].Cells[0].Value));
                form.ShowDialog();
                ActualizarDGVEntidad();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEntidades.SelectedRows[0].Cells[0].Value != null)
            {
                cntEntidad.EliminarEntidad(Convert.ToInt32(dgvEntidades.SelectedRows[0].Cells[0].Value));
                ActualizarDGVEntidad();
            }
        }
        #endregion

        private void ActualizarDGVEntidad()
        {
            dgvEntidades.Rows.Clear();
            CargarDGVEntidades();
        }

        private void CargarDGVEntidades()
        {
            if (cntEntidad.ENTIDADES.Count > 0)
            {
                foreach (var entidad in cntEntidad.ENTIDADES)
                {
                    dgvEntidades.Rows.Add(
                        entidad.ID,
                        entidad.NOMBRE,
                        entidad.REINO,
                        entidad.DIETA,
                        entidad.HABITATS,
                        entidad.ENERGIACTUAL,
                        entidad.ENERGIAMAX,
                        entidad.VIDAACTUAL,
                        entidad.VIDAMAX,
                        entidad.PUNTOSATAQUE,
                        entidad.PUNTOSDEFENSA,
                        entidad.RANGOATAQUE
                        );
                }
            }
        }
    }
}
