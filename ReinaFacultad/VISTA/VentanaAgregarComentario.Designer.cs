namespace VISTA
{
    partial class VentanaAgregarComentario
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
            textTitulo = new TextBox();
            textUsuario = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textDescripcion = new TextBox();
            label3 = new Label();
            btn_Salir = new Button();
            btnGuardar = new Button();
            pictureFoto = new PictureBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textTitulo);
            groupBox1.Controls.Add(textUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textDescripcion);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(201, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(272, 197);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Candidata:";
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(98, 50);
            textTitulo.Margin = new Padding(4, 3, 4, 3);
            textTitulo.MaxLength = 150;
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(140, 20);
            textTitulo.TabIndex = 80;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(98, 20);
            textUsuario.Margin = new Padding(4, 3, 4, 3);
            textUsuario.MaxLength = 150;
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(140, 20);
            textUsuario.TabIndex = 79;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 78;
            label1.Text = "Título:";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 18);
            label5.TabIndex = 59;
            label5.Text = "Usuario:";
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(18, 98);
            textDescripcion.Margin = new Padding(4, 3, 4, 3);
            textDescripcion.MaxLength = 150;
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.ScrollBars = ScrollBars.Vertical;
            textDescripcion.Size = new Size(238, 79);
            textDescripcion.TabIndex = 76;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 76);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 18);
            label3.TabIndex = 77;
            label3.Text = "Comentario:";
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(224, 224, 224);
            btn_Salir.Location = new Point(293, 224);
            btn_Salir.Margin = new Padding(4, 3, 4, 3);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(93, 28);
            btn_Salir.TabIndex = 75;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(224, 224, 224);
            btnGuardar.Location = new Point(92, 224);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 28);
            btnGuardar.TabIndex = 74;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pictureFoto
            // 
            pictureFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureFoto.Location = new Point(30, 31);
            pictureFoto.Margin = new Padding(4, 3, 4, 3);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(133, 154);
            pictureFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureFoto.TabIndex = 73;
            pictureFoto.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(192, 224);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(93, 28);
            button1.TabIndex = 81;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // VentanaAgregarComentario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(485, 261);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btn_Salir);
            Controls.Add(btnGuardar);
            Controls.Add(pictureFoto);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VentanaAgregarComentario";
            Text = "Reina FIEC-Agregar Comentario";
            Load += VentanaAgregarComentario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label1;
    }
}