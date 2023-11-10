namespace smallworld.vistas.admin.interactuables
{
    partial class FormCRUDComida
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
            lbltitulo = new Label();
            pnlBtnCRUD = new Panel();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            dgvComidas = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            CALORIAS = new DataGridViewTextBoxColumn();
            TIPODIETA = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pnlBtnCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComidas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.Anchor = AnchorStyles.Top;
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Sweet Pea", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.WhiteSmoke;
            lbltitulo.Location = new Point(214, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(245, 62);
            lbltitulo.TabIndex = 51;
            lbltitulo.Text = "CRUD COMIDA";
            // 
            // pnlBtnCRUD
            // 
            pnlBtnCRUD.AutoSize = true;
            pnlBtnCRUD.BackgroundImage = Properties.Resources.fondo;
            pnlBtnCRUD.BorderStyle = BorderStyle.Fixed3D;
            pnlBtnCRUD.Controls.Add(btnEliminar);
            pnlBtnCRUD.Controls.Add(btnCrear);
            pnlBtnCRUD.Controls.Add(btnEditar);
            pnlBtnCRUD.Dock = DockStyle.Bottom;
            pnlBtnCRUD.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBtnCRUD.Location = new Point(0, 513);
            pnlBtnCRUD.Margin = new Padding(3, 20, 3, 3);
            pnlBtnCRUD.Name = "pnlBtnCRUD";
            pnlBtnCRUD.Size = new Size(699, 65);
            pnlBtnCRUD.TabIndex = 88;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(472, 10);
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
            btnCrear.Location = new Point(55, 10);
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
            btnEditar.Location = new Point(258, 10);
            btnEditar.Margin = new Padding(10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 41);
            btnEditar.TabIndex = 119;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvComidas
            // 
            dgvComidas.AccessibleName = "dgvComidas";
            dgvComidas.AllowUserToAddRows = false;
            dgvComidas.AllowUserToDeleteRows = false;
            dgvComidas.AllowUserToResizeColumns = false;
            dgvComidas.AllowUserToResizeRows = false;
            dgvComidas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvComidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComidas.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvComidas.BorderStyle = BorderStyle.None;
            dgvComidas.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvComidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComidas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, CALORIAS, TIPODIETA });
            dgvComidas.Location = new Point(0, 12);
            dgvComidas.Name = "dgvComidas";
            dgvComidas.ReadOnly = true;
            dgvComidas.RowHeadersVisible = false;
            dgvComidas.RowHeadersWidth = 51;
            dgvComidas.RowTemplate.Height = 29;
            dgvComidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComidas.Size = new Size(696, 423);
            dgvComidas.TabIndex = 87;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CALORIAS
            // 
            CALORIAS.HeaderText = "CALORIAS";
            CALORIAS.MinimumWidth = 6;
            CALORIAS.Name = "CALORIAS";
            CALORIAS.ReadOnly = true;
            // 
            // TIPODIETA
            // 
            TIPODIETA.HeaderText = "TIPO DE DIETA";
            TIPODIETA.MinimumWidth = 6;
            TIPODIETA.Name = "TIPODIETA";
            TIPODIETA.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(dgvComidas);
            panel1.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 450);
            panel1.TabIndex = 90;
            // 
            // FormCRUDComida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(699, 578);
            Controls.Add(panel1);
            Controls.Add(pnlBtnCRUD);
            Controls.Add(lbltitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCRUDComida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCRUDComida";
            WindowState = FormWindowState.Maximized;
            pnlBtnCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComidas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDieta;
        private Label lbltitulo;
        private Label lblID;
        private Panel pnlBtnCRUD;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnEditar;
        private DataGridView dgvComidas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn CALORIAS;
        private DataGridViewTextBoxColumn TIPODIETA;
        private Panel panel1;
    }
}