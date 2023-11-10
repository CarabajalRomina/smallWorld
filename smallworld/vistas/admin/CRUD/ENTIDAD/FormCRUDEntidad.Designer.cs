namespace smallworld.vistas.admin
{
    partial class FormCRUDEntidad
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
            pnlContenedor = new Panel();
            dgvEntidades = new DataGridView();
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
            pnlBtnCRUD = new Panel();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            lblTituloEntidad = new Label();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntidades).BeginInit();
            pnlBtnCRUD.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.AutoSize = true;
            pnlContenedor.BackColor = Color.Transparent;
            pnlContenedor.Controls.Add(dgvEntidades);
            pnlContenedor.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenedor.ForeColor = SystemColors.ActiveBorder;
            pnlContenedor.Location = new Point(25, 110);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1043, 532);
            pnlContenedor.TabIndex = 81;
            // 
            // dgvEntidades
            // 
            dgvEntidades.AccessibleName = "dgvEntidades";
            dgvEntidades.AllowUserToAddRows = false;
            dgvEntidades.AllowUserToDeleteRows = false;
            dgvEntidades.AllowUserToResizeColumns = false;
            dgvEntidades.AllowUserToResizeRows = false;
            dgvEntidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEntidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEntidades.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvEntidades.BorderStyle = BorderStyle.None;
            dgvEntidades.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvEntidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntidades.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, REINO, DIETA, HABITATS, ENERGIACTUAL, ENERGIAMAX, VIDAACTUAL, VIDAMAX, PUNTOSATAQUE, PUNTOSDEFENSA, RANGOATAQUE });
            dgvEntidades.Location = new Point(0, 3);
            dgvEntidades.Name = "dgvEntidades";
            dgvEntidades.ReadOnly = true;
            dgvEntidades.RowHeadersVisible = false;
            dgvEntidades.RowHeadersWidth = 51;
            dgvEntidades.RowTemplate.Height = 29;
            dgvEntidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntidades.Size = new Size(1033, 507);
            dgvEntidades.TabIndex = 86;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 60;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "Nombre";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            NOMBRE.Width = 126;
            // 
            // REINO
            // 
            REINO.HeaderText = "Reino";
            REINO.MinimumWidth = 6;
            REINO.Name = "REINO";
            REINO.ReadOnly = true;
            REINO.Width = 95;
            // 
            // DIETA
            // 
            DIETA.HeaderText = "Dieta";
            DIETA.MinimumWidth = 6;
            DIETA.Name = "DIETA";
            DIETA.ReadOnly = true;
            DIETA.Width = 91;
            // 
            // HABITATS
            // 
            HABITATS.HeaderText = "Habitat";
            HABITATS.MinimumWidth = 6;
            HABITATS.Name = "HABITATS";
            HABITATS.ReadOnly = true;
            HABITATS.Width = 114;
            // 
            // ENERGIACTUAL
            // 
            ENERGIACTUAL.HeaderText = "Energia actual";
            ENERGIACTUAL.MinimumWidth = 6;
            ENERGIACTUAL.Name = "ENERGIACTUAL";
            ENERGIACTUAL.ReadOnly = true;
            ENERGIACTUAL.Width = 171;
            // 
            // ENERGIAMAX
            // 
            ENERGIAMAX.HeaderText = "Energia max";
            ENERGIAMAX.MinimumWidth = 6;
            ENERGIAMAX.Name = "ENERGIAMAX";
            ENERGIAMAX.ReadOnly = true;
            ENERGIAMAX.Width = 155;
            // 
            // VIDAACTUAL
            // 
            VIDAACTUAL.HeaderText = "Vida actual";
            VIDAACTUAL.MinimumWidth = 6;
            VIDAACTUAL.Name = "VIDAACTUAL";
            VIDAACTUAL.ReadOnly = true;
            VIDAACTUAL.Width = 144;
            // 
            // VIDAMAX
            // 
            VIDAMAX.HeaderText = "Vida max";
            VIDAMAX.MinimumWidth = 6;
            VIDAMAX.Name = "VIDAMAX";
            VIDAMAX.ReadOnly = true;
            VIDAMAX.Width = 128;
            // 
            // PUNTOSATAQUE
            // 
            PUNTOSATAQUE.HeaderText = "Puntos de ataque";
            PUNTOSATAQUE.MinimumWidth = 6;
            PUNTOSATAQUE.Name = "PUNTOSATAQUE";
            PUNTOSATAQUE.ReadOnly = true;
            PUNTOSATAQUE.Width = 196;
            // 
            // PUNTOSDEFENSA
            // 
            PUNTOSDEFENSA.HeaderText = "Puntos de defensa";
            PUNTOSDEFENSA.MinimumWidth = 6;
            PUNTOSDEFENSA.Name = "PUNTOSDEFENSA";
            PUNTOSDEFENSA.ReadOnly = true;
            PUNTOSDEFENSA.Width = 205;
            // 
            // RANGOATAQUE
            // 
            RANGOATAQUE.HeaderText = "Rango de ataque";
            RANGOATAQUE.MinimumWidth = 6;
            RANGOATAQUE.Name = "RANGOATAQUE";
            RANGOATAQUE.ReadOnly = true;
            RANGOATAQUE.Width = 194;
            // 
            // pnlBtnCRUD
            // 
            pnlBtnCRUD.AutoSize = true;
            pnlBtnCRUD.BackColor = Color.Transparent;
            pnlBtnCRUD.BorderStyle = BorderStyle.Fixed3D;
            pnlBtnCRUD.Controls.Add(btnEliminar);
            pnlBtnCRUD.Controls.Add(btnCrear);
            pnlBtnCRUD.Controls.Add(btnEditar);
            pnlBtnCRUD.Dock = DockStyle.Bottom;
            pnlBtnCRUD.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBtnCRUD.Location = new Point(0, 696);
            pnlBtnCRUD.Margin = new Padding(3, 20, 3, 3);
            pnlBtnCRUD.Name = "pnlBtnCRUD";
            pnlBtnCRUD.Size = new Size(1080, 69);
            pnlBtnCRUD.TabIndex = 87;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(677, 14);
            btnEliminar.Margin = new Padding(10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 41);
            btnEliminar.TabIndex = 121;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Top;
            btnCrear.ForeColor = SystemColors.ActiveCaptionText;
            btnCrear.Location = new Point(204, 14);
            btnCrear.Margin = new Padding(10);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(155, 41);
            btnCrear.TabIndex = 120;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(441, 14);
            btnEditar.Margin = new Padding(10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 41);
            btnEditar.TabIndex = 119;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblTituloEntidad
            // 
            lblTituloEntidad.Anchor = AnchorStyles.Top;
            lblTituloEntidad.AutoSize = true;
            lblTituloEntidad.BackColor = Color.Transparent;
            lblTituloEntidad.Font = new Font("Sweet Pea", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloEntidad.ForeColor = SystemColors.ButtonHighlight;
            lblTituloEntidad.Location = new Point(408, 24);
            lblTituloEntidad.Name = "lblTituloEntidad";
            lblTituloEntidad.Size = new Size(287, 62);
            lblTituloEntidad.TabIndex = 82;
            lblTituloEntidad.Text = "CRUD ENTIDADES";
            // 
            // FormCRUDEntidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(1080, 765);
            Controls.Add(pnlBtnCRUD);
            Controls.Add(lblTituloEntidad);
            Controls.Add(pnlContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCRUDEntidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrudInteractuables";
            WindowState = FormWindowState.Maximized;
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEntidades).EndInit();
            pnlBtnCRUD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlContenedor;
        private DataGridView dgvEntidades;
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
        private Panel pnlBtnCRUD;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnEditar;
        private Label lblTituloEntidad;
    }
}