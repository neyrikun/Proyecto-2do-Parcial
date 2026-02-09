namespace VISTA
{
    partial class VentanaComentariadas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaComentariadas));
            panel2 = new Panel();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelcategorias = new Panel();
            label4 = new Label();
            pictureFoto = new PictureBox();
            panelCandidatas = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelcategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            panelCandidatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(704, 93);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 554);
            panel2.TabIndex = 15;
            // 
            // button6
            // 
            button6.Location = new Point(41, 122);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(131, 28);
            button6.TabIndex = 21;
            button6.Text = "Ver Resultados";
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(41, 88);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(131, 28);
            button4.TabIndex = 18;
            button4.Text = "Agregar Fotos";
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(41, 53);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(131, 28);
            button3.TabIndex = 17;
            button3.Text = "Crear Albunes";
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 18);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(131, 28);
            button2.TabIndex = 16;
            button2.Text = "Inscribir Candidatas";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(41, 157);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(131, 28);
            button1.TabIndex = 15;
            button1.Text = "Salir";
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -8);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 101);
            panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(818, 3);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(301, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(284, 25);
            label3.TabIndex = 3;
            label3.Text = "Candidatas Mas Comentareadas";
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(236, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 2;
            label2.Text = "Estas en:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 18);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(231, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 40);
            label1.TabIndex = 0;
            label1.Text = "REINA FIEC 2026";
            label1.Click += label1_Click;
            // 
            // panelcategorias
            // 
            panelcategorias.AutoScroll = true;
            panelcategorias.BackColor = Color.Black;
            panelcategorias.BorderStyle = BorderStyle.FixedSingle;
            panelcategorias.Controls.Add(label4);
            panelcategorias.Controls.Add(pictureFoto);
            panelcategorias.Location = new Point(-6, 93);
            panelcategorias.Margin = new Padding(4, 3, 4, 3);
            panelcategorias.Name = "panelcategorias";
            panelcategorias.Size = new Size(168, 554);
            panelcategorias.TabIndex = 12;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(65, 85);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(24, 450);
            label4.TabIndex = 7;
            label4.Text = "Mas  Comentareada";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureFoto
            // 
            pictureFoto.BackColor = Color.Black;
            pictureFoto.Location = new Point(50, -2);
            pictureFoto.Margin = new Padding(4, 3, 4, 3);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(69, 72);
            pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFoto.TabIndex = 6;
            pictureFoto.TabStop = false;
            // 
            // panelCandidatas
            // 
            panelCandidatas.AutoScroll = true;
            panelCandidatas.Controls.Add(pictureBox7);
            panelCandidatas.Controls.Add(pictureBox6);
            panelCandidatas.Controls.Add(pictureBox5);
            panelCandidatas.Controls.Add(pictureBox4);
            panelCandidatas.Controls.Add(pictureBox3);
            panelCandidatas.Location = new Point(162, 93);
            panelCandidatas.Margin = new Padding(4, 3, 4, 3);
            panelCandidatas.Name = "panelCandidatas";
            panelCandidatas.Size = new Size(541, 554);
            panelCandidatas.TabIndex = 13;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(406, 7);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(77, 92);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(322, 7);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(77, 92);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(238, 7);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(77, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(154, 7);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(77, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(70, 7);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // VentanaComentariadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(912, 640);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelcategorias);
            Controls.Add(panelCandidatas);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VentanaComentariadas";
            Text = "Reina FIEC- Mas Comentariadas";
            Load += VentanaComentariadas_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelcategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            panelCandidatas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcategorias;
        private System.Windows.Forms.Panel panelCandidatas;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}