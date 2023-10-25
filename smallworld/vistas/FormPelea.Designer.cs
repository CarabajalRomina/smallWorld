namespace smallworld.vistas
{
    partial class FormPelea
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
            lblPersonaje1 = new Label();
            cbbEntidad1 = new ComboBox();
            cbbEntidad2 = new ComboBox();
            lblPersonaje2 = new Label();
            btnPelear = new Button();
            lblDespuesPelea = new Label();
            lblAntesPelea = new Label();
            lblAntesPelea2 = new Label();
            lblDespuesPelea2 = new Label();
            SuspendLayout();
            // 
            // lblPersonaje1
            // 
            lblPersonaje1.AutoSize = true;
            lblPersonaje1.Location = new Point(27, 83);
            lblPersonaje1.Name = "lblPersonaje1";
            lblPersonaje1.Size = new Size(87, 20);
            lblPersonaje1.TabIndex = 0;
            lblPersonaje1.Text = "Personaje 1:";
            // 
            // cbbEntidad1
            // 
            cbbEntidad1.FormattingEnabled = true;
            cbbEntidad1.Location = new Point(129, 80);
            cbbEntidad1.Name = "cbbEntidad1";
            cbbEntidad1.Size = new Size(206, 28);
            cbbEntidad1.TabIndex = 1;
            cbbEntidad1.SelectedIndexChanged += cbbEntidad1_SelectedIndexChanged;
            // 
            // cbbEntidad2
            // 
            cbbEntidad2.FormattingEnabled = true;
            cbbEntidad2.Location = new Point(570, 80);
            cbbEntidad2.Name = "cbbEntidad2";
            cbbEntidad2.Size = new Size(190, 28);
            cbbEntidad2.TabIndex = 2;
            cbbEntidad2.SelectedIndexChanged += cbbEntidad2_SelectedIndexChanged;
            // 
            // lblPersonaje2
            // 
            lblPersonaje2.AutoSize = true;
            lblPersonaje2.Location = new Point(477, 83);
            lblPersonaje2.Name = "lblPersonaje2";
            lblPersonaje2.Size = new Size(84, 20);
            lblPersonaje2.TabIndex = 3;
            lblPersonaje2.Text = "Personaje 2";
            // 
            // btnPelear
            // 
            btnPelear.Location = new Point(352, 154);
            btnPelear.Name = "btnPelear";
            btnPelear.Size = new Size(138, 42);
            btnPelear.TabIndex = 4;
            btnPelear.Text = "Pelear";
            btnPelear.UseVisualStyleBackColor = true;
            btnPelear.Click += btnPelear_Click;
            // 
            // lblDespuesPelea
            // 
            lblDespuesPelea.AutoSize = true;
            lblDespuesPelea.Location = new Point(101, 320);
            lblDespuesPelea.Name = "lblDespuesPelea";
            lblDespuesPelea.Size = new Size(50, 20);
            lblDespuesPelea.TabIndex = 5;
            lblDespuesPelea.Text = "label3";
            // 
            // lblAntesPelea
            // 
            lblAntesPelea.AutoSize = true;
            lblAntesPelea.Location = new Point(101, 233);
            lblAntesPelea.Name = "lblAntesPelea";
            lblAntesPelea.Size = new Size(50, 20);
            lblAntesPelea.TabIndex = 6;
            lblAntesPelea.Text = "label1";
            // 
            // lblAntesPelea2
            // 
            lblAntesPelea2.AutoSize = true;
            lblAntesPelea2.Location = new Point(101, 272);
            lblAntesPelea2.Name = "lblAntesPelea2";
            lblAntesPelea2.Size = new Size(50, 20);
            lblAntesPelea2.TabIndex = 7;
            lblAntesPelea2.Text = "label1";
            // 
            // lblDespuesPelea2
            // 
            lblDespuesPelea2.AutoSize = true;
            lblDespuesPelea2.Location = new Point(101, 368);
            lblDespuesPelea2.Name = "lblDespuesPelea2";
            lblDespuesPelea2.Size = new Size(50, 20);
            lblDespuesPelea2.TabIndex = 8;
            lblDespuesPelea2.Text = "label3";
            // 
            // FormSeleccionarEntidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 525);
            Controls.Add(lblDespuesPelea2);
            Controls.Add(lblAntesPelea2);
            Controls.Add(lblAntesPelea);
            Controls.Add(lblDespuesPelea);
            Controls.Add(btnPelear);
            Controls.Add(lblPersonaje2);
            Controls.Add(cbbEntidad2);
            Controls.Add(cbbEntidad1);
            Controls.Add(lblPersonaje1);
            Name = "FormSeleccionarEntidad";
            Text = "FormSeleccionarEntidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPersonaje1;
        private ComboBox cbbEntidad1;
        private ComboBox cbbEntidad2;
        private Label lblPersonaje2;
        private Button btnPelear;
        private Label lblDespuesPelea;
        private Label lblAntesPelea;
        private Label lblAntesPelea2;
        private Label lblDespuesPelea2;
    }
}