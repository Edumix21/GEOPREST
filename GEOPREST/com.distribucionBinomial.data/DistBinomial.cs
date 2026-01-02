using System;
using System.Collections.Generic;

namespace GEOPREST.com.distribucionBinomial.data {

    public class DistBinomial {
        private List<ProblemaDistBinomial> problemasGenerados = new List<ProblemaDistBinomial>();

        public List<ProblemaDistBinomial> ObtenerProblemas() {
            return problemasGenerados;
        }

        public void GenerarProblemas(
            int numeroProblemas,
            string descripcionBase,
            string textoContextoN,
            int minEnsayosGlobal,
            int maxEnsayosGlobal,
            double minProbExitoGlobal,
            double maxProbExitoGlobal
        ) {
            Random rnd = new Random();

            for (int i = 0; i < numeroProblemas; i++) {
                //Generamos p y n para el problema
                int nPrincipal = rnd.Next(minEnsayosGlobal, maxEnsayosGlobal + 1);
                //Redondeamos p a dos decimales
                double pPrincipal = Math.Round(rnd.NextDouble() * (maxProbExitoGlobal - minProbExitoGlobal) + minProbExitoGlobal, 2);
                pPrincipal = Math.Max(0.0, Math.Min(1.0, pPrincipal));

                // Formateo del porcentaje sin decimales innecesarios (usa 0.##)
                string porcentajeStr = (pPrincipal * 100).ToString("0.##");
                //Variable para generar los 4 tipos de preguntas
                string[] tiposPregunta = { "exacto", "a lo sumo", "al menos", "intervalo" };

                //Descripcion completa de todo el problema sustituyendo los valores
                string descripcionCompleta = descripcionBase.Replace("{p}", porcentajeStr)
                                           + " " + textoContextoN.Replace("{n}", nPrincipal.ToString());

                //Generamos cada subpregunta
                foreach (string tipo in tiposPregunta) {
                    int nFijo = nPrincipal;
                    int k1, k2;
                    double resultado;

                    //Bucle para asegurar que el problema generado tenga una probabilidad valida
                    do {
                        k1 = 0;
                        k2 = 0;

                        switch (tipo.ToLower()) {
                            case "exacto":
                                k1 = rnd.Next(0, nFijo + 1);
                                resultado = BinomialProbability(nFijo, k1, pPrincipal);
                                break;
                            case "a lo sumo":
                                k1 = rnd.Next(0, nFijo + 1);
                                resultado = BinomialCumulativeDistribution(nFijo, k1, pPrincipal);
                                break;
                            case "al menos":
                                k1 = rnd.Next(0, nFijo + 1);
                                resultado = 1 - BinomialCumulativeDistribution(nFijo, k1 - 1, pPrincipal);
                                break;
                            case "intervalo":
                                k1 = rnd.Next(0, nFijo);
                                k2 = rnd.Next(k1 + 1, nFijo + 1);
                                resultado = BinomialCumulativeDistribution(nFijo, k2, pPrincipal) - BinomialCumulativeDistribution(nFijo, k1 - 1, pPrincipal);
                                break;
                            default:
                                resultado = 0;
                                break;
                        }
                    } while (resultado < 0.0001 && resultado != 0);

                    if (tipo.ToLower() == "intervalo") {
                        problemasGenerados.Add(new ProblemaDistBinomial(descripcionCompleta, nFijo, pPrincipal, k2, k1, tipo, resultado));
                    } else {
                        problemasGenerados.Add(new ProblemaDistBinomial(descripcionCompleta, nFijo, pPrincipal, k1, null, tipo, resultado));
                    }
                }
            }
        }


        // --- Métodos Propios para la Distribución Binomial ---

        /// <summary>
        /// Calcula el coeficiente binomial C(n, k).
        /// </summary>
        /// <param name="n">Número de ensayos.</param>
        /// <param name="k">Número de éxitos.</param>
        /// <returns>El coeficiente binomial.</returns>
        private double BinomialCoefficient(int n, int k) {
            if (k < 0 || k > n) {
                return 0;
            }
            if (k == 0 || k == n) {
                return 1;
            }
            if (k > n / 2) {
                k = n - k;
            }

            double res = 1;
            for (int i = 1; i <= k; i++) {
                res = res * (n - i + 1) / i;
            }
            return res;
        }

        /// <summary>
        /// Calcula la probabilidad de obtener exactamente k éxitos en n ensayos.
        /// P(X = k) = C(n, k) * p^k * (1-p)^(n-k)
        /// </summary>
        /// <param name="n">Número total de ensayos.</param>
        /// <param name="k">Número de éxitos deseados.</param>
        /// <param name="p">Probabilidad de éxito en un solo ensayo.</param>
        /// <returns>La probabilidad de exactamente k éxitos.</returns>
        private double BinomialProbability(int n, int k, double p) {
            if (k < 0 || k > n) {
                return 0.0;
            }
            double q = 1.0 - p;
            double coefficient = BinomialCoefficient(n, k);
            return coefficient * Math.Pow(p, k) * Math.Pow(q, n - k);
        }

        /// <summary>
        /// Calcula la probabilidad acumulada de obtener hasta k éxitos en n ensayos.
        /// P(X <= k) = Sum(P(X = i)) para i desde 0 hasta k.
        /// </summary>
        /// <param name="n">Número total de ensayos.</param>
        /// <param name="k">Número máximo de éxitos.</param>
        /// <param name="p">Probabilidad de éxito en un solo ensayo.</param>
        /// <returns>La probabilidad acumulada hasta k éxitos.</returns>
        private double BinomialCumulativeDistribution(int n, int k, double p) {
            if (k < 0) {
                return 0.0;
            }
            if (k >= n) {
                return 1.0;
            }

            double cumulativeProb = 0.0;
            for (int i = 0; i <= k; i++) {
                cumulativeProb += BinomialProbability(n, i, p);
            }
            return cumulativeProb;
        }
    }
}