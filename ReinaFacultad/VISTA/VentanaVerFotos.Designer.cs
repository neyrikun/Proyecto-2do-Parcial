namespace VISTA
{
    partial class VentanaVerFotos
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            labelMat = new Label();
            label1 = new Label();
            labelName = new Label();
            labelApell = new Label();
            comboFotos = new ComboBox();
            label9 = new Label();
            label2 = new Label();
            comboAlbunes = new ComboBox();
            labelDescrip = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_Salir = new Button();
            btnVerFotos = new Button();
            pictureFoto = new PictureBox();
            comboComent = new ComboBox();
            labelComent = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelMat);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(labelApell);
            groupBox1.Controls.Add(comboFotos);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboAlbunes);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(205, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(327, 203);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Candidata:";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 18);
            label5.TabIndex = 59;
            label5.Text = "Matrícula:";
            // 
            // labelMat
            // 
            labelMat.Location = new Point(168, 23);
            labelMat.Margin = new Padding(4, 0, 4, 0);
            labelMat.Name = "labelMat";
            labelMat.Size = new Size(117, 18);
            labelMat.TabIndex = 60;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 61;
            label1.Text = "Nombres y Apellidos:";
            // 
            // labelName
            // 
            labelName.Location = new Point(168, 52);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(117, 21);
            labelName.TabIndex = 62;
            // 
            // labelApell
            // 
            labelApell.Location = new Point(168, 83);
            labelApell.Margin = new Padding(4, 0, 4, 0);
            labelApell.Name = "labelApell";
            labelApell.Size = new Size(117, 21);
            labelApell.TabIndex = 63;
            // 
            // comboFotos
            // 
            comboFotos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFotos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboFotos.ItemHeight = 13;
            comboFotos.Items.AddRange(new object[] { "200407801", "200508880" });
            comboFotos.Location = new Point(162, 159);
            comboFotos.Margin = new Padding(4, 3, 4, 3);
            comboFotos.Name = "comboFotos";
            comboFotos.Size = new Size(152, 21);
            comboFotos.TabIndex = 67;
            comboFotos.SelectedIndexChanged += comboFotos_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 126);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(83, 22);
            label9.TabIndex = 64;
            label9.Text = "Albunes:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 66;
            label2.Text = "Fotos:";
            // 
            // comboAlbunes
            // 
            comboAlbunes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAlbunes.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboAlbunes.ItemHeight = 13;
            comboAlbunes.Items.AddRange(new object[] { "200407801", "200508880" });
            comboAlbunes.Location = new Point(162, 126);
            comboAlbunes.Margin = new Padding(4, 3, 4, 3);
            comboAlbunes.Name = "comboAlbunes";
            comboAlbunes.Size = new Size(152, 21);
            comboAlbunes.TabIndex = 65;
            comboAlbunes.SelectedIndexChanged += comboAlbunes_SelectedIndexChanged;
            // 
            // labelDescrip
            // 
            labelDescrip.ForeColor = Color.DimGray;
            labelDescrip.Location = new Point(7, 44);
            labelDescrip.Margin = new Padding(4, 0, 4, 0);
            labelDescrip.Name = "labelDescrip";
            labelDescrip.Size = new Size(198, 82);
            labelDescrip.TabIndex = 79;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(7, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 18);
            label4.TabIndex = 78;
            label4.Text = "Descripción de la Foto:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 18);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 18);
            label3.TabIndex = 77;
            label3.Text = "Comentario:";
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(224, 224, 224);
            btn_Salir.Location = new Point(274, 400);
            btn_Salir.Margin = new Padding(4, 3, 4, 3);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(93, 28);
            btn_Salir.TabIndex = 75;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btnVerFotos
            // 
            btnVerFotos.BackColor = Color.FromArgb(224, 224, 224);
            btnVerFotos.Location = new Point(173, 400);
            btnVerFotos.Margin = new Padding(4, 3, 4, 3);
            btnVerFotos.Name = "btnVerFotos";
            btnVerFotos.Size = new Size(93, 28);
            btnVerFotos.TabIndex = 74;
            btnVerFotos.Text = "Volver";
            btnVerFotos.UseVisualStyleBackColor = false;
            btnVerFotos.Click += btnVerFotos_Click;
            // 
            // pictureFoto
            // 
            pictureFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureFoto.Location = new Point(35, 25);
            pictureFoto.Margin = new Padding(4, 3, 4, 3);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(140, 168);
            pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFoto.TabIndex = 73;
            pictureFoto.TabStop = false;
            // 
            // comboComent
            // 
            comboComent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboComent.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboComent.ItemHeight = 13;
            comboComent.Items.AddRange(new object[] { "200407801", "200508880" });
            comboComent.Location = new Point(355, 14);
            comboComent.Margin = new Padding(4, 3, 4, 3);
            comboComent.Name = "comboComent";
            comboComent.Size = new Size(152, 21);
            comboComent.TabIndex = 68;
            comboComent.SelectedIndexChanged += comboComent_SelectedIndexChanged;
            // 
            // labelComent
            // 
            labelComent.Location = new Point(258, 44);
            labelComent.Margin = new Padding(4, 0, 4, 0);
            labelComent.Name = "labelComent";
            labelComent.Size = new Size(250, 82);
            labelComent.TabIndex = 81;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(labelComent);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboComent);
            groupBox2.Controls.Add(labelDescrip);
            groupBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(13, 224);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(524, 170);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descripción y Comentarios:";
            // 
            // VentanaVerFotos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(551, 436);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_Salir);
            Controls.Add(btnVerFotos);
            Controls.Add(pictureFoto);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VentanaVerFotos";
            Text = "Fotos de la Candidata";
            Load += VentanaVerFotos_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelApell;
        private System.Windows.Forms.ComboBox comboFotos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAlbunes;
        private System.Windows.Forms.Label labelDescrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btnVerFotos;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.ComboBox comboComent;
        private System.Windows.Forms.Label labelComent;
        private System.Windows.Forms.GroupBox groupBox2;


    }
}