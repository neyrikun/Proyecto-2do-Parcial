/*
 *	Archivo: VentanaEstudiante.cs
 *	Descripcion: Contiene la clase VentanaEstudiante que maneja 
 *               la presentacion de los datos de las candidatas 
 *               y la opcion de votación.   
 *	Autor:	 Franklin Parrales
 *	Fecha de creacion: 2007-07-07
 */

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using MODELO;
using OBJETO_VISTA;


namespace VISTA
{
	/*
	 *	Clase:VentanaPrincipal
	 *	======================
	 *	Maneja los controles y eventos de la Ventana
	 *	Principal del Programa
	 */

	public class VentanaEstudiante : System.Windows.Forms.Form 
	{	
		private ArrayList particulos=new ArrayList(); //arreglo de PictureBox articulos
		private ArrayList categorias=new ArrayList(); //arreglo de las categorias
		private ArrayList aagregar=new ArrayList();  //arreglo de los labels agregar
        private VentanaCandidataEstud vCandidata=null;


		#region Controles de la Forma

        private System.Windows.Forms.Panel panelarticulos;	//arreglo de objeto categoria
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox plogo;
        private Button button5;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panelcategorias;

		#endregion

		/*
		 *	Constructor: VentanaPrincipal
		 *	=========================
		 *	Constructor que inicializa los componentes de la forma
		 *	y carga las categorias y artículos de los archivos
		 */

        public VentanaEstudiante()
		{
			InitializeComponent();
            mostrarFotos(Candidata.obtenerListCandidatas());
			
		}

		/*
		 *	Método: Dispose 
		 *	===============
		 *	Maneja el evento e eliminar la ventana
		 */

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(VentanaEstudiante));
            panelarticulos = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            plogo = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button1 = new Button();
            panelcategorias = new Panel();
            panelarticulos.SuspendLayout();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)plogo).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelarticulos
            // 
            panelarticulos.AutoScroll = true;
            panelarticulos.Controls.Add(pictureBox7);
            panelarticulos.Controls.Add(pictureBox6);
            panelarticulos.Controls.Add(pictureBox5);
            panelarticulos.Controls.Add(pictureBox4);
            panelarticulos.Controls.Add(pictureBox3);
            panelarticulos.Location = new Point(173, 108);
            panelarticulos.Name = "panelarticulos";
            panelarticulos.Size = new Size(557, 591);
            panelarticulos.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(414, 17);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(79, 99);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(328, 17);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(79, 99);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(241, 17);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(79, 99);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(155, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(79, 99);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(68, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(plogo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 108);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(834, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // plogo
            // 
            plogo.BorderStyle = BorderStyle.FixedSingle;
            plogo.Location = new Point(778, 20);
            plogo.Name = "plogo";
            plogo.Size = new Size(142, 69);
            plogo.TabIndex = 4;
            plogo.TabStop = false;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(310, 71);
            label3.Name = "label3";
            label3.Size = new Size(345, 20);
            label3.TabIndex = 3;
            label3.Text = "Principal";
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(242, 70);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Estas en:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 78);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(238, 10);
            label1.Name = "label1";
            label1.Size = new Size(301, 40);
            label1.TabIndex = 0;
            label1.Text = "REINA FIEC 2026";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(730, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 591);
            panel2.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(49, 49);
            button5.Name = "button5";
            button5.Size = new Size(135, 30);
            button5.TabIndex = 19;
            button5.Text = "Votar";
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(49, 86);
            button1.Name = "button1";
            button1.Size = new Size(135, 30);
            button1.TabIndex = 15;
            button1.Text = "Salir";
            button1.Click += button1_Click;
            // 
            // panelcategorias
            // 
            panelcategorias.AutoScroll = true;
            panelcategorias.BackColor = Color.Black;
            panelcategorias.BorderStyle = BorderStyle.FixedSingle;
            panelcategorias.Location = new Point(0, 108);
            panelcategorias.Name = "panelcategorias";
            panelcategorias.Size = new Size(173, 591);
            panelcategorias.TabIndex = 0;
            // 
            // VentanaEstudiante
            // 
            AutoScaleBaseSize = new Size(6, 16);
            BackColor = Color.White;
            ClientSize = new Size(947, 697);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelcategorias);
            Controls.Add(panelarticulos);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "VentanaEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reina FIEC-Panel Estudiante";
            panelarticulos.ResumeLayout(false);
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)plogo).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion

        /*	
		 *	Método: mostrarFotos
		 *	====================
		 *	Muestra las fotos de los artículos en la 
		 *	ventana asi como su respectivo Label 
		 *	agregar al carrito de compras
		 */
        private void mostrarFotos(ArrayList candidatas)
        {
            int fila = 0, columna = 0;
            Candidata c;
            FotoCandidata fotoC;
            
            for (int i = 0; i < candidatas.Count; i++)
            {
                c = (Candidata)candidatas[i];

                #region Agrega las fotos y las etiquetas agregar

                fotoC = new FotoCandidata(c, columna, fila);
                fotoC.Click += new System.EventHandler(this.foto_Click);
                LabelDatosFoto lcandidata = new LabelDatosFoto(c, columna, fila);
                //Las agrego a mi panel de resultados
                panelarticulos.Controls.Add(lcandidata);
                panelarticulos.Controls.Add(fotoC);
                particulos.Add(fotoC);
                particulos.Add(lcandidata);

                columna++;

                if (columna > 2)
                {
                    fila++;
                    columna = 0;
                }

                #endregion
            }
        }

		/*
		 *	Método: foto_Click
		 *	==================
		 *	Maneja el evento de hacer click a la imagen del artículo
		 *	muestra una ventana especificando los detalles del 
		 *	artículo
		 */
        
        private void foto_Click(object sender, System.EventArgs e)
        {

            if (vCandidata != null)
                vCandidata.Dispose();
            vCandidata = new VentanaCandidataEstud( this,((FotoCandidata)sender).C);
            vCandidata.Show();
        }
	
		/*
		 *	Método: button1_Click 
		 *	=====================
		 *	Maneja el evento de hacer click al boton de
		 *	salir del programa
		 */

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
            VentanaLogin nLog = new VentanaLogin();
            nLog.Show();
		}

        private void button5_Click(object sender, EventArgs e)
        {
            VentanaVotar vVotar = new VentanaVotar(this);
            this.Hide();
            vVotar.Show();
        }
	}
}

