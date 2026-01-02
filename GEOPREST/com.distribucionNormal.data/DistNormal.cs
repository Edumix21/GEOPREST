using System;
using System.Collections.Generic;
using GEOPREST.com.distribucionNormal.data;
using MathNet.Numerics.Distributions;

public class DistNormal {
    private Random random = new Random();
    private List<ProblemaDistNormal> problemasGenerados = new List<ProblemaDistNormal>();

    public void GenerarProblemas(int numeroProblemas, string descripcion, double mediaMin, double mediaMax, double desviacionMin, double desviacionMax/*, string tipoPregunta*/) {
        for (int i = 0; i < numeroProblemas; i++) {
            // Generación aleatoria de la media y desviación estándar dentro de los rangos
            double media = GenerarAleatorio(mediaMin, mediaMax);
            double desviacion = GenerarAleatorio(desviacionMin, desviacionMax);

            //Redondeamos a 2 decimales, si es mayor a 20 quitamos decimales
            double factorSum = Math.Pow(10, 2);
            media = Math.Round(media * factorSum) / factorSum;
            desviacion = Math.Round(desviacion * factorSum) / factorSum;
            if (media > 20) media = Math.Round(media);
            if (desviacion > 20) desviacion = Math.Round(desviacion);

            List<double> listaZ1 = new List<double>();
            List<double> listaZ2 = new List<double>();

            for (int j = 0; j < 4; j++) {
                // Llama al método y desestructura la tupla en cada iteración
                var (arrayZ1, arrayZ2) = GenerarValoresZ(media, desviacion);

                //Redondeamos las variables z a 2 decimales
                arrayZ1 = Math.Round(arrayZ1 * factorSum) / factorSum;
                arrayZ2 = Math.Round(arrayZ2 * factorSum) / factorSum;
                if (arrayZ1 > 20) arrayZ1 = Math.Round(arrayZ1);
                if (arrayZ2 > 20) arrayZ2 = Math.Round(arrayZ2);

                listaZ1.Add(arrayZ1);
                listaZ2.Add(arrayZ2);
            }

            double[] z1 = listaZ1.ToArray();
            double[] z2 = listaZ2.ToArray();

            // Generación del valor Z o intervalo aleatorio coherente con media y desviación
            //var (z1, z2) = GenerarValoresZ(media, desviacion);
            //z2 = (double)(tipoPregunta == "intervalo" ? z2 : 0);

            // Cálculo de la probabilidad acumulada
            double[] probabilidad = new double[4];
            for (int j = 0; j < 4; j++) {
                if (j < 2) {
                    probabilidad[j] = Normal.CDF(media, desviacion, z1[j]); // Probabilidad acumulada para Z1
                } else {
                    probabilidad[j] = Normal.CDF(media, desviacion, z2[j]) - Normal.CDF(media, desviacion, z1[j]);  // Probabilidad entre Z1 y Z2
                }

                //Redondeamos la probabilidad a 2 decimales
                probabilidad[j] = Math.Round(probabilidad[j] * factorSum) / factorSum;
            }

            // Creación del objeto ProblemaDistNormal
            var problema = new ProblemaDistNormal {
                Descripcion = descripcion,
                Media = media,
                Desviacion = desviacion,
                Z = z1,
                ZInferior = z2,
                //TipoPregunta = tipoPregunta,
                Respuesta = probabilidad
            };

            // Agregar el problema al array/lista de problemas generados
            problemasGenerados.Add(problema);
        }
    }

    // Método para generar un valor aleatorio entre dos valores
    private double GenerarAleatorio(double min, double max) {
        return min + (random.NextDouble() * (max - min));
    }

    // Método para generar los valores z1 y z2 en base a la media y desviación estándar
    public (double z1, double z2) GenerarValoresZ(double media, double desviacion) {
        // Generar valores z entre -3 y 3 (escalados por la desviación estándar)
        double z1 = (random.NextDouble() * 6 - 3); // Genera un número entre -3 y 3
        double z2 = (random.NextDouble() * 6 - 3);

        // Asegurar que z1 sea menor que z2
        if (z1 > z2) {
            double temp = z1;
            z1 = z2;
            z2 = temp;
        }

        // Calcular los valores de z1 y z2 ajustados por la media y desviación estándar
        double valorRealZ1 = media + z1 * desviacion;
        double valorRealZ2 = media + z2 * desviacion;

        // Retornar los valores ajustados
        return (valorRealZ1, valorRealZ2);
    }

    // Método para obtener los problemas generados
    public ProblemaDistNormal[] ObtenerProblemas() {
        return problemasGenerados.ToArray(); // Convertir la lista a un array
    }

    public string FormatearProblemas(ProblemaDistNormal[] problemas) {
        string textoProblemas = "";

        for (int i = 0; i < problemas.Length; i++) {
            //Obtenemos los valores a insertar en el texto
            double media = problemas[i].Media;
            double desviacion = problemas[i].Desviacion;
            double[] valoresZ = problemas[i].Z;
            double[] valoresZInf = problemas[i].ZInferior;
            //string valorComparacion;


            //En caso de que el problema tenga 2 valores a calcular (intervalo)
            //if (problemas[i].ZInferior != 0) {
            //    valorComparacion = $"[{problemas[i].ZInferior}, {problemas[i].Z}]";
            //} else {
            //    //En caso que solo tenga un valor z a calcular (Acumulada)
            //    valorComparacion = $"{problemas[i].Z}";
            //}


            string formato = problemas[i].Descripcion;

            // Usar String.Replace para sustituir los valores de media {m}, desviación {d}, y valor comparativo {v}
            string problemaFormateado = formato
                .Replace("{m}", media.ToString())
                .Replace("{d}", desviacion.ToString())
                .Replace("{v1}", valoresZ[0].ToString())
                .Replace("{v2}", valoresZ[1].ToString())
                .Replace("{v3}", valoresZ[2].ToString())
                .Replace("{v4}", valoresZ[3].ToString())
                .Replace("{vI1}", valoresZInf[0].ToString())
                .Replace("{vI2}", valoresZInf[1].ToString());
                //.Replace("{v}", valorComparacion.ToString());

            textoProblemas += $"-------- Problema {i + 1} --------\n";
            textoProblemas += problemaFormateado + "\n";
        }

        return textoProblemas;
    }

    public string FormatearRespuestas(ProblemaDistNormal[] problemas) {
        string textoRespuestas = "";

        for (int i = 0; i < problemas.Length; i++) {
            textoRespuestas += $"-------- Problema {i + 1} --------\n";
            for (int j = 0; j < problemas[i].Respuesta.Length; j++) {
                string tipoPreguntaTexto;
                // Aquí replicamos la lógica de XMLGeneratorDN para determinar el tipo de pregunta
                if (j < 2) { // Asumimos que las primeras dos opciones son acumuladas
                    tipoPreguntaTexto = $"P(X < {problemas[i].Z[j]:0.##})";
                } else { // Las siguientes opciones son de intervalo
                    double zInf = problemas[i].ZInferior[j];
                    double zSup = problemas[i].Z[j];
                    if (zInf > zSup) { // Intercambiar si el orden es incorrecto
                        double temp = zInf;
                        zInf = zSup;
                        zSup = temp;
                    }
                    tipoPreguntaTexto = $"P({zInf:0.##} \u2264 X \u2264 {zSup:0.##})";
                }
                textoRespuestas += $"{((char)('a' + j))}) {tipoPreguntaTexto}: {problemas[i].Respuesta[j]:0.##}\n";
            }
        }
        return textoRespuestas;
    }

}

