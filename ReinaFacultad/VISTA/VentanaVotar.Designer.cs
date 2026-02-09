namespace VISTA
{
    partial class VentanaVotar
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
            pictureFoto = new PictureBox();
            groupCandidata = new GroupBox();
            comboTipo = new ComboBox();
            label1 = new Label();
            labelApe = new Label();
            labelName = new Label();
            comboMat = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            label10 = new Label();
            btnVotar = new Button();
            btnCancelar = new Button();
            groupEstudiante = new GroupBox();
            btnMatricula = new Button();
            textMatEst = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            groupCandidata.SuspendLayout();
            groupEstudiante.SuspendLayout();
            SuspendLayout();
            // 
            // pictureFoto
            // 
            pictureFoto.Location = new Point(37, 55);
            pictureFoto.Margin = new Padding(4, 3, 4, 3);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(131, 164);
            pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFoto.TabIndex = 1;
            pictureFoto.TabStop = false;
            // 
            // groupCandidata
            // 
            groupCandidata.Controls.Add(comboTipo);
            groupCandidata.Controls.Add(label1);
            groupCandidata.Controls.Add(labelApe);
            groupCandidata.Controls.Add(labelName);
            groupCandidata.Controls.Add(comboMat);
            groupCandidata.Controls.Add(label6);
            groupCandidata.Controls.Add(label8);
            groupCandidata.Controls.Add(label10);
            groupCandidata.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupCandidata.Location = new Point(237, 29);
            groupCandidata.Margin = new Padding(4, 3, 4, 3);
            groupCandidata.Name = "groupCandidata";
            groupCandidata.Padding = new Padding(4, 3, 4, 3);
            groupCandidata.Size = new Size(279, 225);
            groupCandidata.TabIndex = 52;
            groupCandidata.TabStop = false;
            groupCandidata.Text = "Datos de la Candidata:";
            // 
            // comboTipo
            // 
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTipo.ItemHeight = 13;
            comboTipo.Items.AddRange(new object[] { "200407801", "200508880" });
            comboTipo.Location = new Point(22, 186);
            comboTipo.Margin = new Padding(4, 3, 4, 3);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(152, 21);
            comboTipo.TabIndex = 54;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 164);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 53;
            label1.Text = "Tipo de Dignidad:";
            // 
            // labelApe
            // 
            labelApe.Location = new Point(104, 110);
            labelApe.Margin = new Padding(4, 0, 4, 0);
            labelApe.Name = "labelApe";
            labelApe.Size = new Size(156, 18);
            labelApe.TabIndex = 52;
            // 
            // labelName
            // 
            labelName.Location = new Point(104, 74);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(156, 20);
            labelName.TabIndex = 51;
            // 
            // comboMat
            // 
            comboMat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMat.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboMat.ItemHeight = 13;
            comboMat.Items.AddRange(new object[] { "200407801", "200508880" });
            comboMat.Location = new Point(107, 36);
            comboMat.Margin = new Padding(4, 3, 4, 3);
            comboMat.Name = "comboMat";
            comboMat.Size = new Size(152, 21);
            comboMat.TabIndex = 50;
            comboMat.SelectedIndexChanged += comboMat_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 110);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 18);
            label6.TabIndex = 46;
            label6.Text = "Apellidos:";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 75);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 18);
            label8.TabIndex = 44;
            label8.Text = "Nombre:";
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 40);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 18);
            label10.TabIndex = 38;
            label10.Text = "Matrícula:";
            // 
            // btnVotar
            // 
            btnVotar.BackColor = Color.FromArgb(224, 224, 224);
            btnVotar.Location = new Point(163, 395);
            btnVotar.Margin = new Padding(4, 3, 4, 3);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(93, 28);
            btnVotar.TabIndex = 54;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = false;
            btnVotar.Click += btnVotar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.Location = new Point(285, 395);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 28);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupEstudiante
            // 
            groupEstudiante.Controls.Add(btnMatricula);
            groupEstudiante.Controls.Add(textMatEst);
            groupEstudiante.Controls.Add(label4);
            groupEstudiante.Controls.Add(label3);
            groupEstudiante.Controls.Add(label2);
            groupEstudiante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupEstudiante.Location = new Point(14, 262);
            groupEstudiante.Margin = new Padding(4, 3, 4, 3);
            groupEstudiante.Name = "groupEstudiante";
            groupEstudiante.Padding = new Padding(4, 3, 4, 3);
            groupEstudiante.Size = new Size(502, 113);
            groupEstudiante.TabIndex = 55;
            groupEstudiante.TabStop = false;
            groupEstudiante.Text = "Datos del Votante:";
            // 
            // btnMatricula
            // 
            btnMatricula.BackColor = Color.FromArgb(224, 224, 224);
            btnMatricula.Location = new Point(390, 46);
            btnMatricula.Margin = new Padding(4, 3, 4, 3);
            btnMatricula.Name = "btnMatricula";
            btnMatricula.Size = new Size(93, 28);
            btnMatricula.TabIndex = 56;
            btnMatricula.Text = "Registrarse";
            btnMatricula.UseVisualStyleBackColor = false;
            btnMatricula.Click += btnMatricula_Click;
            // 
            // textMatEst
            // 
            textMatEst.Location = new Point(244, 50);
            textMatEst.Margin = new Padding(4, 3, 4, 3);
            textMatEst.MaxLength = 9;
            textMatEst.Name = "textMatEst";
            textMatEst.Size = new Size(130, 20);
            textMatEst.TabIndex = 56;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(240, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 18);
            label4.TabIndex = 55;
            label4.Text = "Matrícula:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 59);
            label3.TabIndex = 56;
            label3.Text = "Para ejercer su derecho al voto, necesita introducir su número de matrícula";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(20, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 55;
            label2.Text = "Importante:";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(34, 29);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 23);
            label5.TabIndex = 55;
            label5.Text = "Foto de la Candidata:";
            // 
            // VentanaVotar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(541, 436);
            Controls.Add(label5);
            Controls.Add(groupEstudiante);
            Controls.Add(btnVotar);
            Controls.Add(btnCancelar);
            Controls.Add(groupCandidata);
            Controls.Add(pictureFoto);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VentanaVotar";
            Text = "Votación Reina y Miss Fotogenia";
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            groupCandidata.ResumeLayout(false);
            groupEstudiante.ResumeLayout(false);
            groupEstudiante.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.GroupBox groupCandidata;
        private System.Windows.Forms.Label labelApe;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboMat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMatEst;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Label label5;
    }
}