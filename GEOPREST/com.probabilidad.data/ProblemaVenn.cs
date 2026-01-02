
namespace GEOPREST.com.probabilidad.data {
    public class ProblemaVenn {
        private string ejercicio; //texto del ejercicio
        private string[] valEjercicios; //problemas a calcular (A u B...)
        //Primeros 3 valores = Numero real, Siguientes 3 valores = Numero Probabilidad
        private int[] circulos; //Valores enteros de los circulos generados
        private double[] resultados; //resultados de las probabilidades (A u B = 0.6232...)

        public ProblemaVenn() {

        }

        public ProblemaVenn(string ejercicio, string[] valEjercicios, int[] circulos, double[] resultados) {
            this.ejercicio = ejercicio;
            this.valEjercicios = valEjercicios;
            this.circulos = circulos;
            this.resultados = resultados;
        }

        public string Ejercicio { get => ejercicio; set => ejercicio = value; }
        public string[] ValEjercicios { get => valEjercicios; set => valEjercicios = value; }
        public int[] Circulos { get => circulos; set => circulos = value; }
        public double[] Resultados { get => resultados; set => resultados = value; }
    }
}
