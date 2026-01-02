using System.Text;
using System;

namespace GEOPREST.com.data {
    public class ProblemaAlumno {
        private string ejercicio;
        private int numDatos;
        private double[] valores;
        private double sumatoria;
        private double media;
        private double varianza;
        private double desviacion;
        private double coeficienteVar;
        private bool isAgrupados;

        //Constructor vacio
        public ProblemaAlumno() {
        }

        //Constructor con los parametros necesarios para su generacion
        public ProblemaAlumno(string ejercicio, int numDatos, double sumatoria, double media, double varianza, double desviacion, double coeficienteVar) {
            this.Ejercicio = ejercicio;
            this.NumDatos = numDatos;
            this.Sumatoria = sumatoria;
            this.Media = media;
            this.Varianza = varianza;
            this.Desviacion = desviacion;
            this.CoeficienteVar = coeficienteVar;
        }

        //Getters y Setters
        public bool IsAgrupados { get => isAgrupados; set => isAgrupados = value; }
        public string Ejercicio { get => ejercicio; set => ejercicio = value; }
        public int NumDatos { get => numDatos; set => numDatos = value; }
        public double[] Valores { get => valores; set => valores = value; }
        public double Sumatoria { get => sumatoria; set => sumatoria = value; }
        public double Media { get => media; set => media = value; }
        public double Varianza { get => varianza; set => varianza = value; }
        public double Desviacion { get => desviacion; set => desviacion = value; }
        public double CoeficienteVar { get => coeficienteVar; set => coeficienteVar = value; }

        //Guardar el arreglo de datos en texto
        public string ImprimirDatos(ProblemaAlumno a) {
            double[] n = a.valores;
            int filaActual = 0;
            string datos = "Numero de Datos: " + n.Length + "\nDatos: ";

            //Separar los datos en filas de 10 elementos
            for (int i = 0; i < n.Length; i++) {
                if (i % 10 == 0) {
                    filaActual++;
                    datos += "\n";
                }
                datos += n[i] + ", ";
            }
            datos += "\n\n";
            return datos;
        }

        //Guardar los resultados de los ejercicios en un texto
        public string ImprimirResultados() {
            string valoresI;
            char sumatoriaSimb = '\u03A3';
            char mediaSimb = '\u0305';
            char varianzaSimb = 's';
            valoresI = this.ejercicio +
                       "\n\n" + "Sumatoria (" + sumatoriaSimb + "): " + this.sumatoria +
                       "\nMedia (x" + mediaSimb + "): " + this.media +
                       "\n" + "Varianza (" + varianzaSimb + "²): " + this.varianza +
                       "\n" + "Desviación Estandar (" + varianzaSimb + "): " + this.desviacion +
                       "\nCoeficiente de Variación (c.v.): " + this.coeficienteVar + "\n\n";
            return valoresI;
        }

        //Dar formato de agrupacion a los datos y guardarlos en un string
        //flag = true significa que vamos a usar el formato para xml, false es una impresion normal
        public string ImprimirDatosAgrupados(ProblemaAlumno a, int nIntervalos, bool flag) {
            double[] valores = a.valores;
            int n = valores.Length;

            // Calcula el rango de los datos
            double min = double.MaxValue;
            double max = double.MinValue;
            foreach (double valor in valores) {
                if (valor < min) {
                    min = valor;
                }
                if (valor > max) {
                    max = valor;
                }
            }

            // Calcula el ancho del intervalo
            double rango = max - min;
            double intervalo = rango / nIntervalos;
            // Redondeamos a 4 decimales
            double factor = Math.Pow(10, 4);
            intervalo = Math.Round(intervalo * factor) / factor;

            // Inicializa un arreglo para contar la frecuencia de cada intervalo
            int[] frecuenciaIntervalos = new int[nIntervalos];

            // Cuenta la frecuencia de cada valor en el intervalo
            for (int i = 0; i < n; i++) {
                double valor = valores[i];
                for (int j = 0; j < nIntervalos; j++) {
                    double limiteInferior = min + (j * intervalo);
                    double limiteSuperior = min + ((j + 1) * intervalo);
                    if (valor >= limiteInferior && valor < limiteSuperior) {
                        frecuenciaIntervalos[j]++;
                        break;
                    }
                }
            }

            // Construir la cadena de salida en formato específico según flag
            StringBuilder resultado = new StringBuilder();
            resultado.Append("Amplitud de los intervalos: ").Append(intervalo);
            if (flag) {
                resultado.Append("<p></p><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><colgroup><col width=\"147\"><col width=\"54\"></colgroup><tbody>");
            } else {
                resultado.Append("\n");
            }

            for (int i = 0; i < nIntervalos; i++) {
                double limiteInferior = Math.Round((min + (i * intervalo)) * 10000) / 10000;
                double limiteSuperior = Math.Round((min + ((i + 1) * intervalo)) * 10000) / 10000;

                if (flag) {
                    resultado.Append("<tr><td>").Append(limiteInferior).Append(" - ").Append(limiteSuperior).Append("</td>")
                             .Append("<td>").Append(frecuenciaIntervalos[i]).Append("</td></tr>");
                } else {
                    resultado.Append(i + 1).Append(". ").Append(limiteInferior).Append(" - ").Append(limiteSuperior).Append(" : ")
                             .Append(frecuenciaIntervalos[i]).Append("\n");
                }
            }

            if (flag) {
                resultado.Append("</tbody></table><br>");
            }
            return resultado.ToString();

            //// Construye la cadena de salida
            //StringBuilder resultado = new StringBuilder();
            //resultado.Append("Amplitud de los intervalos: ").Append(intervalo).Append("\n");
            //if (flag) resultado.Append("<br>");
            //for (int i = 0; i < nIntervalos; i++) {
            //    double limiteInferior = min + (i * intervalo);
            //    limiteInferior = Math.Round(limiteInferior * factor) / factor;

            //    double limiteSuperior = min + ((i + 1) * intervalo);
            //    limiteSuperior = Math.Round(limiteSuperior * factor) / factor;

            //    resultado.Append(i + 1).Append(". [").Append(limiteInferior).Append(" - ")
            //            .Append(limiteSuperior).Append("] : ").Append(frecuenciaIntervalos[i]).Append("\n");
            //    if (flag) resultado.Append("<br>");
            //}
            //resultado.Append("\n");
            //if (flag) resultado.Append("<br>");
            //return resultado.ToString();
        }

    }
}
