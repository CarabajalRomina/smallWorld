namespace smallworld.vistas.admin.CRUD.COMIDA
{
    partial class FormEditarComida
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
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            pcbSalir = new PictureBox();
            lbltitulo = new Label();
            pnlForm = new Panel();
            lblId = new Label();
            txtId = new TextBox();
            lblCalorias = new Label();
            txtCalorias = new TextBox();
            lblDieta = new Label();
            cbbDieta = new ComboBox();
            lblNombre = new Label();
            btnLimpiar = new Button();
            txtNombre = new TextBox();
            btnActualizar = new Button();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackgroundImage = Properties.Resources.fondo;
            pnlContenedor.BorderStyle = BorderStyle.FixedSingle;
            pnlContenedor.Controls.Add(pictureBox1);
            pnlContenedor.Controls.Add(btnCancelar);
            pnlContenedor.Controls.Add(pcbSalir);
            pnlContenedor.Controls.Add(lbltitulo);
            pnlContenedor.Controls.Add(pnlForm);
            pnlContenedor.Controls.Add(btnActualizar);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(537, 604);
            pnlContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cerrarX32;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(482, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 120;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(304, 543);
            btnCancelar.Margin = new Padding(10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 41);
            btnCancelar.TabIndex = 119;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.BackColor = Color.Transparent;
            pcbSalir.Image = Properties.Resources.cerrarX32;
            pcbSalir.InitialImage = null;
            pcbSalir.Location = new Point(798, -1);
            pcbSalir.Margin = new Padding(5);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(48, 50);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 95;
            pcbSalir.TabStop = false;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Sweet Pea", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.WhiteSmoke;
            lbltitulo.Location = new Point(125, 38);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(269, 62);
            lbltitulo.TabIndex = 94;
            lbltitulo.Text = "EDITAR COMIDA";
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.BackColor = Color.Transparent;
            pnlForm.Controls.Add(lblId);
            pnlForm.Controls.Add(txtId);
            pnlForm.Controls.Add(lblCalorias);
            pnlForm.Controls.Add(txtCalorias);
            pnlForm.Controls.Add(lblDieta);
            pnlForm.Controls.Add(cbbDieta);
            pnlForm.Controls.Add(lblNombre);
            pnlForm.Controls.Add(btnLimpiar);
            pnlForm.Controls.Add(txtNombre);
            pnlForm.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlForm.ForeColor = SystemColors.ActiveBorder;
            pnlForm.Location = new Point(35, 105);
            pnlForm.Margin = new Padding(5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(463, 410);
            pnlForm.TabIndex = 93;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(40, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(36, 32);
            lblId.TabIndex = 127;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveCaptionText;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.ForeColor = Color.DarkGray;
            txtId.Location = new Point(96, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(97, 37);
            txtId.TabIndex = 128;
            // 
            // lblCalorias
            // 
            lblCalorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCalorias.AutoSize = true;
            lblCalorias.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalorias.Location = new Point(40, 181);
            lblCalorias.Name = "lblCalorias";
            lblCalorias.Size = new Size(104, 32);
            lblCalorias.TabIndex = 125;
            lblCalorias.Text = "Calorias:";
            // 
            // txtCalorias
            // 
            txtCalorias.BackColor = SystemColors.ActiveCaptionText;
            txtCalorias.BorderStyle = BorderStyle.FixedSingle;
            txtCalorias.ForeColor = Color.DarkGray;
            txtCalorias.Location = new Point(203, 180);
            txtCalorias.Name = "txtCalorias";
            txtCalorias.Size = new Size(225, 37);
            txtCalorias.TabIndex = 126;
            // 
            // lblDieta
            // 
            lblDieta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDieta.AutoSize = true;
            lblDieta.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblDieta.Location = new Point(38, 260);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(155, 32);
            lblDieta.TabIndex = 124;
            lblDieta.Text = "Tipo de dieta:";
            // 
            // cbbDieta
            // 
            cbbDieta.BackColor = SystemColors.ActiveCaptionText;
            cbbDieta.DisplayMember = "DIETA";
            cbbDieta.ForeColor = Color.DarkGray;
            cbbDieta.FormattingEnabled = true;
            cbbDieta.Location = new Point(203, 258);
            cbbDieta.Name = "cbbDieta";
            cbbDieta.Size = new Size(225, 38);
            cbbDieta.TabIndex = 121;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(38, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(105, 32);
            lblNombre.TabIndex = 101;
            lblNombre.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = SystemColors.Desktop;
            btnLimpiar.Location = new Point(136, 336);
            btnLimpiar.Margin = new Padding(10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(166, 41);
            btnLimpiar.TabIndex = 120;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ActiveCaptionText;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.DarkGray;
            txtNombre.Location = new Point(203, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 37);
            txtNombre.TabIndex = 109;
            // 
            // btnActualizar
            // 
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(73, 543);
            btnActualizar.Margin = new Padding(10);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(155, 41);
            btnActualizar.TabIndex = 118;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormEditarComida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 604);
            Controls.Add(pnlContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarComida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarComida";
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedor;
        private Button btnCancelar;
        private PictureBox pcbSalir;
        private Label lbltitulo;
        private Panel pnlForm;
        private Label lblId;
        private TextBox txtId;
        private Label lblCalorias;
        private TextBox txtCalorias;
        private Label lblDieta;
        private ComboBox cbbDieta;
        private Label lblNombre;
        private Button btnLimpiar;
        private TextBox txtNombre;
        private Button btnActualizar;
        private PictureBox pictureBox1;
    }
}