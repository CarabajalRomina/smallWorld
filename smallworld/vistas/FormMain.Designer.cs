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
            btnItems = new Button();
            btnComida = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picBoxSalir
            // 
            picBoxSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBoxSalir.BackColor = Color.Transparent;
            picBoxSalir.Image = Properties.Resources.cerrarX32;
            picBoxSalir.Location = new Point(1234, 22);
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
            btnJugar.Anchor = AnchorStyles.Top;
            btnJugar.Location = new Point(505, 718);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(297, 68);
            btnJugar.TabIndex = 1;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Anchor = AnchorStyles.Top;
            btnAdmin.Location = new Point(505, 819);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(297, 68);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnItems
            // 
            btnItems.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnItems.Location = new Point(979, 841);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(297, 68);
            btnItems.TabIndex = 3;
            btnItems.Text = "items";
            btnItems.UseVisualStyleBackColor = true;
            btnItems.Click += btnItems_Click;
            // 
            // btnComida
            // 
            btnComida.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComida.Location = new Point(979, 767);
            btnComida.Name = "btnComida";
            btnComida.Size = new Size(297, 68);
            btnComida.TabIndex = 4;
            btnComida.Text = "comidas";
            btnComida.UseVisualStyleBackColor = true;
            btnComida.Click += btnComida_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logoSmallWord_removebg_preview;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1288, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Terasu Brush", 72F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(237, 471);
            label2.Name = "label2";
            label2.Size = new Size(829, 244);
            label2.TabIndex = 6;
            label2.Text = "SmallWorld";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1288, 935);
            Controls.Add(picBoxSalir);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnComida);
            Controls.Add(btnItems);
            Controls.Add(btnAdmin);
            Controls.Add(btnJugar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxSalir;
        private Button btnJugar;
        private Button btnAdmin;
        private Button btnItems;
        private Button btnComida;
        private PictureBox pictureBox1;
        private Label label2;
    }
}