using MODELO;
using System;

namespace CONTROLADOR
{
    public class VotoController
    {
        // =========================================
        // REGISTRAR VOTO
        // =========================================
        public void RegistrarVoto(string matEstudiante, string matCandidata, string categoria)
        {
            Voto v = new Voto();

            // validar si ya votó en esa categoría
            int yaVoto = v.validarSiVoto(matEstudiante, categoria);

            if (yaVoto > 0)
                throw new Exception("El estudiante ya votó en esta categoría");

            Voto nuevo = new Voto(matEstudiante, matCandidata, categoria);
            nuevo.guardar();
        }

        // =========================================
        // OBTENER CATEGORIAS DISPONIBLES PARA VOTAR
        // =========================================
        public object[] ObtenerCategoriasDisponibles(string matEstudiante)
        {
            Voto v = new Voto();
            return v.getCategorias(matEstudiante);
        }

        // =========================================
        // VALIDAR SI YA VOTÓ EN CATEGORIA
        // =========================================
        public bool YaVoto(string matEstudiante, string categoria)
        {
            Voto v = new Voto();
            int res = v.validarSiVoto(matEstudiante, categoria);
            return res > 0;
        }

        // =========================================
        // GENERAR RESULTADOS
        // =========================================
        public void GenerarResultados()
        {
            Voto v = new Voto();
            v.generarResultados();
        }

        // =========================================
        // CONSULTAR NUMERO DE VOTOS DE CANDIDATA
        // =========================================
        public int ConsultarVotos(string matCandidata, string categoria)
        {
            Voto v = new Voto();
            return v.consultarVotos(matCandidata, categoria);
        }

        // =========================================
        // OBTENER GANADORA POR CATEGORIA
        // =========================================
        public string ObtenerGanadora(string categoria)
        {
            Voto v = new Voto();
            return v.obtenerMasVotada(categoria);
        }
    }
}