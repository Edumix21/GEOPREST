using System;

namespace GEOPREST.com.data {
    public class Estadistica {
        public ProblemaAlumno[] GenerarProblema(int numAlumnos, string ejercicio, int minDatos, int maxDatos,
            double limInf, double limSup, int numDecimales) {
            Random rand = new Random();
            double sumatoriaDatos = 0;

            // Generamos el número de datos al azar
            int numDatos = rand.Next(minDatos, maxDatos + 1);

            //Se genera un array de problemas con el numero indicado
            ProblemaAlumno[] alumno = new ProblemaAlumno[numAlumnos];

            // Bucle para generar los datos aleatorios, generar la sumatoria y guardarlos en un objeto alumno
            // La variable i controla el número de alumnos, la j el número de datos
            for (int i = 0; i < numAlumnos; i++) {
                sumatoriaDatos = 0;
                alumno[i] = new ProblemaAlumno();
                double[] valoresRdm = new double[numDatos];
                for (int j = 0; j < numDatos; j++) {
                    // Genera un número aleatorio entre rangoMinimo y rangoMaximo
                    double numeroAleatorio = limInf + (limSup - limInf) * rand.NextDouble();
                    // Redondea el número al número deseado de decimales
                    double factor = Math.Pow(10, numDecimales);
                    numeroAleatorio = Math.Round(numeroAleatorio * factor) / factor;
                    valoresRdm[j] = numeroAleatorio;

                    // Sumatoria de los datos para calcular la media después
                    sumatoriaDatos += valoresRdm[j];
                }

                // Redondeamos la variable sumatoria a 4 decimales
                double factorSum = Math.Pow(10, 4);
                sumatoriaDatos = Math.Round(sumatoriaDatos * factorSum) / factorSum;

                // Asignamos los valores de la sumatoria, los datos aleatorios y el texto del ejercicio
                alumno[i].Sumatoria = sumatoriaDatos;
                alumno[i].Valores = valoresRdm;
                alumno[i].Ejercicio = ejercicio;
            }

            // Establecemos los Datos de los alumnos calculando todas las variables necesarias
            for (int i = 0; i < numAlumnos; i++) {
                alumno[i].Media = CalcularMedia(numDatos, alumno[i].Sumatoria);

                // Datos en la muestra, media, array con los números aleatorios, bool población/muestra
                alumno[i].Varianza = CalcularVarianza(numDatos, alumno[i].Media, alumno[i].Valores, false);

                alumno[i].Desviacion = CalcularDesviacion(alumno[i].Varianza);

                alumno[i].CoeficienteVar = CalcularCoeficienteVar(alumno[i].Desviacion, alumno[i].Media);
            }
            return alumno;
        }

        private static double CalcularMedia(int numDatos, double sumatoria) {
            double media = sumatoria / numDatos;
            double factor = Math.Pow(10, 4);
            media = Math.Round(media * factor) / factor;
            return media;
        }

        // valor booleano true = poblacion, false = muestra
        private static double CalcularVarianza(int numDatos, double media, double[] muestra, bool isMuestra) {
            double varianza;
            double sumaDiferenciasCuadradas = 0;

            for (int i = 0; i < numDatos; i++) {
                double diferencia = muestra[i] - media;
                sumaDiferenciasCuadradas += Math.Pow(diferencia, 2);
            }

            if (!isMuestra) {
                numDatos -= 1;
            }

            varianza = sumaDiferenciasCuadradas / numDatos;
            double factor = Math.Pow(10, 4);
            varianza = Math.Round(varianza * factor) / factor;

            return varianza;
        }

        private static double CalcularDesviacion(double varianza) {
            double desviacion = Math.Sqrt(varianza);

            double factor = Math.Pow(10, 4);
            desviacion = Math.Round(desviacion * factor) / factor;

            return desviacion;
        }

        private static double CalcularCoeficienteVar(double desviacion, double media) {
            double coeficiente = (desviacion / media) * 100;

            double factor = Math.Pow(10, 4);
            coeficiente = Math.Round(coeficiente * factor) / factor;

            return coeficiente;
        }

        public static bool VerificarResultado(double respuestaAlumno, double resultado) {
            double margenDeError = 0.01;
            return Math.Abs(respuestaAlumno - resultado) <= margenDeError;
        }
    }
}
