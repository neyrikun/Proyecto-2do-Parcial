/*
 *	Archivo: VentanaVotar.cs
 *	Descripcion: Contiene la clase VentanaVerFotosEstud que maneja 
 *               la votación por parte de los estudiantes
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
using System.IO;
using MODELO;

namespace VISTA
{
    public partial class VentanaVotar : Form
    {
        VentanaEstudiante vEstud;
        Voto votito = new Voto();
        Candidata cand = new Candidata();
        /*
         *	Método: VentanaVotar
         *	==========================================
         *	Me crea una nueva ventana para la votacion 
         *  de las candidatas por parte del estudiante.
         */
        public VentanaVotar(VentanaEstudiante vEstud)
        {
            this.vEstud = vEstud;
            InitializeComponent();
            btnVotar.Enabled = false;
            groupCandidata.Enabled = false;
        }
        /*
         *	Método: btnCancelar_Click
         *	==========================================
         *	Me permite manejar el evento de salir de
         *  esta ventana.
         */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            vEstud.Show();
        }
        /*
         *	Método: btnMatricula_Click
         *	===========================================
         *	Me permite registrar la matricula del estu-
         *  diante que desea votar y me permite validar
         *  en que categorías el estudiante ya ha ejer-
         *  cido su derecho al voto.
         */
        private void btnMatricula_Click(object sender, EventArgs e)
        {
            if (validarMatricula(textMatEst.Text.Trim()) == true)
            {
                comboTipo.Items.Clear();
                comboTipo.Items.AddRange(votito.getCategorias(textMatEst.Text.Trim()));
                if (comboTipo.Items.Count == 0)
                {
                    MessageBox.Show("Usted ya ha efectuado las votaciones en todas las categorías", "Reina FIEC: Votación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnVotar.Enabled = true;
                    groupCandidata.Enabled = true;
                    textMatEst.Enabled = false;
                    btnMatricula.Enabled = false;
                    comboMat.Items.Clear();
                    comboMat.Items.AddRange(Candidata.getListadoMatriculas());
                }
            }
            else
                MessageBox.Show("Inroduzca un numero de Matricula Válido", "Reina FIEC: Votación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*
         *	Método: comboMat_SelectedIndexChanged
         *	=============================================
         *	Me permite manejar el evento de mostrar la 
         *  foto y los datos de la candidata seleccionada
         */
        private void comboMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cand = Candidata.buscarXnumMatricula(comboMat.Text.Trim());
            labelName.Text = cand.Nombre;
            labelApe.Text = cand.Apellido;
            if (cand.Foto is not string)
                pictureFoto.Load(cand.Foto);
        }
        /*
         *	Método: btnVotar_Click
         *	=============================================
         *	Me permite manejar el evento de registrar el 
         *  voto y el numero de matricula del votante.
         */
        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (textMatEst.Text.Trim().CompareTo("") != 0 && cand.CodMatricula.CompareTo("") != 0)
            {
                votito = new Voto(textMatEst.Text.Trim(), cand.CodMatricula, comboTipo.Text.Trim());
                votito.guardar();
                this.Dispose();
                vEstud.Show();
            }
            else
                MessageBox.Show("Seleccione una candidata y/o una Dignidad a escojer", "Reina FIEC-Votación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*	
         *	Método: validarNumeros
         *	========================================
         *	me permite validar un numero de matricu-
         *  la o la edad de la candidata.
         */
        private bool validarNumeros(string line)
        {
            int i;
            for (i = 0; i < line.Length; i++)
            {
                if (line[i] > '9' || line[i] < '0')
                    return false;
            }
            return true;
        }
        /*	
        *	Método: validarMatricula
        *	========================================
        *	me permite validar que la matricula de 
        *   la candidata tenga 9 digitos y que no co-
        *   ntengan caracteres
        */
        private bool validarMatricula(string matCand)
        {
            if (matCand.Length < 9)
                return false;
            else
                return (validarNumeros(matCand));
        }
    }
}