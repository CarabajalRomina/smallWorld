namespace smallworld.vistas.admin.interactuables
{
    partial class FormCRUDItems
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
            dgvItem = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            ESTRATEGIA = new DataGridViewTextBoxColumn();
            pnlBtnCRUD = new Panel();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            pnlContenedor = new Panel();
            lbltitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            pnlBtnCRUD.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItem
            // 
            dgvItem.AllowUserToAddRows = false;
            dgvItem.AllowUserToDeleteRows = false;
            dgvItem.AllowUserToResizeColumns = false;
            dgvItem.AllowUserToResizeRows = false;
            dgvItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItem.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, ESTRATEGIA });
            dgvItem.Location = new Point(3, 0);
            dgvItem.Name = "dgvItem";
            dgvItem.ReadOnly = true;
            dgvItem.RowHeadersVisible = false;
            dgvItem.RowHeadersWidth = 51;
            dgvItem.RowTemplate.Height = 29;
            dgvItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItem.Size = new Size(715, 479);
            dgvItem.TabIndex = 11;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // ESTRATEGIA
            // 
            ESTRATEGIA.HeaderText = "PODER DEL ITEM";
            ESTRATEGIA.MinimumWidth = 6;
            ESTRATEGIA.Name = "ESTRATEGIA";
            ESTRATEGIA.ReadOnly = true;
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
            pnlBtnCRUD.Location = new Point(0, 625);
            pnlBtnCRUD.Margin = new Padding(3, 20, 3, 3);
            pnlBtnCRUD.Name = "pnlBtnCRUD";
            pnlBtnCRUD.Size = new Size(720, 74);
            pnlBtnCRUD.TabIndex = 89;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(505, 19);
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
            btnCrear.Location = new Point(49, 19);
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
            btnEditar.Location = new Point(275, 19);
            btnEditar.Margin = new Padding(10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 41);
            btnEditar.TabIndex = 119;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.AutoSize = true;
            pnlContenedor.BackColor = Color.Transparent;
            pnlContenedor.Controls.Add(dgvItem);
            pnlContenedor.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenedor.Location = new Point(1, 87);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(719, 501);
            pnlContenedor.TabIndex = 91;
            // 
            // lbltitulo
            // 
            lbltitulo.Anchor = AnchorStyles.Top;
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Sweet Pea", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.WhiteSmoke;
            lbltitulo.Location = new Point(252, 14);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(198, 62);
            lbltitulo.TabIndex = 121;
            lbltitulo.Text = "CRUD ITEM";
            // 
            // FormCRUDItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(720, 699);
            Controls.Add(lbltitulo);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlBtnCRUD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCRUDItems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCRUDItems";
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            pnlBtnCRUD.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvItem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn ESTRATEGIA;
        private Panel pnlBtnCRUD;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnEditar;
        private Panel pnlContenedor;
        private Label lbltitulo;
    }
}