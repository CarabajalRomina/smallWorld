namespace smallworld.vistas.admin.CRUD.ENTIDAD
{
    partial class FormEditarEntidad
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
            panel1 = new Panel();
            pcbSalir = new PictureBox();
            lbltitulo = new Label();
            btnCancelar = new Button();
            pnlForm = new Panel();
            lblId = new Label();
            txtId = new TextBox();
            cbbHabitats = new ComboBox();
            lblNombre = new Label();
            btnLimpiar = new Button();
            lblReino = new Label();
            lblDieta = new Label();
            lblHabitat = new Label();
            lblEnergiaMaxima = new Label();
            lblVidaMaxima = new Label();
            lblPuntosAtaque = new Label();
            lblPuntosDefensa = new Label();
            spnRangoAtaque = new NumericUpDown();
            txtNombre = new TextBox();
            lblRangoAtaque = new Label();
            cbbReino = new ComboBox();
            spnEnergiaMax = new NumericUpDown();
            cbbDieta = new ComboBox();
            spnPuntosDefensa = new NumericUpDown();
            spnPuntosAtaque = new NumericUpDown();
            spnVidaMax = new NumericUpDown();
            btnEditar = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnRangoAtaque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnEnergiaMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnPuntosDefensa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnPuntosAtaque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnVidaMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fondo;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pcbSalir);
            panel1.Controls.Add(lbltitulo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pnlForm);
            panel1.Controls.Add(btnEditar);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 889);
            panel1.TabIndex = 1;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.BackColor = Color.Transparent;
            pcbSalir.Image = Properties.Resources.cerrarX32;
            pcbSalir.InitialImage = null;
            pcbSalir.Location = new Point(704, 5);
            pcbSalir.Margin = new Padding(5);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(48, 50);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 121;
            pcbSalir.TabStop = false;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Sweet Pea", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.WhiteSmoke;
            lbltitulo.Location = new Point(112, 29);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(276, 62);
            lbltitulo.TabIndex = 120;
            lbltitulo.Text = "EDITAR ENTIDAD";
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(270, 821);
            btnCancelar.Margin = new Padding(10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 41);
            btnCancelar.TabIndex = 119;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.BackColor = Color.Transparent;
            pnlForm.Controls.Add(lblId);
            pnlForm.Controls.Add(txtId);
            pnlForm.Controls.Add(cbbHabitats);
            pnlForm.Controls.Add(lblNombre);
            pnlForm.Controls.Add(btnLimpiar);
            pnlForm.Controls.Add(lblReino);
            pnlForm.Controls.Add(lblDieta);
            pnlForm.Controls.Add(lblHabitat);
            pnlForm.Controls.Add(lblEnergiaMaxima);
            pnlForm.Controls.Add(lblVidaMaxima);
            pnlForm.Controls.Add(lblPuntosAtaque);
            pnlForm.Controls.Add(lblPuntosDefensa);
            pnlForm.Controls.Add(spnRangoAtaque);
            pnlForm.Controls.Add(txtNombre);
            pnlForm.Controls.Add(lblRangoAtaque);
            pnlForm.Controls.Add(cbbReino);
            pnlForm.Controls.Add(spnEnergiaMax);
            pnlForm.Controls.Add(cbbDieta);
            pnlForm.Controls.Add(spnPuntosDefensa);
            pnlForm.Controls.Add(spnPuntosAtaque);
            pnlForm.Controls.Add(spnVidaMax);
            pnlForm.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlForm.ForeColor = SystemColors.ActiveBorder;
            pnlForm.Location = new Point(32, 96);
            pnlForm.Margin = new Padding(5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(412, 688);
            pnlForm.TabIndex = 81;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Location = new Point(43, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 31);
            lblId.TabIndex = 122;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveCaptionText;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.ForeColor = Color.DarkGray;
            txtId.Location = new Point(82, 18);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(107, 37);
            txtId.TabIndex = 123;
            // 
            // cbbHabitats
            // 
            cbbHabitats.BackColor = SystemColors.ActiveCaptionText;
            cbbHabitats.DisplayMember = "DIETA";
            cbbHabitats.ForeColor = Color.DarkGray;
            cbbHabitats.FormattingEnabled = true;
            cbbHabitats.Location = new Point(148, 251);
            cbbHabitats.Name = "cbbHabitats";
            cbbHabitats.Size = new Size(234, 38);
            cbbHabitats.TabIndex = 121;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(43, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 31);
            lblNombre.TabIndex = 101;
            lblNombre.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = SystemColors.Desktop;
            btnLimpiar.Location = new Point(114, 619);
            btnLimpiar.Margin = new Padding(10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(166, 41);
            btnLimpiar.TabIndex = 120;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblReino
            // 
            lblReino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblReino.AutoSize = true;
            lblReino.Location = new Point(43, 135);
            lblReino.Name = "lblReino";
            lblReino.Size = new Size(68, 31);
            lblReino.TabIndex = 102;
            lblReino.Text = "Reino:";
            // 
            // lblDieta
            // 
            lblDieta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDieta.AutoSize = true;
            lblDieta.Location = new Point(43, 195);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(64, 31);
            lblDieta.TabIndex = 103;
            lblDieta.Text = "Dieta:";
            // 
            // lblHabitat
            // 
            lblHabitat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHabitat.AutoSize = true;
            lblHabitat.Location = new Point(43, 254);
            lblHabitat.Name = "lblHabitat";
            lblHabitat.Size = new Size(86, 31);
            lblHabitat.TabIndex = 104;
            lblHabitat.Text = "Habitat:";
            // 
            // lblEnergiaMaxima
            // 
            lblEnergiaMaxima.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEnergiaMaxima.AutoSize = true;
            lblEnergiaMaxima.Location = new Point(43, 324);
            lblEnergiaMaxima.Name = "lblEnergiaMaxima";
            lblEnergiaMaxima.Size = new Size(180, 31);
            lblEnergiaMaxima.TabIndex = 105;
            lblEnergiaMaxima.Text = "Energia maxima:";
            // 
            // lblVidaMaxima
            // 
            lblVidaMaxima.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVidaMaxima.AutoSize = true;
            lblVidaMaxima.Location = new Point(43, 384);
            lblVidaMaxima.Name = "lblVidaMaxima";
            lblVidaMaxima.Size = new Size(150, 31);
            lblVidaMaxima.TabIndex = 106;
            lblVidaMaxima.Text = "Vida maxima:";
            // 
            // lblPuntosAtaque
            // 
            lblPuntosAtaque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPuntosAtaque.AutoSize = true;
            lblPuntosAtaque.Location = new Point(43, 443);
            lblPuntosAtaque.Name = "lblPuntosAtaque";
            lblPuntosAtaque.Size = new Size(188, 31);
            lblPuntosAtaque.TabIndex = 107;
            lblPuntosAtaque.Text = "Puntos de ataque:";
            // 
            // lblPuntosDefensa
            // 
            lblPuntosDefensa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPuntosDefensa.AutoSize = true;
            lblPuntosDefensa.Location = new Point(33, 503);
            lblPuntosDefensa.Name = "lblPuntosDefensa";
            lblPuntosDefensa.Size = new Size(198, 31);
            lblPuntosDefensa.TabIndex = 108;
            lblPuntosDefensa.Text = "Puntos de defensa:";
            // 
            // spnRangoAtaque
            // 
            spnRangoAtaque.BackColor = SystemColors.ActiveCaptionText;
            spnRangoAtaque.ForeColor = Color.DarkGray;
            spnRangoAtaque.Location = new Point(243, 554);
            spnRangoAtaque.Name = "spnRangoAtaque";
            spnRangoAtaque.Size = new Size(139, 37);
            spnRangoAtaque.TabIndex = 117;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ActiveCaptionText;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.DarkGray;
            txtNombre.Location = new Point(150, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 37);
            txtNombre.TabIndex = 109;
            // 
            // lblRangoAtaque
            // 
            lblRangoAtaque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRangoAtaque.AutoSize = true;
            lblRangoAtaque.Location = new Point(37, 556);
            lblRangoAtaque.Name = "lblRangoAtaque";
            lblRangoAtaque.Size = new Size(186, 31);
            lblRangoAtaque.TabIndex = 116;
            lblRangoAtaque.Text = "Rango de ataque:";
            // 
            // cbbReino
            // 
            cbbReino.BackColor = SystemColors.ActiveCaptionText;
            cbbReino.DisplayMember = "REINO";
            cbbReino.ForeColor = Color.DarkGray;
            cbbReino.FormattingEnabled = true;
            cbbReino.Location = new Point(150, 132);
            cbbReino.Name = "cbbReino";
            cbbReino.Size = new Size(232, 38);
            cbbReino.TabIndex = 110;
            // 
            // spnEnergiaMax
            // 
            spnEnergiaMax.BackColor = SystemColors.ActiveCaptionText;
            spnEnergiaMax.ForeColor = Color.DarkGray;
            spnEnergiaMax.Location = new Point(243, 322);
            spnEnergiaMax.Name = "spnEnergiaMax";
            spnEnergiaMax.Size = new Size(139, 37);
            spnEnergiaMax.TabIndex = 115;
            // 
            // cbbDieta
            // 
            cbbDieta.BackColor = SystemColors.ActiveCaptionText;
            cbbDieta.DisplayMember = "DIETA";
            cbbDieta.ForeColor = Color.DarkGray;
            cbbDieta.FormattingEnabled = true;
            cbbDieta.Location = new Point(149, 192);
            cbbDieta.Name = "cbbDieta";
            cbbDieta.Size = new Size(233, 38);
            cbbDieta.TabIndex = 111;
            // 
            // spnPuntosDefensa
            // 
            spnPuntosDefensa.BackColor = SystemColors.ActiveCaptionText;
            spnPuntosDefensa.ForeColor = Color.DarkGray;
            spnPuntosDefensa.Location = new Point(243, 501);
            spnPuntosDefensa.Name = "spnPuntosDefensa";
            spnPuntosDefensa.Size = new Size(139, 37);
            spnPuntosDefensa.TabIndex = 114;
            // 
            // spnPuntosAtaque
            // 
            spnPuntosAtaque.BackColor = SystemColors.ActiveCaptionText;
            spnPuntosAtaque.ForeColor = Color.DarkGray;
            spnPuntosAtaque.Location = new Point(243, 441);
            spnPuntosAtaque.Name = "spnPuntosAtaque";
            spnPuntosAtaque.Size = new Size(139, 37);
            spnPuntosAtaque.TabIndex = 112;
            // 
            // spnVidaMax
            // 
            spnVidaMax.BackColor = SystemColors.ActiveCaptionText;
            spnVidaMax.ForeColor = Color.DarkGray;
            spnVidaMax.Location = new Point(243, 382);
            spnVidaMax.Name = "spnVidaMax";
            spnVidaMax.Size = new Size(139, 37);
            spnVidaMax.TabIndex = 113;
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(48, 821);
            btnEditar.Margin = new Padding(10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(162, 41);
            btnEditar.TabIndex = 118;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cerrarX32;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(419, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 122;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormEditarEntidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 889);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarEntidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarEntidad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spnRangoAtaque).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnEnergiaMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnPuntosDefensa).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnPuntosAtaque).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnVidaMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pcbSalir;
        private Label lbltitulo;
        private Button btnCancelar;
        private Panel pnlForm;
        private Label lblId;
        private TextBox txtId;
        private ComboBox cbbHabitats;
        private Label lblNombre;
        private Button btnLimpiar;
        private Label lblReino;
        private Label lblDieta;
        private Label lblHabitat;
        private Label lblEnergiaMaxima;
        private Label lblVidaMaxima;
        private Label lblPuntosAtaque;
        private Label lblPuntosDefensa;
        private NumericUpDown spnRangoAtaque;
        private TextBox txtNombre;
        private Label lblRangoAtaque;
        private ComboBox cbbReino;
        private NumericUpDown spnEnergiaMax;
        private ComboBox cbbDieta;
        private NumericUpDown spnPuntosDefensa;
        private NumericUpDown spnPuntosAtaque;
        private NumericUpDown spnVidaMax;
        private Button btnEditar;
        private PictureBox pictureBox1;
    }
}