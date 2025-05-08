namespace Pokemon
{
    partial class pokedex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pokedex));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblPokemon = new Label();
            lblSexo = new Label();
            picIconPokemon = new PictureBox();
            lblPeso = new Label();
            lblAltura = new Label();
            lbltype = new Label();
            lblID = new Label();
            label3 = new Label();
            label14 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            bntPesquisar = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconPokemon).BeginInit();
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
            panel2.Controls.Add(lblPokemon);
            panel2.Controls.Add(lblSexo);
            panel2.Controls.Add(picIconPokemon);
            panel2.Controls.Add(lblPeso);
            panel2.Controls.Add(lblAltura);
            panel2.Controls.Add(lbltype);
            panel2.Controls.Add(lblID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(bntPesquisar);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 470);
            panel2.TabIndex = 1;
            // 
            // lblPokemon
            // 
            lblPokemon.AutoSize = true;
            lblPokemon.BackColor = Color.Gainsboro;
            lblPokemon.Location = new Point(706, 129);
            lblPokemon.Name = "lblPokemon";
            lblPokemon.Size = new Size(0, 25);
            lblPokemon.TabIndex = 33;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = SystemColors.ControlLightLight;
            lblSexo.Location = new Point(610, 166);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(59, 25);
            lblSexo.TabIndex = 32;
            lblSexo.Text = "label4";
            // 
            // picIconPokemon
            // 
            picIconPokemon.ImageLocation = "string img = $\"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{id}.png\"";
            picIconPokemon.Location = new Point(54, 150);
            picIconPokemon.Name = "picIconPokemon";
            picIconPokemon.Size = new Size(279, 151);
            picIconPokemon.TabIndex = 30;
            picIconPokemon.TabStop = false;
            picIconPokemon.Click += picIconPokemon_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = SystemColors.ControlLightLight;
            lblPeso.Location = new Point(606, 285);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(0, 25);
            lblPeso.TabIndex = 28;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.BackColor = SystemColors.ControlLightLight;
            lblAltura.Location = new Point(610, 245);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(0, 25);
            lblAltura.TabIndex = 27;
            // 
            // lbltype
            // 
            lbltype.AutoSize = true;
            lbltype.BackColor = SystemColors.ControlLightLight;
            lbltype.Location = new Point(610, 205);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(59, 25);
            lbltype.TabIndex = 25;
            lbltype.Text = "label5";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Gainsboro;
            lblID.Location = new Point(502, 129);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 25);
            lblID.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Location = new Point(426, 205);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 23;
            label3.Text = "Tipo:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Location = new Point(426, 166);
            label14.Name = "label14";
            label14.Size = new Size(54, 25);
            label14.TabIndex = 18;
            label14.Text = "Sexo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Location = new Point(433, 129);
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
            label9.Location = new Point(426, 285);
            label9.Name = "label9";
            label9.Size = new Size(53, 25);
            label9.TabIndex = 11;
            label9.Text = "Peso:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Location = new Point(426, 245);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 10;
            label8.Text = "Altura:";
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
            bntPesquisar.Click += bntPesquisar_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pokedex
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(850, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pokedex";
            Text = "pokedex";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button bntPesquisar;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtID;
        private Label label14;
        private Label lblnome;
        private Label lblid;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox picIconPokemon;
        private Label la;
        private Label lblPeso;
        private Label lblAltura;
        private Label label6;
        private Label lblID;
        private Label lblSexo;
        private Label lblPokemon;
        private Label lbltype;
        private Label label3;
    }
}
