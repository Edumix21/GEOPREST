using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GEOPREST.com.data;

namespace GEOPREST.com.xml_generator {
    public class SaveDataInTxt {
        //Metodo para guardar los datos de un array de problemas en un archivo txt
        public static void SaveDataTxt(ProblemaAlumno[] alum) {
            try {
                //Generamos el archivo de texto cache
                using (StreamWriter writer = new StreamWriter("cache.txt")) {
                    foreach (ProblemaAlumno alumno in alum) {
                        //Para cada alumno, imprimimos los datos con el formato tsv (tab separated values)
                        StringBuilder sb = new StringBuilder();
                        sb.Append(alumno.Ejercicio).Append("\t");
                        sb.Append(ArrayToString(alumno.Valores)).Append("\t");
                        sb.Append(alumno.Sumatoria).Append("\t");
                        sb.Append(alumno.Media).Append("\t");
                        sb.Append(alumno.Varianza).Append("\t");
                        sb.Append(alumno.Desviacion).Append("\t");
                        sb.Append(alumno.CoeficienteVar).Append("\n");

                        // Escribe la línea en el archivo
                        writer.WriteLine(sb.ToString());
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("Error al escribir el archivo: " + e);
            }
        }

        //Metodo para leer los datos de un archivo txt y guardarlos en un array de problemas
        public static ProblemaAlumno[] LoadDataTxt() {
            List<ProblemaAlumno> problemas = new List<ProblemaAlumno>();

            try {
                using (StreamReader reader = new StreamReader("cache.txt")) {
                    string linea;
                    while ((linea = reader.ReadLine()) != null) {
                        // Divide la línea en columnas usando el carácter de tabulación como delimitador
                        string[] columnas = linea.Split('\t');

                        // Verifica si hay al menos 7 columnas
                        if (columnas.Length >= 7) {
                            // Convierte las columnas en los tipos de datos correspondientes
                            string ejercicio = columnas[0];
                            double[] valores = StringToArray(columnas[1]);
                            double sumatoria = double.Parse(columnas[2]);
                            double media = double.Parse(columnas[3]);
                            double varianza = double.Parse(columnas[4]);
                            double desviacion = double.Parse(columnas[5]);
                            double coeficienteVar = double.Parse(columnas[6]);

                            // Crea un nuevo objeto ProblemaAlumno y agrégalo a la lista
                            ProblemaAlumno problema = new ProblemaAlumno(ejercicio, valores.Length, sumatoria, media, varianza, desviacion, coeficienteVar);
                            problema.Valores = valores;
                            problemas.Add(problema);
                        } else {
                            //Console.WriteLine("Error: la línea no tiene suficientes columnas");
                        }
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
            }

            return problemas.ToArray();
        }


        // Método de ayuda para convertir un array a una cadena
        private static string ArrayToString(double[] valores) {
            StringBuilder sb = new StringBuilder();
            foreach (double num in valores) {
                sb.Append(num).Append(" ");
            }
            return sb.ToString().Trim(); // Elimina el espacio final
        }

        //Metodo de ayuda para convertur una cadena en un array
        public static double[] StringToArray(string cadena) {
            string[] valoresStr = cadena.Split(' ');
            double[] valores = new double[valoresStr.Length];
            for (int i = 0; i < valoresStr.Length; i++) {
                valores[i] = double.Parse(valoresStr[i]);
            }
            return valores;
        }



    }
}
