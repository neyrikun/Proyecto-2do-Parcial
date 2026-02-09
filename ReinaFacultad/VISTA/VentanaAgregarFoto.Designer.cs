namespace VISTA
{
    partial class VentanaAgregarFoto
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
            this.labelApe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textNameFoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMatricula = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboAlbunes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFoto = new System.Windows.Forms.OpenFileDialog();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkImportar = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelApe
            // 
            this.labelApe.Location = new System.Drawing.Point(89, 95);
            this.labelApe.Name = "labelApe";
            this.labelApe.Size = new System.Drawing.Size(134, 16);
            this.labelApe.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Apellidos:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Albunes:";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(89, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 17);
            this.labelName.TabIndex = 51;
            // 
            // textNameFoto
            // 
            this.textNameFoto.Location = new System.Drawing.Point(18, 40);
            this.textNameFoto.MaxLength = 15;
            this.textNameFoto.Name = "textNameFoto";
            this.textNameFoto.Size = new System.Drawing.Size(112, 20);
            this.textNameFoto.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre de la Foto:";
            // 
            // comboMatricula
            // 
            this.comboMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMatricula.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMatricula.ItemHeight = 15;
            this.comboMatricula.Items.AddRange(new object[] {
            "200407801",
            "200508880"});
            this.comboMatricula.Location = new System.Drawing.Point(92, 31);
            this.comboMatricula.Name = "comboMatricula";
            this.comboMatricula.Size = new System.Drawing.Size(131, 23);
            this.comboMatricula.TabIndex = 50;
            this.comboMatricula.SelectedIndexChanged += new System.EventHandler(this.comboMatricula_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.Location = new System.Drawing.Point(133, 315);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 24);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Agregar Foto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Location = new System.Drawing.Point(247, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 24);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboAlbunes);
            this.groupBox1.Controls.Add(this.labelApe);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.comboMatricula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(204, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 164);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Candidata:";
            // 
            // comboAlbunes
            // 
            this.comboAlbunes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlbunes.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAlbunes.ItemHeight = 15;
            this.comboAlbunes.Items.AddRange(new object[] {
            "200407801",
            "200508880"});
            this.comboAlbunes.Location = new System.Drawing.Point(92, 122);
            this.comboAlbunes.Name = "comboAlbunes";
            this.comboAlbunes.Size = new System.Drawing.Size(131, 23);
            this.comboAlbunes.TabIndex = 53;
            this.comboAlbunes.SelectedIndexChanged += new System.EventHandler(this.comboAlbunes_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Matrícula:";
            // 
            // openFoto
            // 
            this.openFoto.DefaultExt = "jpg";
            this.openFoto.Filter = "Image Files(*.JPG)|*.JPG";
            this.openFoto.FilterIndex = 2;
            this.openFoto.RestoreDirectory = true;
            // 
            // pictureFoto
            // 
            this.pictureFoto.Location = new System.Drawing.Point(35, 22);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(107, 134);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFoto.TabIndex = 45;
            this.pictureFoto.TabStop = false;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(201, 35);
            this.textDescripcion.MaxLength = 150;
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescripcion.Size = new System.Drawing.Size(205, 69);
            this.textDescripcion.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Descripción de la Foto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkImportar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textDescripcion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textNameFoto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 124);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Foto:";
            // 
            // lnkImportar
            // 
            this.lnkImportar.AutoSize = true;
            this.lnkImportar.Location = new System.Drawing.Point(34, 77);
            this.lnkImportar.Name = "lnkImportar";
            this.lnkImportar.Size = new System.Drawing.Size(79, 13);
            this.lnkImportar.TabIndex = 55;
            this.lnkImportar.TabStop = true;
            this.lnkImportar.Text = "Insertar Foto";
            this.lnkImportar.UseWaitCursor = true;
            this.lnkImportar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImportar_LinkClicked);
            // 
            // VentanaAgregarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(472, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureFoto);
            this.Name = "VentanaAgregarFoto";
            this.Text = "Reina FIEC-Agregar Foto a la Candidata";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFoto;
        private System.Windows.Forms.Label labelApe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textNameFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMatricula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.ComboBox comboAlbunes;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkImportar;

    }
}