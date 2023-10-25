namespace smallworld.vistas
{
    partial class FormMain
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
            picBoxSalir = new PictureBox();
            btnJugar = new Button();
            btnAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxSalir).BeginInit();
            SuspendLayout();
            // 
            // picBoxSalir
            // 
            picBoxSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBoxSalir.BackColor = Color.Transparent;
            picBoxSalir.Image = Properties.Resources.cerrarX32;
            picBoxSalir.Location = new Point(1169, 45);
            picBoxSalir.Name = "picBoxSalir";
            picBoxSalir.Size = new Size(42, 42);
            picBoxSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxSalir.TabIndex = 0;
            picBoxSalir.TabStop = false;
            picBoxSalir.Click += picBoxSalir_Click;
            picBoxSalir.MouseLeave += picBoxSalir_MouseLeave;
            picBoxSalir.MouseHover += picBoxSalir_MouseHover;
            // 
            // btnJugar
            // 
            btnJugar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnJugar.Location = new Point(144, 642);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(297, 68);
            btnJugar.TabIndex = 1;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(801, 642);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(297, 68);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1257, 781);
            Controls.Add(btnAdmin);
            Controls.Add(btnJugar);
            Controls.Add(picBoxSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)picBoxSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBoxSalir;
        private Button btnJugar;
        private Button btnAdmin;
    }
}