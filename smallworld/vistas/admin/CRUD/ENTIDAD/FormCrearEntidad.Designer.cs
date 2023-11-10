namespace smallworld.vistas.admin.CRUD.ENTIDAD
{
    partial class FormCrearEntidad
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
            btnCrear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnRangoAtaque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnEnergiaMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnPuntosDefensa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnPuntosAtaque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnVidaMax).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fondo;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pcbSalir);
            panel1.Controls.Add(lbltitulo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pnlForm);
            panel1.Controls.Add(btnCrear);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 840);
            panel1.TabIndex = 0;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.BackColor = Color.Transparent;
            pcbSalir.Image = Properties.Resources.cerrarX32;
            pcbSalir.InitialImage = null;
            pcbSalir.Location = new Point(430, 5);
            pcbSalir.Margin = new Padding(5);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(48, 50);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 121;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Sweet Pea", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.WhiteSmoke;
            lbltitulo.Location = new Point(115, 56);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(267, 62);
            lbltitulo.TabIndex = 120;
            lbltitulo.Text = "CREAR ENTIDAD";
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(271, 783);
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
            pnlForm.Location = new Point(31, 139);
            pnlForm.Margin = new Padding(5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(412, 629);
            pnlForm.TabIndex = 81;
            // 
            // cbbHabitats
            // 
            cbbHabitats.BackColor = SystemColors.ActiveCaptionText;
            cbbHabitats.DisplayMember = "DIETA";
            cbbHabitats.ForeColor = Color.DarkGray;
            cbbHabitats.FormattingEnabled = true;
            cbbHabitats.Location = new Point(133, 214);
            cbbHabitats.Name = "cbbHabitats";
            cbbHabitats.Size = new Size(225, 38);
            cbbHabitats.TabIndex = 121;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 31);
            lblNombre.TabIndex = 101;
            lblNombre.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = SystemColors.Desktop;
            btnLimpiar.Location = new Point(115, 578);
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
            lblReino.Location = new Point(28, 98);
            lblReino.Name = "lblReino";
            lblReino.Size = new Size(68, 31);
            lblReino.TabIndex = 102;
            lblReino.Text = "Reino:";
            // 
            // lblDieta
            // 
            lblDieta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDieta.AutoSize = true;
            lblDieta.Location = new Point(28, 158);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(64, 31);
            lblDieta.TabIndex = 103;
            lblDieta.Text = "Dieta:";
            // 
            // lblHabitat
            // 
            lblHabitat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHabitat.AutoSize = true;
            lblHabitat.Location = new Point(28, 217);
            lblHabitat.Name = "lblHabitat";
            lblHabitat.Size = new Size(86, 31);
            lblHabitat.TabIndex = 104;
            lblHabitat.Text = "Habitat:";
            // 
            // lblEnergiaMaxima
            // 
            lblEnergiaMaxima.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEnergiaMaxima.AutoSize = true;
            lblEnergiaMaxima.Location = new Point(28, 287);
            lblEnergiaMaxima.Name = "lblEnergiaMaxima";
            lblEnergiaMaxima.Size = new Size(180, 31);
            lblEnergiaMaxima.TabIndex = 105;
            lblEnergiaMaxima.Text = "Energia maxima:";
            // 
            // lblVidaMaxima
            // 
            lblVidaMaxima.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVidaMaxima.AutoSize = true;
            lblVidaMaxima.Location = new Point(28, 347);
            lblVidaMaxima.Name = "lblVidaMaxima";
            lblVidaMaxima.Size = new Size(150, 31);
            lblVidaMaxima.TabIndex = 106;
            lblVidaMaxima.Text = "Vida maxima:";
            // 
            // lblPuntosAtaque
            // 
            lblPuntosAtaque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPuntosAtaque.AutoSize = true;
            lblPuntosAtaque.Location = new Point(28, 406);
            lblPuntosAtaque.Name = "lblPuntosAtaque";
            lblPuntosAtaque.Size = new Size(188, 31);
            lblPuntosAtaque.TabIndex = 107;
            lblPuntosAtaque.Text = "Puntos de ataque:";
            // 
            // lblPuntosDefensa
            // 
            lblPuntosDefensa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPuntosDefensa.AutoSize = true;
            lblPuntosDefensa.Location = new Point(18, 466);
            lblPuntosDefensa.Name = "lblPuntosDefensa";
            lblPuntosDefensa.Size = new Size(198, 31);
            lblPuntosDefensa.TabIndex = 108;
            lblPuntosDefensa.Text = "Puntos de defensa:";
            // 
            // spnRangoAtaque
            // 
            spnRangoAtaque.BackColor = SystemColors.ActiveCaptionText;
            spnRangoAtaque.ForeColor = Color.DarkGray;
            spnRangoAtaque.Location = new Point(228, 517);
            spnRangoAtaque.Name = "spnRangoAtaque";
            spnRangoAtaque.Size = new Size(139, 37);
            spnRangoAtaque.TabIndex = 117;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ActiveCaptionText;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.DarkGray;
            txtNombre.Location = new Point(135, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 37);
            txtNombre.TabIndex = 109;
            // 
            // lblRangoAtaque
            // 
            lblRangoAtaque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRangoAtaque.AutoSize = true;
            lblRangoAtaque.Location = new Point(22, 519);
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
            cbbReino.Location = new Point(135, 95);
            cbbReino.Name = "cbbReino";
            cbbReino.Size = new Size(226, 38);
            cbbReino.TabIndex = 110;
            // 
            // spnEnergiaMax
            // 
            spnEnergiaMax.BackColor = SystemColors.ActiveCaptionText;
            spnEnergiaMax.ForeColor = Color.DarkGray;
            spnEnergiaMax.Location = new Point(228, 285);
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
            cbbDieta.Location = new Point(134, 155);
            cbbDieta.Name = "cbbDieta";
            cbbDieta.Size = new Size(225, 38);
            cbbDieta.TabIndex = 111;
            // 
            // spnPuntosDefensa
            // 
            spnPuntosDefensa.BackColor = SystemColors.ActiveCaptionText;
            spnPuntosDefensa.ForeColor = Color.DarkGray;
            spnPuntosDefensa.Location = new Point(228, 464);
            spnPuntosDefensa.Name = "spnPuntosDefensa";
            spnPuntosDefensa.Size = new Size(139, 37);
            spnPuntosDefensa.TabIndex = 114;
            // 
            // spnPuntosAtaque
            // 
            spnPuntosAtaque.BackColor = SystemColors.ActiveCaptionText;
            spnPuntosAtaque.ForeColor = Color.DarkGray;
            spnPuntosAtaque.Location = new Point(228, 404);
            spnPuntosAtaque.Name = "spnPuntosAtaque";
            spnPuntosAtaque.Size = new Size(139, 37);
            spnPuntosAtaque.TabIndex = 112;
            // 
            // spnVidaMax
            // 
            spnVidaMax.BackColor = SystemColors.ActiveCaptionText;
            spnVidaMax.ForeColor = Color.DarkGray;
            spnVidaMax.Location = new Point(228, 345);
            spnVidaMax.Name = "spnVidaMax";
            spnVidaMax.Size = new Size(139, 37);
            spnVidaMax.TabIndex = 113;
            // 
            // btnCrear
            // 
            btnCrear.ForeColor = SystemColors.ActiveCaptionText;
            btnCrear.Location = new Point(49, 783);
            btnCrear.Margin = new Padding(10);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(155, 41);
            btnCrear.TabIndex = 118;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormCrearEntidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 840);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrearEntidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrearEntidad";
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlForm;
        private ComboBox cbbHabitats;
        private Label lblNombre;
        private Button btnLimpiar;
        private Label lblReino;
        private Label lblDieta;
        private Label lblHabitat;
        private Label lblEnergiaMaxima;
        private Label lblVidaMaxima;
        private Button btnCrear;
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
        private Button btnCancelar;
        private PictureBox pcbSalir;
        private Label lbltitulo;
    }
}