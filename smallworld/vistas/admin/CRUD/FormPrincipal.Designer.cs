namespace smallworld.vistas.admin
{
    partial class FormPrincipal
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
            pictureBoxSalir = new PictureBox();
            label1 = new Label();
            picBoxLogo = new PictureBox();
            panel3 = new Panel();
            btnComida = new Button();
            btnItems = new Button();
            btnEntidad = new Button();
            pnlContenedor = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pcbSalir = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBoxSalir);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picBoxLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 106);
            panel1.TabIndex = 4;
            // 
            // pictureBoxSalir
            // 
            pictureBoxSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxSalir.BackColor = Color.Transparent;
            pictureBoxSalir.Image = Properties.Resources.cerrarX32;
            pictureBoxSalir.InitialImage = null;
            pictureBoxSalir.Location = new Point(1949, 12);
            pictureBoxSalir.Margin = new Padding(5);
            pictureBoxSalir.Name = "pictureBoxSalir";
            pictureBoxSalir.Size = new Size(48, 50);
            pictureBoxSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSalir.TabIndex = 2;
            pictureBoxSalir.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Terasu Brush", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(126, 25);
            label1.Name = "label1";
            label1.Size = new Size(211, 61);
            label1.TabIndex = 1;
            label1.Text = "SmallWorld";
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = Properties.Resources.logoSmallWord_removebg_preview;
            picBoxLogo.Location = new Point(19, 5);
            picBoxLogo.Margin = new Padding(10);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(103, 91);
            picBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxLogo.TabIndex = 0;
            picBoxLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackgroundImage = Properties.Resources.fondo;
            panel3.Controls.Add(btnComida);
            panel3.Controls.Add(btnItems);
            panel3.Controls.Add(btnEntidad);
            panel3.Dock = DockStyle.Left;
            panel3.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.ForeColor = SystemColors.Desktop;
            panel3.Location = new Point(0, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 641);
            panel3.TabIndex = 5;
            // 
            // btnComida
            // 
            btnComida.Location = new Point(10, 205);
            btnComida.Name = "btnComida";
            btnComida.Size = new Size(252, 58);
            btnComida.TabIndex = 2;
            btnComida.Text = "COMIDA";
            btnComida.UseVisualStyleBackColor = true;
            btnComida.Click += btnComida_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(10, 116);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(250, 58);
            btnItems.TabIndex = 1;
            btnItems.Text = "ITEM";
            btnItems.UseVisualStyleBackColor = true;
            btnItems.Click += btnItems_Click;
            // 
            // btnEntidad
            // 
            btnEntidad.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntidad.Location = new Point(10, 26);
            btnEntidad.Name = "btnEntidad";
            btnEntidad.Size = new Size(250, 58);
            btnEntidad.TabIndex = 0;
            btnEntidad.Text = "ENTIDAD";
            btnEntidad.UseVisualStyleBackColor = true;
            btnEntidad.Click += btnEntidad_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.AutoSize = true;
            pnlContenedor.BackgroundImage = Properties.Resources.fondo;
            pnlContenedor.Location = new Point(265, 106);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(823, 641);
            pnlContenedor.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoSmallWord_removebg_preview;
            pictureBox2.Location = new Point(19, 5);
            pictureBox2.Margin = new Padding(10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Terasu Brush", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(126, 25);
            label2.Name = "label2";
            label2.Size = new Size(211, 61);
            label2.TabIndex = 1;
            label2.Text = "SmallWorld";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cerrarX32;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(1949, 12);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pcbSalir);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 106);
            panel2.TabIndex = 4;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.BackColor = Color.Transparent;
            pcbSalir.Image = Properties.Resources.cerrarX32;
            pcbSalir.InitialImage = null;
            pcbSalir.Location = new Point(1026, 14);
            pcbSalir.Margin = new Padding(5);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(48, 50);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 3;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            pcbSalir.MouseLeave += pcbSalir_MouseLeave;
            pcbSalir.MouseHover += pcbSalir_MouseHover;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(1088, 747);
            Controls.Add(pnlContenedor);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxSalir;
        private Label label1;
        private PictureBox picBoxLogo;
        private Panel panel3;
        private Button btnComida;
        private Button btnItems;
        private Button btnEntidad;
        private Panel pnlContenedor;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pcbSalir;
    }
}