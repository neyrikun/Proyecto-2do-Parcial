using System.Collections;
using MODELO;

namespace CONTROLADOR
{
    public class CandidataController
    {
        // =========================
        // CREAR Y GUARDAR
        // =========================
        public void RegistrarCandidata(string mat, string nombre, string apellido,
            string edad, string email, string carrera, string asp,
            string pas, string foto, string hab, string inter)
        {
            Candidata cand = new Candidata(
                mat, nombre, apellido, edad, email,
                carrera, asp, pas, foto, hab, inter
            );

            cand.guardar();
        }

        // =========================
        // BUSCAR
        // =========================
        public Candidata BuscarCandidata(string matricula)
        {
            return Candidata.buscarXnumMatricula(matricula);
        }

        // =========================
        // LISTAR TODAS
        // =========================
        public ArrayList ObtenerCandidatas()
        {
            return Candidata.obtenerListCandidatas();
        }
    }
}