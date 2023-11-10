namespace smallworld.vistas.admin.CRUD.ITEMS
{
    partial class FormEditarItems
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
            pictureBox2 = new PictureBox();
            btnCancelar = new Button();
            btnActualizar = new Button();
            pictureBox1 = new PictureBox();
            pcbSalir = new PictureBox();
            lbltitulo = new Label();
            pnlForm = new Panel();
            lblId = new Label();
            txtId = new TextBox();
            lblDieta = new Label();
            cbbPoder = new ComboBox();
            lblNombre = new Label();
            btnLimpiar = new Button();
            txtNombre = new TextBox();
            btnCrear = new Button();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackgroundImage = Properties.Resources.fondo;
            pnlContenedor.BorderStyle = BorderStyle.FixedSingle;
            pnlContenedor.Controls.Add(pictureBox2);
            pnlContenedor.Controls.Add(btnCancelar);
            pnlContenedor.Controls.Add(btnActualizar);
            pnlContenedor.Controls.Add(pictureBox1);
            pnlContenedor.Controls.Add(pcbSalir);
            pnlContenedor.Controls.Add(lbltitulo);
            pnlContenedor.Controls.Add(pnlForm);
            pnlContenedor.Controls.Add(btnCrear);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(598, 533);
            pnlContenedor.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.cerrarX32;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(543, 5);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 123;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(340, 465);
            btnCancelar.Margin = new Padding(10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 41);
            btnCancelar.TabIndex = 122;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom;
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(109, 465);
            btnActualizar.Margin = new Padding(10);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(155, 41);
            btnActualizar.TabIndex = 121;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cerrarX32;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(858, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 120;
            pictureBox1.TabStop = false;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.BackColor = Color.Transparent;
            pcbSalir.Image = Properties.Resources.cerrarX32;
            pcbSalir.InitialImage = null;
            pcbSalir.Location = new Point(1174, 5);
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
            lbltitulo.Location = new Point(198, 38);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(222, 62);
            lbltitulo.TabIndex = 94;
            lbltitulo.Text = "EDITAR ITEM";
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.BackColor = Color.Transparent;
            pnlForm.Controls.Add(lblId);
            pnlForm.Controls.Add(txtId);
            pnlForm.Controls.Add(lblDieta);
            pnlForm.Controls.Add(cbbPoder);
            pnlForm.Controls.Add(lblNombre);
            pnlForm.Controls.Add(btnLimpiar);
            pnlForm.Controls.Add(txtNombre);
            pnlForm.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlForm.ForeColor = SystemColors.ActiveBorder;
            pnlForm.Location = new Point(22, 105);
            pnlForm.Margin = new Padding(5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(544, 325);
            pnlForm.TabIndex = 93;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(40, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(36, 32);
            lblId.TabIndex = 129;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveCaptionText;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.ForeColor = Color.DarkGray;
            txtId.Location = new Point(112, 26);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(97, 37);
            txtId.TabIndex = 130;
            // 
            // lblDieta
            // 
            lblDieta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDieta.AutoSize = true;
            lblDieta.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblDieta.Location = new Point(37, 172);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(172, 32);
            lblDieta.TabIndex = 124;
            lblDieta.Text = "Poder del item:";
            // 
            // cbbPoder
            // 
            cbbPoder.BackColor = SystemColors.ActiveCaptionText;
            cbbPoder.DisplayMember = "DIETA";
            cbbPoder.ForeColor = Color.DarkGray;
            cbbPoder.FormattingEnabled = true;
            cbbPoder.Location = new Point(215, 171);
            cbbPoder.Name = "cbbPoder";
            cbbPoder.Size = new Size(317, 38);
            cbbPoder.TabIndex = 121;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(37, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(105, 32);
            lblNombre.TabIndex = 101;
            lblNombre.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom;
            btnLimpiar.ForeColor = SystemColors.Desktop;
            btnLimpiar.Location = new Point(184, 260);
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
            txtNombre.Location = new Point(215, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 37);
            txtNombre.TabIndex = 109;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Bottom;
            btnCrear.ForeColor = SystemColors.ActiveCaptionText;
            btnCrear.Location = new Point(255, 838);
            btnCrear.Margin = new Padding(10);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(155, 41);
            btnCrear.TabIndex = 118;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // FormEditarItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 533);
            Controls.Add(pnlContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarItems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarItems";
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedor;
        private PictureBox pictureBox1;
        private PictureBox pcbSalir;
        private Label lbltitulo;
        private Panel pnlForm;
        private Label lblDieta;
        private ComboBox cbbPoder;
        private Label lblNombre;
        private Button btnLimpiar;
        private TextBox txtNombre;
        private Button btnCrear;
        private Button btnCancelar;
        private Button btnActualizar;
        private Label lblId;
        private TextBox txtId;
        private PictureBox pictureBox2;
    }
}