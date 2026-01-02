using System;
using System.Collections.Generic;
using System.Linq;

namespace GEOPREST.com.probabilidad.data {
    internal class Probabilidad {
        private static Random random = new Random();

        //Circulos activos, valores de cada circulo, valor varExterna, valor de la interseccion
        public ProblemaVenn GenerarProblemasVenn(int[] circulos, string textoEjercicio) {

            //Calculamos la suma de todos los valores
            int sumatoria = 0;
            bool[] verCirculosActivos = new bool[4]; //Con esto comprobare si el ciculo A B y C estan activados
            
            for(int i = 0; i < circulos.Length; i++) {
                sumatoria += circulos[i];
                if (circulos[i] != 0) {

                    //Si el circulo tiene valor, lo marcamos como activo en el array
                    verCirculosActivos[i] = true;
                } else verCirculosActivos[i] = false;

            }

            //Verificar si la interseccion tiene valor para restar a la sumatoria
            if (circulos[3] != 0) {
                sumatoria -= circulos[3];
            }

            //Sacamos la probabilidad de cada valor
            double[] probValores = new double[4];
            for (int i = 0; i < probValores.Length; i++) {
                if (circulos[i] != 0) {
                    probValores[i] = circulos[i] / (double)sumatoria;
                    // Redondeamos el valor a 4 decimales
                    probValores[i] = Math.Round(probValores[i], 4);
                }
            }

            //Generamos los problemas que se van a pedir
            string[] datosProblema = GenerarInterseccion(verCirculosActivos);

            double[] solucionesProblema = new double[datosProblema.Length];

            for(int i = 0; i < datosProblema.Length; i++) {
                solucionesProblema[i] = ResolverConjunto(datosProblema[i], probValores);
            }

            //Damos formato a los ejercicios para guardarlo en el objeto
            string textoFinal = FormatoTextoEjercicio(textoEjercicio, datosProblema);

            ProblemaVenn p1 = new ProblemaVenn(textoEjercicio, datosProblema, circulos, solucionesProblema);

            return p1;
        }


        public string[] GenerarInterseccion(bool[] circulosActivos) {
            string[] posiblesProblemas;

            //En el caso de que los 3 circulos esten activos
            if (circulosActivos[0] && circulosActivos[1] && circulosActivos[2]) {
                posiblesProblemas = new string[] {
                    "P(B)",
                    "P(A ∩ B ∩ C)", 
                    "P(B')",
                    "P(A ∪ C)",
                    "P(A ∩ C)",
                    "P(A' ∪ C)", 
                    "P(C)",
                    "P((A ∩ B) ∪ C)", 
                    "P(C')",
                    "P(B ∪ C)",
                    "P(B ∩ C)",
                    "P(C' ∪ C)", 
                };
                //En caso de que solo los circulos A y B esten activos
            } else if (circulosActivos[0] && circulosActivos[1] && !circulosActivos[2]) {
                posiblesProblemas = new string[] {
                    "P(A)", 
                    "P(B)", 
                    "P(A')", 
                    "P(B')",
                    "P(A ∪ B)",
                    "P(A ∩ B)",
                    "P(A' ∪ B)", 
                };
                //En caso de que solo los circulos B y C esten activos
            } else if (!circulosActivos[0] && circulosActivos[1] && circulosActivos[2]) {
                posiblesProblemas = new string[] {
                    "P(C)", 
                    "P(B)", 
                    "P(C')", 
                    "P(B')",
                    "P(C ∪ B)",
                    "P(C ∩ B)",
                    "P(C' ∪ B)", 
                };
                //En caso de que solo los circulos A y C esten activos
            } else if (circulosActivos[0] && !circulosActivos[1] && circulosActivos[2]) {
                posiblesProblemas = new string[] {
                    "P(A)", 
                    "P(C)", 
                    "P(A')", 
                    "P(C')",
                    "P(A ∪ C)",
                    "P(A ∩ C)",
                    "P(A' ∪ C)", 
                };
            } else posiblesProblemas = new string[] { "" };

            //Generacion de 6 numeros aleatorios para los problemas
            HashSet<int> numeros = new HashSet<int>();

            while (numeros.Count < 6) {
                int numero = random.Next(1, posiblesProblemas.Length);
                if (!numeros.Contains(numero)) {
                    numeros.Add(numero);
                }
            }

            int[] array = numeros.ToArray();

            //Asignamos cada numero generado a un valor en el array string para retornar el problema
            string[] probFinales = {
                posiblesProblemas[array[0]],
                posiblesProblemas[array[1]],
                posiblesProblemas[array[2]],
                posiblesProblemas[array[3]],
                posiblesProblemas[array[4]],
                posiblesProblemas[array[5]],
            };

            return probFinales;
        }

        public double ResolverConjunto(string problema, double[] valores) {
            double resultado;

            if (problema.Equals("P(A)")) resultado = valores[0];
            else if (problema.Equals("P(B)")) resultado = valores[1];
            else if (problema.Equals("P(C)")) resultado = valores[2];
            else if (problema.Equals("P(A')")) resultado = 1 - valores[0];
            else if (problema.Equals("P(B')")) resultado = 1 - valores[1];
            else if (problema.Equals("P(C')")) resultado = 1 - valores[2];
            else if (problema.Equals("P(A ∪ B)")) resultado = valores[0] + valores[1] - valores[3];
            else if (problema.Equals("P(A ∩ B)")) resultado = valores[3];
            else if (problema.Equals("P(A' ∪ B)")) resultado = (1-valores[0]) + valores[1];
            else if (problema.Equals("P(A ∪ C)")) resultado = valores[0] + valores[2];
            else if (problema.Equals("P(A ∩ C)")) resultado = 0;
            else if (problema.Equals("P(A' ∪ C)")) resultado = (1-valores[0]) + valores[2];
            else if (problema.Equals("P(C ∪ B)") || problema.Equals("B u C")) resultado = valores[1] + valores[2];
            else if (problema.Equals("P(C ∩ B)") || problema.Equals("B n C")) resultado = 0;
            else if (problema.Equals("P(C' ∪ B)")) resultado = valores[1];
            else if (problema.Equals("P(C' ∪ C)")) resultado = 1;
            else if (problema.Equals("P(A ∩ B ∩ C)")) resultado = 0;
            else if (problema.Equals("P((A ∩ B) ∪ C)")) resultado = valores[3] + valores[2];
            else resultado = 0;

            return resultado;
        }

        private string FormatoTextoEjercicio(string textoEjercicio, string[] problemas) {
            string textoFinal = textoEjercicio + "\n\n" + problemas[0] + "\n" + problemas[1] + "\n" + problemas[2] + "\n" + problemas[3] + "\n" + problemas[4] + "\n" + problemas[5];

            return textoFinal;
        }
    }
}
