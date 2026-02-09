/*
 *	Archivo: VentanaResultados.cs
 *	Descripcion: Contiene la clase VentanaVerFotosEstud que maneja 
 *               la presentacion de los resultados de las elecciones
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
    public partial class VentanaResultados : Form
    {
        VentanaPrincipal vPrin;
        Voto votito = new Voto();
        private ArrayList pCandidatas = new ArrayList();
        private VentanaCandidata vCandidata = null;
        /*	
         *	Método: VentanaResultados
         *	========================================
         *	Me permite crear una nueva ventana para
         *  presentar los resultados obtenidos por la
         *  votación.
         */
        public VentanaResultados(VentanaPrincipal vPrin)
        {
            this.vPrin = vPrin;
            InitializeComponent();
            comboCateg.Items.Clear();
            comboCateg.Items.Add("Reina FIEC");
            comboCateg.Items.Add("Miss Fotogenia");
            votito.generarResultados();
            label4.Enabled = false;
            
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
            int fila = 0, columna = 0;
            Candidata c;
            FotoCandidata fotoC;
            LabelVotar lvotacion;

            for (int i = 0; i < candidatas.Count; i++)
            {
                c = (Candidata)candidatas[i];

                #region Agrega las fotos y las etiquetas agregar

                fotoC = new FotoCandidata(c, columna, fila);
                fotoC.Click += new System.EventHandler(this.foto_Click);
                lvotacion = new LabelVotar(c, columna, fila, comboCateg.Text.Trim());
                //Las agrego a mi panel de resultados
                panelCandidatas.Controls.Add(lvotacion);
                panelCandidatas.Controls.Add(fotoC);
                pCandidatas.Add(fotoC);
                pCandidatas.Add(lvotacion);
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
            vCandidata = new VentanaCandidata(vPrin, ((FotoCandidata)sender).C);
            vCandidata.Show();
        }
        /*
         *	Método: button1_Click
         *	==============================================
         *	Maneja el evento de hacer salir de la ventana 
         *  de resultados y volver al menu principal del 
         *  administrador
         */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            vPrin.Show();
        }
        /*
         *	Método: comboCateg_SelectedIndexChanged
         *	==================================================
         *	Maneja el evento de mostrar los puntajes obtenidos
         *  de las cada una de las candidatas en la categoría 
         *  seleccionada.
         */
        private void comboCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboCateg.Text.Trim();
            label4.Enabled = true;
            panelCandidatas.Controls.Clear();
            panelCandidatas.Controls.Clear();
            pCandidatas.Clear();
            pCandidatas.Clear();
            mostrarFotos(Candidata.obtenerListCandidatas());
            string codMat = votito.obtenerMasVotada(comboCateg.Text.Trim());
            Candidata cand = new Candidata();
            cand = Candidata.buscarXnumMatricula(codMat);
            if (cand.Foto is not string)
                pictureFoto.Load(cand.Foto);
        }
        /*
         *	Método: button2_Click
         *	==================
         *	Maneja el evento de hacer click al boton de
		 *	ingresar una nueva candidata
         */
        private void button2_Click(object sender, EventArgs e)
        {
            VentanaFormulario vForm = new VentanaFormulario(this.vPrin);
            this.Hide();
            vForm.Show();
        }
        /*
         *	Método: button3_Click
         *	==================
         *	Maneja el evento de hacer click al boton de
         *	crear un nuevo album de fotos a la candidata
         */
        private void button3_Click(object sender, EventArgs e)
        {
            VentanaCrearAlbunes vCrear = new VentanaCrearAlbunes(this.vPrin);
            this.Hide();
            vCrear.Show();
        }
        /*
         *	Método: button4_Click
         *	==================
         *	Maneja el evento de hacer click al boton de
         *	Agregar una nueva foto a la candidata
         */
        private void button4_Click(object sender, EventArgs e)
        {
            VentanaAgregarFoto vAdd = new VentanaAgregarFoto(this.vPrin);
            this.Hide();
            vAdd.Show();
        }
        /*
         *	Método: button7_Click
         *	==================
         *	Maneja el evento de hacer click al boton de
         *	visualizar las 5 candidatas mas comentareadas
         */
        private void button7_Click(object sender, EventArgs e)
        {
            VentanaComentariadas vCom = new VentanaComentariadas(this.vPrin);
            this.Hide();
            vCom.Show();
        }
    }
}