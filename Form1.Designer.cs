namespace Pokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label14 = new Label();
            lblnome = new Label();
            lblid = new Label();
            label1 = new Label();
            txtID = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblpeso = new Label();
            lblTipo = new Label();
            lblAltura = new Label();
            lblSexo = new Label();
            bntPesquisar = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 30);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(784, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(814, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(lblnome);
            panel2.Controls.Add(lblid);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblpeso);
            panel2.Controls.Add(lblTipo);
            panel2.Controls.Add(lblAltura);
            panel2.Controls.Add(lblSexo);
            panel2.Controls.Add(bntPesquisar);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 470);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = Properties.Resources.icon_pokemon;
            pictureBox4.Location = new Point(-532, -283);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(245, 286);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Location = new Point(433, 166);
            label14.Name = "label14";
            label14.Size = new Size(54, 25);
            label14.TabIndex = 18;
            label14.Text = "Sexo:";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.BackColor = Color.Gainsboro;
            lblnome.Location = new Point(699, 129);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(0, 25);
            lblnome.TabIndex = 17;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.BackColor = Color.Gainsboro;
            lblid.Location = new Point(500, 129);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 25);
            lblid.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Location = new Point(427, 129);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 15;
            label1.Text = "Id:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.DeepSkyBlue;
            txtID.BorderStyle = BorderStyle.None;
            txtID.ForeColor = SystemColors.Window;
            txtID.Location = new Point(396, 70);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "#01";
            txtID.Size = new Size(131, 24);
            txtID.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Location = new Point(610, 129);
            label11.Name = "label11";
            label11.Size = new Size(65, 25);
            label11.TabIndex = 13;
            label11.Text = "Nome:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Location = new Point(433, 285);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Location = new Point(433, 285);
            label9.Name = "label9";
            label9.Size = new Size(53, 25);
            label9.TabIndex = 11;
            label9.Text = "Peso:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Location = new Point(433, 245);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 10;
            label8.Text = "Altura:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Location = new Point(433, 205);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 9;
            label7.Text = "Tipo:";
            label7.Click += label7_Click;
            // 
            // lblpeso
            // 
            lblpeso.AutoSize = true;
            lblpeso.BackColor = SystemColors.ControlLightLight;
            lblpeso.Location = new Point(598, 285);
            lblpeso.Name = "lblpeso";
            lblpeso.Size = new Size(0, 25);
            lblpeso.TabIndex = 7;
            lblpeso.Click += lblpeso_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = SystemColors.ControlLightLight;
            lblTipo.Location = new Point(598, 205);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 25);
            lblTipo.TabIndex = 6;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = SystemColors.ControlLightLight;
            lblAltura.Location = new Point(598, 245);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(0, 25);
            lblAltura.TabIndex = 5;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = SystemColors.ControlLightLight;
            lblSexo.Location = new Point(598, 166);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(0, 25);
            lblSexo.TabIndex = 4;
            // 
            // bntPesquisar
            // 
            bntPesquisar.BackColor = SystemColors.ActiveCaptionText;
            bntPesquisar.BackgroundImageLayout = ImageLayout.None;
            bntPesquisar.FlatAppearance.BorderSize = 0;
            bntPesquisar.FlatStyle = FlatStyle.Flat;
            bntPesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntPesquisar.ForeColor = SystemColors.ControlLightLight;
            bntPesquisar.Location = new Point(570, 62);
            bntPesquisar.Name = "bntPesquisar";
            bntPesquisar.Size = new Size(251, 39);
            bntPesquisar.TabIndex = 1;
            bntPesquisar.Text = "Pesquisar";
            bntPesquisar.UseVisualStyleBackColor = false;
            bntPesquisar.Click += bntPesquisar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.pn9wu54jm2i711;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(850, 470);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(408, 321);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 21;
            label2.Text = "Descriçao";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button bntPesquisar;
        private PictureBox pictureBox3;
        private Label lblTipo;
        private Label lblAltura;
        private Label lblSexo;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblpeso;
        private TextBox txtID;
        private Label label14;
        private Label lblnome;
        private Label lblid;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label2;
    }
}
