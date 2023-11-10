namespace smallworld.vistas.admin.CRUD.ITEMS
{
    partial class FormCrearItems
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
            btn1 = new Button();
            cbbDecoradores = new ComboBox();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            pcbSalir = new PictureBox();
            lbltitulo = new Label();
            pnlForm = new Panel();
            lblDieta = new Label();
            cbbPoder = new ComboBox();
            lblNombre = new Label();
            btnLimpiar = new Button();
            txtNombre = new TextBox();
            btnCrear = new Button();
            lblTexto = new Label();
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
            pnlContenedor.Controls.Add(lblTexto);
            pnlContenedor.Controls.Add(btn1);
            pnlContenedor.Controls.Add(cbbDecoradores);
            pnlContenedor.Controls.Add(pictureBox1);
            pnlContenedor.Controls.Add(btnCancelar);
            pnlContenedor.Controls.Add(pcbSalir);
            pnlContenedor.Controls.Add(lbltitulo);
            pnlContenedor.Controls.Add(pnlForm);
            pnlContenedor.Controls.Add(btnCrear);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(931, 477);
            pnlContenedor.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Bottom;
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(623, 307);
            btn1.Margin = new Padding(10);
            btn1.Name = "btn1";
            btn1.Size = new Size(155, 41);
            btn1.TabIndex = 122;
            btn1.Text = "DECORAR";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // cbbDecoradores
            // 
            cbbDecoradores.FormattingEnabled = true;
            cbbDecoradores.Location = new Point(537, 225);
            cbbDecoradores.Name = "cbbDecoradores";
            cbbDecoradores.Size = new Size(313, 38);
            cbbDecoradores.TabIndex = 121;
            cbbDecoradores.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cerrarX32;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(876, 5);
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
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(495, 407);
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
            pcbSalir.Location = new Point(1192, 5);
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
            lbltitulo.Location = new Point(156, 38);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(213, 62);
            lbltitulo.TabIndex = 94;
            lbltitulo.Text = "CREAR ITEM";
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.BackColor = Color.Transparent;
            pnlForm.Controls.Add(lblDieta);
            pnlForm.Controls.Add(cbbPoder);
            pnlForm.Controls.Add(lblNombre);
            pnlForm.Controls.Add(btnLimpiar);
            pnlForm.Controls.Add(txtNombre);
            pnlForm.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlForm.ForeColor = SystemColors.ActiveBorder;
            pnlForm.Location = new Point(30, 105);
            pnlForm.Margin = new Padding(5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(460, 272);
            pnlForm.TabIndex = 93;
            // 
            // lblDieta
            // 
            lblDieta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDieta.AutoSize = true;
            lblDieta.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblDieta.Location = new Point(38, 120);
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
            cbbPoder.Location = new Point(216, 119);
            cbbPoder.Name = "cbbPoder";
            cbbPoder.Size = new Size(225, 38);
            cbbPoder.TabIndex = 121;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(38, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(105, 32);
            lblNombre.TabIndex = 101;
            lblNombre.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = SystemColors.Desktop;
            btnLimpiar.Location = new Point(142, 202);
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
            txtNombre.Location = new Point(216, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 37);
            txtNombre.TabIndex = 109;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Bottom;
            btnCrear.ForeColor = SystemColors.ActiveCaptionText;
            btnCrear.Location = new Point(264, 407);
            btnCrear.Margin = new Padding(10);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(155, 41);
            btnCrear.TabIndex = 118;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(555, 114);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(0, 31);
            lblTexto.TabIndex = 123;
            // 
            // FormCrearItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 477);
            Controls.Add(pnlContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrearItems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrearItems";
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
        private Label lblDieta;
        private ComboBox cbbPoder;
        private Label lblNombre;
        private Button btnLimpiar;
        private TextBox txtNombre;
        private Button btnCrear;
        private PictureBox pictureBox1;
        private ComboBox cbbDecoradores;
        private Button btn1;
        private Label lblTexto;
    }
}