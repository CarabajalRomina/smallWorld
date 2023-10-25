namespace smallworld.vistas.admin
{
    partial class FormCrudEntidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dvEntidades = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            REINO = new DataGridViewTextBoxColumn();
            DIETA = new DataGridViewTextBoxColumn();
            HABITATS = new DataGridViewTextBoxColumn();
            ENERGIACTUAL = new DataGridViewTextBoxColumn();
            ENERGIAMAX = new DataGridViewTextBoxColumn();
            VIDAACTUAL = new DataGridViewTextBoxColumn();
            VIDAMAX = new DataGridViewTextBoxColumn();
            PUNTOSATAQUE = new DataGridViewTextBoxColumn();
            PUNTOSDEFENSA = new DataGridViewTextBoxColumn();
            RANGOATAQUE = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvEntidades).BeginInit();
            SuspendLayout();
            // 
            // dvEntidades
            // 
            dvEntidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvEntidades.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, REINO, DIETA, HABITATS, ENERGIACTUAL, ENERGIAMAX, VIDAACTUAL, VIDAMAX, PUNTOSATAQUE, PUNTOSDEFENSA, RANGOATAQUE });
            dvEntidades.Location = new Point(131, 12);
            dvEntidades.Name = "dvEntidades";
            dvEntidades.RowHeadersWidth = 51;
            dvEntidades.RowTemplate.Height = 29;
            dvEntidades.Size = new Size(1158, 493);
            dvEntidades.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "Nombre";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 125;
            // 
            // REINO
            // 
            REINO.HeaderText = "Reino";
            REINO.MinimumWidth = 6;
            REINO.Name = "REINO";
            REINO.ReadOnly = true;
            REINO.Width = 125;
            // 
            // DIETA
            // 
            DIETA.HeaderText = "Dieta";
            DIETA.MinimumWidth = 6;
            DIETA.Name = "DIETA";
            DIETA.Width = 125;
            // 
            // HABITATS
            // 
            HABITATS.HeaderText = "Habitats";
            HABITATS.MinimumWidth = 6;
            HABITATS.Name = "HABITATS";
            HABITATS.ReadOnly = true;
            HABITATS.Width = 125;
            // 
            // ENERGIACTUAL
            // 
            ENERGIACTUAL.HeaderText = "Energia Actual";
            ENERGIACTUAL.MinimumWidth = 6;
            ENERGIACTUAL.Name = "ENERGIACTUAL";
            ENERGIACTUAL.ReadOnly = true;
            ENERGIACTUAL.Width = 125;
            // 
            // ENERGIAMAX
            // 
            ENERGIAMAX.HeaderText = "Energia Max";
            ENERGIAMAX.MinimumWidth = 6;
            ENERGIAMAX.Name = "ENERGIAMAX";
            ENERGIAMAX.ReadOnly = true;
            ENERGIAMAX.Width = 125;
            // 
            // VIDAACTUAL
            // 
            VIDAACTUAL.HeaderText = "Vida Actual";
            VIDAACTUAL.MinimumWidth = 6;
            VIDAACTUAL.Name = "VIDAACTUAL";
            VIDAACTUAL.ReadOnly = true;
            VIDAACTUAL.Width = 125;
            // 
            // VIDAMAX
            // 
            VIDAMAX.HeaderText = "Vida Max";
            VIDAMAX.MinimumWidth = 6;
            VIDAMAX.Name = "VIDAMAX";
            VIDAMAX.ReadOnly = true;
            VIDAMAX.Width = 125;
            // 
            // PUNTOSATAQUE
            // 
            PUNTOSATAQUE.HeaderText = "Puntos de ataque";
            PUNTOSATAQUE.MinimumWidth = 6;
            PUNTOSATAQUE.Name = "PUNTOSATAQUE";
            PUNTOSATAQUE.ReadOnly = true;
            PUNTOSATAQUE.Width = 125;
            // 
            // PUNTOSDEFENSA
            // 
            PUNTOSDEFENSA.HeaderText = "Puntos de defensa";
            PUNTOSDEFENSA.MinimumWidth = 6;
            PUNTOSDEFENSA.Name = "PUNTOSDEFENSA";
            PUNTOSDEFENSA.ReadOnly = true;
            PUNTOSDEFENSA.Width = 125;
            // 
            // RANGOATAQUE
            // 
            RANGOATAQUE.HeaderText = "Rango de ataque";
            RANGOATAQUE.MinimumWidth = 6;
            RANGOATAQUE.Name = "RANGOATAQUE";
            RANGOATAQUE.ReadOnly = true;
            RANGOATAQUE.Width = 125;
            // 
            // FormCrudEntidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 571);
            Controls.Add(dvEntidades);
            Name = "FormCrudEntidad";
            Text = "FormCrudEntidad";
            ((System.ComponentModel.ISupportInitialize)dvEntidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvEntidades;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn REINO;
        private DataGridViewTextBoxColumn DIETA;
        private DataGridViewTextBoxColumn HABITATS;
        private DataGridViewTextBoxColumn ENERGIACTUAL;
        private DataGridViewTextBoxColumn ENERGIAMAX;
        private DataGridViewTextBoxColumn VIDAACTUAL;
        private DataGridViewTextBoxColumn VIDAMAX;
        private DataGridViewTextBoxColumn PUNTOSATAQUE;
        private DataGridViewTextBoxColumn PUNTOSDEFENSA;
        private DataGridViewTextBoxColumn RANGOATAQUE;
    }
}