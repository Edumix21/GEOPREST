using System;

namespace GEOPREST.com.distribucionBinomial.data {
    /// <summary>
    /// Representa un problema de distribución binomial.
    /// </summary>
    public class ProblemaDistBinomial {
        string descripcion;               // Contexto del problema
        int ensayos;                     // Número de ensayos (n)
        double probabilidadExito;        // Probabilidad de éxito en cada ejercicio
        int k;                           // Límite superior
        int? kInferior;                  // Límite inferior si se trata de un intervalo
        string tipoPregunta;             // Tipo de pregunta: "exacto", "a lo sumo", "al menos", "intervalo"
        double respuesta;                // Resultado calculado (probabilidad)

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public ProblemaDistBinomial() { }

        /// <summary>
        /// Constructor principal para problemas de distribución binomial.
        /// </summary>
        /// <param name="descripcion">Contexto o enunciado del problema.</param>
        /// <param name="ensayos">Número de ensayos (n).</param>
        /// <param name="probabilidadExito">Probabilidad de éxito en cada ensayo (p).</param>
        /// <param name="k">Límite superior o valor específico k.</param>
        /// <param name="kInferior">Límite inferior si se trata de un intervalo (null en caso contrario).</param>
        /// <param name="tipoPregunta">Tipo de pregunta: "exacto", "a lo sumo", "al menos", "intervalo".</param>
        /// <param name="respuesta">Resultado calculado (probabilidad).</param>
        public ProblemaDistBinomial(
            string descripcion,
            int ensayos,
            double probabilidadExito,
            int k,
            int? kInferior,
            string tipoPregunta,
            double respuesta
        ) {
            Descripcion = descripcion;
            Ensayos = ensayos;
            ProbabilidadExito = probabilidadExito;
            K = k;
            KInferior = kInferior;
            TipoPregunta = tipoPregunta;
            Respuesta = respuesta;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Ensayos { get => ensayos; set => ensayos = value; }
        public double ProbabilidadExito { get => probabilidadExito; set => probabilidadExito = value; }
        public int K { get => k; set => k = value; }
        public int? KInferior { get => kInferior; set => kInferior = value; }
        public string TipoPregunta { get => tipoPregunta; set => tipoPregunta = value; }
        public double Respuesta { get => respuesta; set => respuesta = value; }

        public string GenerarEjercicioFormateado(double prob, int ens) {
            // Este método solo necesita reemplazar los marcadores de posición si la descripción base los tiene
            // La descripción ya viene pre-formateada desde DistBinomial.cs con n y p para el problema principal
            // No es necesario modificarla aquí con los n y p de la subpregunta
            return Descripcion; // Devolver la descripción tal cual la recibe, ya que se llenará en DistBinomial.cs
        }
    }
}