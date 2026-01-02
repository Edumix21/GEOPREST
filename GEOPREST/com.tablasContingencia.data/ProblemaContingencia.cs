using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOPREST.com.tablasContingencia.data {
    public class ProblemaContingencia {
        private string ejercicio; //Texto del problema
        private int[,] tablaContingencia; //Tabla con los valores aleatorios
        private string[] nombresTabla; //nombres de las filas y columnas
        private string[] preguntas; //Preguntas seleccionadas aleatoriamente (P(a), P(b), etc)
        private double[] respuestas; //Valores de las respuestas a las preguntas seleccionadas anteriormente

        // Constructor vacío
        public ProblemaContingencia() {
        }

        // Constructor con parámetros
        public ProblemaContingencia(string ejercicio, int[,] tablaContingencia, string[] nombresTabla, string[] preguntas, double[] respuestas) {
            this.Ejercicio = ejercicio;
            this.TablaContingencia = tablaContingencia;
            this.NombresTabla = nombresTabla;
            this.Preguntas = preguntas;
            this.Respuestas = respuestas;
        }

        // Getters y Setters
        public string Ejercicio { get => ejercicio; set => ejercicio = value; }
        public int[,] TablaContingencia { get => tablaContingencia; set => tablaContingencia = value; }
        public string[] NombresTabla { get => nombresTabla; set => nombresTabla = value; }
        public string[] Preguntas { get => preguntas; set => preguntas = value; }
        public double[] Respuestas { get => respuestas; set => respuestas = value; }

    }
}
