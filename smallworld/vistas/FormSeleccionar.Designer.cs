namespace smallworld.vistas
{
    partial class FormSeleccionar
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
            lblNombreEntidad = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblNombreEntidad
            // 
            lblNombreEntidad.AutoSize = true;
            lblNombreEntidad.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreEntidad.Location = new Point(48, 48);
            lblNombreEntidad.Name = "lblNombreEntidad";
            lblNombreEntidad.Size = new Size(0, 38);
            lblNombreEntidad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 89);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Vida:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 147);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Energia:";
            // 
            // FormSeleccionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 561);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombreEntidad);
            Name = "FormSeleccionar";
            Text = "FormSeleccionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreEntidad;
        private Label label1;
        private Label label2;
    }
}