using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOPREST.com.tablasContingencia.data {
    internal class TablasContingencia {

        public ProblemaContingencia[] GenerarProblemas(int numProblemas, string nomFila, string nomColumna, string textoEjercicio, string valorTabla1, string valorTabla2, string valorTabla3, string valorTabla4, int numMin, int numMax) {

            Random rand = new Random();
            ProblemaContingencia[] problemas = new ProblemaContingencia[numProblemas];

            // Nombres de tabla (usados para la visualización)
            string[] nombresTabla = { nomColumna, nomFila, valorTabla1, valorTabla2, valorTabla3, valorTabla4 };

            for (int i = 0; i < numProblemas; i++) {
                // Generar tabla 2x2
                int[,] tabla = new int[2, 2];
                // Fila 1 (A)
                tabla[0, 0] = rand.Next(numMin, numMax + 1); // A y C (Cruce fila 1, col 1)
                tabla[0, 1] = rand.Next(numMin, numMax + 1); // A y D (Cruce fila 1, col 2)
                // Fila 2 (B)
                tabla[1, 0] = rand.Next(numMin, numMax + 1); // B y C (Cruce fila 2, col 1)
                tabla[1, 1] = rand.Next(numMin, numMax + 1); // B y D (Cruce fila 2, col 2)

                // Totales
                int totalFilaA = tabla[0, 0] + tabla[0, 1]; // Total A
                int totalFilaB = tabla[1, 0] + tabla[1, 1]; // Total B
                int totalColC = tabla[0, 0] + tabla[1, 0];  // Total C
                int totalColD = tabla[0, 1] + tabla[1, 1];  // Total D
                int totalGeneral = totalFilaA + totalFilaB;

                // --- CÁLCULOS DE PROBABILIDAD ---

                // Simples
                double pA = (double)totalFilaA / totalGeneral;
                double pB = (double)totalFilaB / totalGeneral; // Equivalente a P(A')
                double pC = (double)totalColC / totalGeneral;
                double pD = (double)totalColD / totalGeneral; // Equivalente a P(C')

                // Intersecciones (AND)
                double pAandC = (double)tabla[0, 0] / totalGeneral;
                double pAandD = (double)tabla[0, 1] / totalGeneral; // A y C'
                double pBandC = (double)tabla[1, 0] / totalGeneral; // A' y C
                double pBandD = (double)tabla[1, 1] / totalGeneral; // A' y C' (B y D)

                // Uniones (OR) -> P(X U Y) = P(X) + P(Y) - P(X n Y)
                double pAorC = pA + pC - pAandC;
                double pAorD = pA + pD - pAandD; // A o C'
                double pBorC = pB + pC - pBandC; // A' o C
                double pBorD = pB + pD - pBandD;

                // --- LISTA DE PREGUNTAS DISPONIBLES ---
                // Incluimos notación A/B/C/D y también A'/C'
                string[] posiblesProblemas = new string[] {
                    // Simples directas
                    "P(A)", "P(B)", "P(C)", "P(D)",
                    // Simples complementarias (Pedagógico)
                    "P(A')", "P(C')",
                    // Intersecciones
                    "P(A ∩ C)", "P(A ∩ D)", "P(B ∩ C)", "P(B ∩ D)",
                    // Intersecciones con complemento (Misma matemática, distinta notación)
                    "P(A ∩ C')", // Igual a P(A ∩ D)
                    "P(A' ∩ C)", // Igual a P(B ∩ C)
                    // Uniones
                    "P(A ∪ C)", "P(A ∪ D)", "P(B ∪ C)", "P(B ∪ D)",
                    // Uniones con complemento
                    "P(A ∪ C')", // Igual a P(A ∪ D)
                    "P(A' ∪ C)"  // Igual a P(B ∪ C)
                };

                // Selección aleatoria de 5 preguntas únicas
                List<string> seleccionadas = new List<string>();
                while (seleccionadas.Count < 5) {
                    string seleccion = posiblesProblemas[rand.Next(posiblesProblemas.Length)];
                    if (!seleccionadas.Contains(seleccion)) {
                        seleccionadas.Add(seleccion);
                    }
                }

                // Asignación de respuestas
                Dictionary<string, double> respuestasMap = new Dictionary<string, double>();

                foreach (string preg in seleccionadas) {
                    double res = 0;
                    switch (preg) {
                        // Directas
                        case "P(A)": res = pA; break;
                        case "P(B)": res = pB; break;
                        case "P(C)": res = pC; break;
                        case "P(D)": res = pD; break;

                        // Complementos (Lógica inversa)
                        case "P(A')": res = pB; break; // A' es todo lo que no es A (o sea, B)
                        case "P(C')": res = pD; break; // C' es todo lo que no es C (o sea, D)

                        // Intersecciones
                        case "P(A ∩ C)": res = pAandC; break;
                        case "P(A ∩ D)": res = pAandD; break;
                        case "P(B ∩ C)": res = pBandC; break;
                        case "P(B ∩ D)": res = pBandD; break;

                        // Intersecciones mixtas
                        case "P(A ∩ C')": res = pAandD; break; // C' es D
                        case "P(A' ∩ C)": res = pBandC; break; // A' es B

                        // Uniones
                        case "P(A ∪ C)": res = pAorC; break;
                        case "P(A ∪ D)": res = pAorD; break;
                        case "P(B ∪ C)": res = pBorC; break;
                        case "P(B ∪ D)": res = pBorD; break;

                        // Uniones mixtas
                        case "P(A ∪ C')": res = pAorD; break;
                        case "P(A' ∪ C)": res = pBorC; break;
                    }
                    respuestasMap[preg] = res;
                }

                string[] seleccionadasArray = seleccionadas.ToArray();
                double[] respuestasArray = new double[respuestasMap.Count];

                // Asegurar el orden correcto de las respuestas
                for (int k = 0; k < seleccionadasArray.Length; k++) {
                    respuestasArray[k] = Math.Round(respuestasMap[seleccionadasArray[k]], 4);
                }

                problemas[i] = new ProblemaContingencia(textoEjercicio, tabla, nombresTabla, seleccionadasArray, respuestasArray);
            }

            return problemas;
        }

        // El resto de métodos (FormatoProblemas, FormatearRespuestasProblemas) 
        // pueden quedarse igual, ya que solo imprimen lo que generamos arriba.
        public string FormatoProblemas(ProblemaContingencia[] problemas) {
            StringBuilder resultadoFinal = new StringBuilder();

            for (int i = 0; i < problemas.Length; i++) {
                resultadoFinal.AppendLine($"-------- Problema {i + 1} --------");
                resultadoFinal.AppendLine(problemas[i].Ejercicio);
                resultadoFinal.AppendLine();

                int[,] tabla = problemas[i].TablaContingencia;
                int filas = tabla.GetLength(0);
                int columnas = tabla.GetLength(1);

                // Imprimimos la cabecera de las columnas (C y D)
                resultadoFinal.AppendLine("          " + problemas[i].NombresTabla[0]);
                resultadoFinal.AppendLine(problemas[i].NombresTabla[1] + "     " + string.Join("   ", new[] { problemas[i].NombresTabla[4], problemas[i].NombresTabla[5] }));

                for (int j = 0; j < filas; j++) {
                    // Imprimimos el nombre de la fila (A o B)
                    if (j == 0)
                        resultadoFinal.Append("  " + problemas[i].NombresTabla[2] + "    ");
                    else if (j == 1)
                        resultadoFinal.Append("  " + problemas[i].NombresTabla[3] + " ");

                    for (int k = 0; k < columnas; k++) {
                        resultadoFinal.Append($"{tabla[j, k],4}");
                    }
                    resultadoFinal.AppendLine();
                }

                resultadoFinal.AppendLine();
                foreach (var pregunta in problemas[i].Preguntas) {
                    resultadoFinal.AppendLine($"{pregunta}:");
                }
                resultadoFinal.AppendLine();
            }
            return resultadoFinal.ToString();
        }

        public string FormatearRespuestasProblemas(ProblemaContingencia[] problemas) {
            StringBuilder resultadoFinal = new StringBuilder();

            for (int i = 0; i < problemas.Length; i++) {
                resultadoFinal.AppendLine($"-------- Problema {i + 1} --------");
                resultadoFinal.AppendLine("Respuestas:");
                for (int j = 0; j < problemas[i].Preguntas.Length; j++) {
                    resultadoFinal.AppendLine($"{problemas[i].Preguntas[j]}: {problemas[i].Respuestas[j]}");
                }
                resultadoFinal.AppendLine();
            }
            return resultadoFinal.ToString();
        }
    }
}