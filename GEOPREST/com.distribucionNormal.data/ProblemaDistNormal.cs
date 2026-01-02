namespace GEOPREST.com.distribucionNormal.data {
    public class ProblemaDistNormal {
        string descripcion; // Contexto del problema (Ej: Tiempos de respuesta del servidor)
        double media; // Valor de la media (μ)
        double desviacion; // Valor de la desviación estándar (σ)
        double[] z; // Valor Z o límite superior del rango Z
        double[] zInferior; // Valor Z inferior si es un intervalo
        //string tipoPregunta; // Tipo de pregunta: acumulada o intervalo
        double[] respuesta; // Probabilidad calculada o resultado final

        public ProblemaDistNormal() { }

        public ProblemaDistNormal(string descripcion, double media, double desviacion, double[] z, double[] zInferior, /*string tipoPregunta,*/ double[] respuesta) {
            Descripcion = descripcion;
            Media = media;
            Desviacion = desviacion;
            Z = z;
            ZInferior = zInferior;
            //TipoPregunta = tipoPregunta;
            Respuesta = respuesta;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Media { get => media; set => media = value; }
        public double Desviacion { get => desviacion; set => desviacion = value; }
        public double[] Z { get => z; set => z = value; }
        public double[] ZInferior { get => zInferior; set => zInferior = value; }
        //public string TipoPregunta { get => tipoPregunta; set => tipoPregunta = value; }
        public double[] Respuesta { get => respuesta; set => respuesta = value; }
    }
}
