/*
 *	Archivo: LabelVotar.cs
 *	Descripcion: Contiene la clase LabelComentarios que maneja 
 *               la presentacion del numero de votos  de la 
 *               candidata.
 *	Autor:	 Franklin Parrales
 *	Fecha de creacion: 2007-07-07
 */
using MODELO;
using System;
using System.Windows.Forms;

namespace OBJETO_VISTA
{
    public partial class LabelVotar : Label
    {
        private Candidata cand;
        private Voto votito = new Voto();
        /*
		 *	Método: LabelVotar
		 *	=======================================
		 *	Crea un nuevo label a cada foto de las 
         *  candidatas que me indicará el numero de 
         *  votos obtenidos por parte de esta.
		 */
        public LabelVotar(Candidata c, int columna, int fila,string categoria)
        {
            cand = c;

            Location = new System.Drawing.Point((120 * columna) + 50, (135 * fila) + 95 + 95);
            Name = c.CodMatricula;
            AutoSize = true;
            TabIndex = 0;
            Text = "Votos: "+votito.consultarVotos(c.CodMatricula,categoria);
            Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #region Get&Set

        public Candidata Cand
        {
            get
            {
                return (this.cand);
            }

            set
            {
                cand = value;
            }
        }

        #endregion
    }
}
