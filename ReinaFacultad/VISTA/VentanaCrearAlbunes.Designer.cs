namespace VISTA
{
    partial class VentanaCrearAlbunes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.codMatricula = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.listAlbunes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.textNameAlb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textAlbunes = new System.Windows.Forms.TextBox();
            this.labelApe = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(242, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(131, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Crear Album";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.codMatricula);
            this.groupDatos.Controls.Add(this.label4);
            this.groupDatos.Controls.Add(this.labelApellidos);
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.labelNombre);
            this.groupDatos.Controls.Add(this.listAlbunes);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Controls.Add(this.labelMatricula);
            this.groupDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatos.Location = new System.Drawing.Point(199, 19);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(239, 245);
            this.groupDatos.TabIndex = 44;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos de la Candidata:";
            // 
            // codMatricula
            // 
            this.codMatricula.Location = new System.Drawing.Point(0, 0);
            this.codMatricula.Name = "codMatricula";
            this.codMatricula.Size = new System.Drawing.Size(121, 21);
            this.codMatricula.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(89, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 47;
            // 
            // labelApellidos
            // 
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(16, 87);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(96, 16);
            this.labelApellidos.TabIndex = 46;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(89, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 45;
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(16, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(96, 16);
            this.labelNombre.TabIndex = 44;
            this.labelNombre.Text = "Nombre:";
            // 
            // listAlbunes
            // 
            this.listAlbunes.FormattingEnabled = true;
            this.listAlbunes.Location = new System.Drawing.Point(19, 163);
            this.listAlbunes.Name = "listAlbunes";
            this.listAlbunes.Size = new System.Drawing.Size(204, 69);
            this.listAlbunes.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Albunes Creados:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(16, 23);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(96, 16);
            this.labelMatricula.TabIndex = 38;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // textNameAlb
            // 
            this.textNameAlb.Location = new System.Drawing.Point(35, 234);
            this.textNameAlb.MaxLength = 25;
            this.textNameAlb.Name = "textNameAlb";
            this.textNameAlb.Size = new System.Drawing.Size(112, 20);
            this.textNameAlb.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nombre del nuevo Album:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textAlbunes);
            this.groupBox1.Controls.Add(this.labelApe);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(199, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 245);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Candidata:";
            // 
            // textAlbunes
            // 
            this.textAlbunes.Enabled = false;
            this.textAlbunes.Location = new System.Drawing.Point(18, 163);
            this.textAlbunes.MaxLength = 9;
            this.textAlbunes.Multiline = true;
            this.textAlbunes.Name = "textAlbunes";
            this.textAlbunes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAlbunes.Size = new System.Drawing.Size(205, 69);
            this.textAlbunes.TabIndex = 45;
            // 
            // labelApe
            // 
            this.labelApe.Location = new System.Drawing.Point(89, 95);
            this.labelApe.Name = "labelApe";
            this.labelApe.Size = new System.Drawing.Size(134, 16);
            this.labelApe.TabIndex = 52;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(89, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 17);
            this.labelName.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ItemHeight = 15;
            this.comboBox1.Items.AddRange(new object[] {
            "200407801",
            "200508880"});
            this.comboBox1.Location = new System.Drawing.Point(92, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 23);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Albunes Creados:";
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
            // VentanaCrearAlbunes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(460, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDatos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textNameAlb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "VentanaCrearAlbunes";
            this.Text = "Reina FIEC-Administrador-Crear Albunes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupDatos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ListBox listAlbunes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.TextBox textNameAlb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.ComboBox codMatricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelApe;
        private System.Windows.Forms.TextBox textAlbunes;
    }
}