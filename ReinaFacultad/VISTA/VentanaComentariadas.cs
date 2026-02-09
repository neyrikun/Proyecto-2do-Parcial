/*
 *	Archivo: VentanaComentariadas.cs
 *	Descripcion: Contiene la clase VentanaComentariadas que maneja 
 *               la presentación de las 5 candidatas que han obte-
 *               -nido la mayor cantidad de comentarios
 *	Autor:	 Franklin Parrales
 *	Fecha de creacion: 2007-07-07
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MODELO;
using OBJETO_VISTA;

namespace VISTA
{
    public partial class VentanaComentariadas : Form
    {
        Comentario coment = new Comentario();
        private ArrayList pCandidatas = new ArrayList();
        private VentanaCandidata vCandidata = null;
        VentanaPrincipal vPrin;
        /*
		 *	Método: VentanaComentariadas
		 *	========================================
		 *	Crea una nueva pantalla para ver las 5 
         *  candidatas que poseen la mayor canti-
         *  dad de comentarios.
		 */
        public VentanaComentariadas(VentanaPrincipal vPrin)
        {
            this.vPrin = vPrin;
            ArrayList listMasComent = new ArrayList();
            InitializeComponent();
            listMasComent = coment.lCandidatasMasComentareadas();
            mostrarFotos(listMasComent);
            string codCand = coment.obtenerMasComentareada();
            Candidata cand = new Candidata();
            cand = Candidata.buscarXnumMatricula(codCand);
            if (cand.Foto is not string)
                pictureFoto.Load(cand.Foto);
        }

        /*	
         *	Método: mostrarFotos
         *	====================
         *	Muestra las fotos de los artículos en la 
         *	ventana asi como su respectivo Label 
         *	agregar al carrito de compras
         */
        private void mostrarFotos(ArrayList candidatas)
        {
            int fila = 0, columna = 0, numCand = 0;
            Candidata c;
            FotoCandidata fotoC;
            LabelComentarios lComentarios;

            for (int i = 0; i < candidatas.Count; i++)
            {
                if (numCand < 5)
                {
                    c = (Candidata)candidatas[i];

                    #region Agrega las fotos y las etiquetas agregar

                    fotoC = new FotoCandidata(c, columna, fila);
                    fotoC.Click += new System.EventHandler(this.foto_Click);
                    lComentarios = new LabelComentarios(c, columna, fila);
                    //Las agrego a mi panel de resultados
                    panelCandidatas.Controls.Add(lComentarios);
                    panelCandidatas.Controls.Add(fotoC);
                    pCandidatas.Add(fotoC);
                    pCandidatas.Add(lComentarios);
                    columna++;
                    if (columna > 2)
                    {
                        fila++;
                        columna = 0;
                    }
                    #endregion
                    numCand++;
                }
                else
                    break;
            }
        }
        /*
         *	Método: foto_Click
         *	==================================================
         *	Maneja el evento de hacer click a la imagen de la
         *  candidata muestra una ventana especificando los de-
         *  talles de la candidata.
         */
        private void foto_Click(object sender, System.EventArgs e)
        {
            if (vCandidata != null)
                vCandidata.Dispose();
            vCandidata = new VentanaCandidata(vPrin, ((FotoCandidata)sender).C);
            vCandidata.Show();
        }
        /*
		 *	Método: button1_Click
		 *	==============================
		 *	Me permite activar el evento 
         *  para volver a la pantalla pri-
         *  ncipal.
		 */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            vPrin.Show();
        }
        /*
         *	Método: button2_Click
         *	=============================================
         *	Maneja el evento de hacer click al boton de
		 *	ingresar una nueva candidata
         */
        private void button2_Click(object sender, EventArgs e)
        {
            VentanaFormulario vformulario;
            vformulario = new VentanaFormulario(this.vPrin);
            vformulario.Show();
            this.Dispose();
        }
        /*
         *	Método: button3_Click
         *	==============================================
         *	Maneja el evento de hacer click al boton de
         *	crear un nuevo album de fotos a la candidata
         */
        private void button3_Click(object sender, EventArgs e)
        {
            VentanaCrearAlbunes vCAlbum = new VentanaCrearAlbunes(this.vPrin);
            vCAlbum.Show();
            this.Dispose();
        }
        /*
         *	Método: button4_Click
         *	=============================================
         *	Maneja el evento de hacer click al boton de
         *	Agregar una nueva foto a la candidata
         */
        private void button4_Click(object sender, EventArgs e)
        {
            VentanaAgregarFoto vFotos = new VentanaAgregarFoto(this.vPrin);
            vFotos.Show();
            this.Dispose();
        }
        /*
         *	Método: button6_Click
         *	==================
         *	Maneja el evento de hacer click al boton de
         *	visualizar los resultados de las elecciones.
         */
        private void button6_Click(object sender, EventArgs e)
        {
            VentanaResultados vResult = new VentanaResultados(this.vPrin);
            this.Dispose();
            vResult.Show();
        }

        private void VentanaComentariadas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}