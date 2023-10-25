namespace smallworld.vistas
{
    partial class FormCrearComida
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
            lblId = new Label();
            lblNombre = new Label();
            lblCalorias = new Label();
            lblTipoDieta = new Label();
            lblAlimento = new Label();
            cbbTipoDieta = new ComboBox();
            txtNombre = new TextBox();
            txtCalorias = new TextBox();
            txtId = new TextBox();
            btnCrear = new Button();
            btnComer = new Button();
            cbbComidas = new ComboBox();
            btnModificar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(123, 62);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(123, 125);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblCalorias
            // 
            lblCalorias.AutoSize = true;
            lblCalorias.Location = new Point(123, 188);
            lblCalorias.Name = "lblCalorias";
            lblCalorias.Size = new Size(69, 20);
            lblCalorias.TabIndex = 2;
            lblCalorias.Text = "Calorias: ";
            // 
            // lblTipoDieta
            // 
            lblTipoDieta.AutoSize = true;
            lblTipoDieta.Location = new Point(123, 254);
            lblTipoDieta.Name = "lblTipoDieta";
            lblTipoDieta.Size = new Size(101, 20);
            lblTipoDieta.TabIndex = 3;
            lblTipoDieta.Text = "Tipo de dieta:";
            // 
            // lblAlimento
            // 
            lblAlimento.AutoSize = true;
            lblAlimento.Location = new Point(123, 336);
            lblAlimento.Name = "lblAlimento";
            lblAlimento.Size = new Size(0, 20);
            lblAlimento.TabIndex = 4;
            // 
            // cbbTipoDieta
            // 
            cbbTipoDieta.FormattingEnabled = true;
            cbbTipoDieta.Location = new Point(237, 258);
            cbbTipoDieta.Name = "cbbTipoDieta";
            cbbTipoDieta.Size = new Size(151, 28);
            cbbTipoDieta.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(238, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtCalorias
            // 
            txtCalorias.Location = new Point(238, 188);
            txtCalorias.Name = "txtCalorias";
            txtCalorias.Size = new Size(125, 27);
            txtCalorias.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(237, 62);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 8;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(390, 53);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnComer
            // 
            btnComer.Location = new Point(631, 400);
            btnComer.Name = "btnComer";
            btnComer.Size = new Size(94, 29);
            btnComer.TabIndex = 10;
            btnComer.Text = "Comer";
            btnComer.UseVisualStyleBackColor = true;
            btnComer.Click += btnComer_Click;
            // 
            // cbbComidas
            // 
            cbbComidas.FormattingEnabled = true;
            cbbComidas.Location = new Point(532, 258);
            cbbComidas.Name = "cbbComidas";
            cbbComidas.Size = new Size(151, 28);
            cbbComidas.TabIndex = 11;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(511, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "MODIFICAR";
            btnModificar.TextAlign = ContentAlignment.TopCenter;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(511, 81);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(631, 53);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FormCrearComida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnModificar);
            Controls.Add(cbbComidas);
            Controls.Add(btnComer);
            Controls.Add(btnCrear);
            Controls.Add(txtId);
            Controls.Add(txtCalorias);
            Controls.Add(txtNombre);
            Controls.Add(cbbTipoDieta);
            Controls.Add(lblAlimento);
            Controls.Add(lblTipoDieta);
            Controls.Add(lblCalorias);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Name = "FormCrearComida";
            Text = "FormCrearComida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Label lblCalorias;
        private Label lblTipoDieta;
        private Label lblAlimento;
        private ComboBox cbbTipoDieta;
        private TextBox txtNombre;
        private TextBox txtCalorias;
        private TextBox txtId;
        private Button btnCrear;
        private Button btnComer;
        private ComboBox cbbComidas;
        private Button btnModificar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}