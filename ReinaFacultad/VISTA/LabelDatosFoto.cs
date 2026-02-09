/*
 *	Archivo: LabelDatosFoto.cs
 *	Descripcion: Contiene la clase LabelComentarios que maneja 
 *               la presentacion del numero de comentarios de la 
 *               candidata.
 *	Autor:	 Franklin Parrales
 *	Fecha de creacion: 2007-07-07
 */
using MODELO;
using System;
using System.Windows.Forms;

namespace OBJETO_VISTA
{
    public partial class LabelDatosFoto : Label
    {
        private Candidata cand;
        private Comentario coment = new Comentario();
        private Voto votito = new Voto();
        /*
		 *	Método: LabelComentarios
		 *	=======================================
		 *	Crea un nuevo label a cada foto de las 
         *  candidatas que me indicará el numero de 
         *  comentarios obtenidos por parte de esta.
		 */
        public LabelDatosFoto(Candidata c, int columna, int fila)
        {
            this.cand = c;
            Location = new System.Drawing.Point((120 * columna) + 50, (135 * fila) + 95 + 95);
            Name = c.Nombre;
            AutoSize = true;
            TabIndex = 0;
            Text = c.Nombre + " " + c.Apellido; 
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

