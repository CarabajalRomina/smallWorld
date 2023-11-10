namespace smallworld.vistas
{
    partial class EntidadView
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
            lblNombre = new Label();
            lblReino = new Label();
            lblDieta = new Label();
            lblHabitat = new Label();
            lblEnergiaMaxima = new Label();
            lblVidaMaxima = new Label();
            lblPuntosAtaque = new Label();
            lblPuntosDefensa = new Label();
            txtNombre = new TextBox();
            cbbReino = new ComboBox();
            cbbDieta = new ComboBox();
            spnPuntosAtaque = new NumericUpDown();
            spnVidaMax = new NumericUpDown();
            spnPuntosDefensa = new NumericUpDown();
            spnEnergiaMax = new NumericUpDown();
            spnRangoAtaque = new NumericUpDown();
            lblRangoAtaque = new Label();
            checkListHabitat = new CheckedListBox();
            btnCrear = new Button();
            lblEntidades = new Label();
            cbbEntidad = new ComboBox();
            btnPelar = new Button();
            btnSeleccionarEntidad = new Button();
            btnEditar = new Button();
            txtId = new TextBox();
            btnCrearComida = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)spnPuntosAtaque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnVidaMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnPuntosDefensa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnEnergiaMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnRangoAtaque).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(51, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblReino
            // 
            lblReino.AutoSize = true;
            lblReino.Location = new Point(51, 112);
            lblReino.Name = "lblReino";
            lblReino.Size = new Size(50, 20);
            lblReino.TabIndex = 1;
            lblReino.Text = "Reino:";
            // 
            // lblDieta
            // 
            lblDieta.AutoSize = true;
            lblDieta.Location = new Point(51, 175);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(48, 20);
            lblDieta.TabIndex = 2;
            lblDieta.Text = "Dieta:";
            // 
            // lblHabitat
            // 
            lblHabitat.AutoSize = true;
            lblHabitat.Location = new Point(419, 18);
            lblHabitat.Name = "lblHabitat";
            lblHabitat.Size = new Size(62, 20);
            lblHabitat.TabIndex = 3;
            lblHabitat.Text = "Habitat:";
            // 
            // lblEnergiaMaxima
            // 
            lblEnergiaMaxima.AutoSize = true;
            lblEnergiaMaxima.Location = new Point(51, 286);
            lblEnergiaMaxima.Name = "lblEnergiaMaxima";
            lblEnergiaMaxima.Size = new Size(119, 20);
            lblEnergiaMaxima.TabIndex = 4;
            lblEnergiaMaxima.Text = "Energia maxima:";
            // 
            // lblVidaMaxima
            // 
            lblVidaMaxima.AutoSize = true;
            lblVidaMaxima.Location = new Point(51, 344);
            lblVidaMaxima.Name = "lblVidaMaxima";
            lblVidaMaxima.Size = new Size(99, 20);
            lblVidaMaxima.TabIndex = 5;
            lblVidaMaxima.Text = "Vida maxima:";
            // 
            // lblPuntosAtaque
            // 
            lblPuntosAtaque.AutoSize = true;
            lblPuntosAtaque.Location = new Point(51, 410);
            lblPuntosAtaque.Name = "lblPuntosAtaque";
            lblPuntosAtaque.Size = new Size(127, 20);
            lblPuntosAtaque.TabIndex = 6;
            lblPuntosAtaque.Text = "Puntos de ataque:";
            // 
            // lblPuntosDefensa
            // 
            lblPuntosDefensa.AutoSize = true;
            lblPuntosDefensa.Location = new Point(49, 483);
            lblPuntosDefensa.Name = "lblPuntosDefensa";
            lblPuntosDefensa.Size = new Size(133, 20);
            lblPuntosDefensa.TabIndex = 7;
            lblPuntosDefensa.Text = "Puntos de defensa:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 8;
            // 
            // cbbReino
            // 
            cbbReino.FormattingEnabled = true;
            cbbReino.Location = new Point(143, 113);
            cbbReino.Name = "cbbReino";
            cbbReino.Size = new Size(226, 28);
            cbbReino.TabIndex = 9;
            // 
            // cbbDieta
            // 
            cbbDieta.FormattingEnabled = true;
            cbbDieta.Location = new Point(144, 172);
            cbbDieta.Name = "cbbDieta";
            cbbDieta.Size = new Size(225, 28);
            cbbDieta.TabIndex = 10;
            // 
            // spnPuntosAtaque
            // 
            spnPuntosAtaque.Location = new Point(186, 408);
            spnPuntosAtaque.Name = "spnPuntosAtaque";
            spnPuntosAtaque.Size = new Size(150, 27);
            spnPuntosAtaque.TabIndex = 11;
            // 
            // spnVidaMax
            // 
            spnVidaMax.Location = new Point(186, 342);
            spnVidaMax.Name = "spnVidaMax";
            spnVidaMax.Size = new Size(150, 27);
            spnVidaMax.TabIndex = 12;
            // 
            // spnPuntosDefensa
            // 
            spnPuntosDefensa.Location = new Point(186, 481);
            spnPuntosDefensa.Name = "spnPuntosDefensa";
            spnPuntosDefensa.Size = new Size(150, 27);
            spnPuntosDefensa.TabIndex = 13;
            // 
            // spnEnergiaMax
            // 
            spnEnergiaMax.Location = new Point(186, 286);
            spnEnergiaMax.Name = "spnEnergiaMax";
            spnEnergiaMax.Size = new Size(150, 27);
            spnEnergiaMax.TabIndex = 15;
            // 
            // spnRangoAtaque
            // 
            spnRangoAtaque.Location = new Point(186, 540);
            spnRangoAtaque.Name = "spnRangoAtaque";
            spnRangoAtaque.Size = new Size(150, 27);
            spnRangoAtaque.TabIndex = 17;
            // 
            // lblRangoAtaque
            // 
            lblRangoAtaque.AutoSize = true;
            lblRangoAtaque.Location = new Point(51, 542);
            lblRangoAtaque.Name = "lblRangoAtaque";
            lblRangoAtaque.Size = new Size(126, 20);
            lblRangoAtaque.TabIndex = 16;
            lblRangoAtaque.Text = "Rango de ataque:";
            // 
            // checkListHabitat
            // 
            checkListHabitat.FormattingEnabled = true;
            checkListHabitat.Location = new Point(419, 57);
            checkListHabitat.Name = "checkListHabitat";
            checkListHabitat.Size = new Size(150, 114);
            checkListHabitat.TabIndex = 19;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(594, 18);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblEntidades
            // 
            lblEntidades.AutoSize = true;
            lblEntidades.Location = new Point(462, 286);
            lblEntidades.Name = "lblEntidades";
            lblEntidades.Size = new Size(77, 20);
            lblEntidades.TabIndex = 21;
            lblEntidades.Text = "Entidades:";
            // 
            // cbbEntidad
            // 
            cbbEntidad.FormattingEnabled = true;
            cbbEntidad.Location = new Point(545, 283);
            cbbEntidad.Name = "cbbEntidad";
            cbbEntidad.Size = new Size(226, 28);
            cbbEntidad.TabIndex = 23;
            // 
            // btnPelar
            // 
            btnPelar.Location = new Point(627, 459);
            btnPelar.Name = "btnPelar";
            btnPelar.Size = new Size(182, 29);
            btnPelar.TabIndex = 26;
            btnPelar.Text = "Pelear";
            btnPelar.UseVisualStyleBackColor = true;
            btnPelar.Click += btnPelar_Click;
            // 
            // btnSeleccionarEntidad
            // 
            btnSeleccionarEntidad.Location = new Point(643, 317);
            btnSeleccionarEntidad.Name = "btnSeleccionarEntidad";
            btnSeleccionarEntidad.Size = new Size(180, 29);
            btnSeleccionarEntidad.TabIndex = 27;
            btnSeleccionarEntidad.Text = "Seleccionar Entidad";
            btnSeleccionarEntidad.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(594, 72);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 28;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(143, 11);
            txtId.Name = "txtId";
            txtId.Size = new Size(76, 27);
            txtId.TabIndex = 30;
            txtId.Visible = false;
            // 
            // btnCrearComida
            // 
            btnCrearComida.Location = new Point(419, 459);
            btnCrearComida.Name = "btnCrearComida";
            btnCrearComida.Size = new Size(182, 29);
            btnCrearComida.TabIndex = 31;
            btnCrearComida.Text = "Crear Comida";
            btnCrearComida.UseVisualStyleBackColor = true;
            btnCrearComida.Click += btnCrearComida_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(729, 72);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 32;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(594, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(410, 523);
            button1.Name = "button1";
            button1.Size = new Size(182, 29);
            button1.TabIndex = 34;
            button1.Text = "Crear Item";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(476, 383);
            button2.Name = "button2";
            button2.Size = new Size(232, 29);
            button2.TabIndex = 35;
            button2.Text = "CRUD ENTIDADES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EntidadView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 592);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrearComida);
            Controls.Add(txtId);
            Controls.Add(btnEditar);
            Controls.Add(btnSeleccionarEntidad);
            Controls.Add(btnPelar);
            Controls.Add(cbbEntidad);
            Controls.Add(lblEntidades);
            Controls.Add(btnCrear);
            Controls.Add(checkListHabitat);
            Controls.Add(spnRangoAtaque);
            Controls.Add(lblRangoAtaque);
            Controls.Add(spnEnergiaMax);
            Controls.Add(spnPuntosDefensa);
            Controls.Add(spnVidaMax);
            Controls.Add(spnPuntosAtaque);
            Controls.Add(cbbDieta);
            Controls.Add(cbbReino);
            Controls.Add(txtNombre);
            Controls.Add(lblPuntosDefensa);
            Controls.Add(lblPuntosAtaque);
            Controls.Add(lblVidaMaxima);
            Controls.Add(lblEnergiaMaxima);
            Controls.Add(lblHabitat);
            Controls.Add(lblDieta);
            Controls.Add(lblReino);
            Controls.Add(lblNombre);
            Name = "EntidadView";
            Text = "EntidadView";
            ((System.ComponentModel.ISupportInitialize)spnPuntosAtaque).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnVidaMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnPuntosDefensa).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnEnergiaMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnRangoAtaque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblReino;
        private Label lblDieta;
        private Label lblHabitat;
        private Label lblEnergiaMaxima;
        private Label lblVidaMaxima;
        private Label lblPuntosAtaque;
        private Label lblPuntosDefensa;
        private TextBox txtNombre;
        private ComboBox cbbReino;
        private ComboBox cbbDieta;
        private NumericUpDown spnPuntosAtaque;
        private NumericUpDown spnVidaMax;
        private NumericUpDown spnPuntosDefensa;
        private NumericUpDown spnEnergiaMax;
        private NumericUpDown spnRangoAtaque;
        private Label lblRangoAtaque;
        private CheckedListBox checkListHabitat;
        private Button btnCrear;
        private Label lblEntidades;
        private ComboBox cbbEntidad;
        private Button btnPelar;
        private Button btnSeleccionarEntidad;
        private Button btnEditar;
        private TextBox txtId;
        private Button btnCrearComida;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button button1;
        private Button button2;
    }
}