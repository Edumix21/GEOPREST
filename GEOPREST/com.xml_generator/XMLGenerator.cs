using System;
using System.IO;
using System.Xml;
using OfficeOpenXml;
using GEOPREST.com.data;

namespace GEOPREST.com.xml_generator {
    public class XMLGenerator {
        public static void GenerateXML(ProblemaAlumno[] alumn, string nomProblema, bool sumatoria,
            bool media, bool varianza, bool desEstandar, bool cofVariacion, string ruta,
            string categoria, string[] errPerm, string rutaCsv) {

            bool isRutaCsv = !string.IsNullOrEmpty(rutaCsv);  //flag para determinar si el usuario quiere generar archivos csv
            string sumatoriaTxt = "";
            string mediaTxt = "";
            string varianzaTxt = "";
            string desEstandarTxt = "";
            string cofVariacionTxt = "";

            try {
                // Validar la ruta del archivo CSV
                if (isRutaCsv && !Directory.Exists(Path.GetDirectoryName(rutaCsv))) {
                    Console.WriteLine("Ruta CSV no válida. No se generarán archivos CSV.");
                    isRutaCsv = false; // Desactivar la opción de CSV si la ruta no es válida
                }
                // Crear un objeto XmlDocument para representar el documento XML
                XmlDocument document = new XmlDocument();

                // Crear el elemento raíz
                XmlElement quizElement = document.CreateElement("quiz");
                document.AppendChild(quizElement);

                // *** Comentario inicial tras <quiz> ***
                XmlComment initialComment = document.CreateComment("  question: 0   ");
                quizElement.AppendChild(initialComment);

                // Crear <question type="category"> con su contenido
                XmlElement questionCategoryElement = document.CreateElement("question");
                questionCategoryElement.SetAttribute("type", "category");
                quizElement.AppendChild(questionCategoryElement);

                // Crear el elemento category dentro de question type="category"
                XmlElement categoryElement = document.CreateElement("category");
                questionCategoryElement.AppendChild(categoryElement);

                // Crear el elemento text dentro de category y establecer el texto de la categoría
                XmlElement categoryTextElement = document.CreateElement("text");
                categoryTextElement.InnerText = "$course$/top/" + categoria;
                categoryElement.AppendChild(categoryTextElement);

                string errSum = errPerm[0];
                string errMed = errPerm[1];
                string errVar = errPerm[2];
                string errDes = errPerm[3];
                string errCof = errPerm[4];

                // Base para comentarios seriales de preguntas
                int baseSerial = 152670;

                // Iterar sobre los datos para generar las preguntas
                for (int i = 0; i < alumn.Length; i++) {
                    // *** Comentario serial antes de cada <question> ***
                    int serialNumber = baseSerial + i;
                    XmlComment serialComment = document.CreateComment($"  question: {serialNumber}   ");
                    quizElement.AppendChild(serialComment);

                    // Crear elemento question
                    XmlElement questionElement = document.CreateElement("question");
                    questionElement.SetAttribute("type", "cloze");
                    quizElement.AppendChild(questionElement);

                    // Crear elemento name
                    XmlElement nameElement = document.CreateElement("name");
                    questionElement.AppendChild(nameElement);

                    // Definir el nombre de la pregunta (formato Q01-V001, Q01-V002...)
                    XmlElement nameTextElement = document.CreateElement("text");
                    nameTextElement.InnerText = $"Q01-V{(i + 1):000}";
                    nameElement.AppendChild(nameTextElement);

                    // Crear elemento questiontext
                    XmlElement questionTextElement = document.CreateElement("questiontext");
                    questionTextElement.SetAttribute("format", "html");
                    questionElement.AppendChild(questionTextElement);

                    string impDatos = "";
                    // Verificar agrupación de datos
                    if (!MenuEstadistica.IsAgruped)
                        impDatos = alumn[i].ImprimirDatos(alumn[i]);
                    else impDatos = alumn[i].ImprimirDatosAgrupados(alumn[i], MenuEstadistica.NIntervalos, true);

                    // Formatos de respuestas según selección del usuario
                    if (sumatoria) sumatoriaTxt = "<p dir=\"ltr\">Sumatoria (<simbolo>&#931;</simbolo>):{1:NUMERICAL:%100%" + alumn[i].Sumatoria + ":" + errSum + "#}<br></p>";
                    if (media) mediaTxt = "<p dir=\"ltr\">Media (<mediaMuestral>x&#773;</mediaMuestral>):{1:NUMERICAL:%100%" + alumn[i].Media + ":" + errMed + "#}<br></p>";
                    if (varianza) varianzaTxt = "<p dir=\"ltr\">Varianza (<varianzaMuestral>S&#178;</varianzaMuestral>):{1:NUMERICAL:%100%" + alumn[i].Varianza + ":" + errVar + "#}<br></p>";
                    if (desEstandar) desEstandarTxt = "<p dir=\"ltr\">Desviación Estandar (S):{1:NUMERICAL:%100%" + alumn[i].Desviacion + ":" + errDes + "#}<br></p>";
                    if (cofVariacion) cofVariacionTxt = "<p dir=\"ltr\">Coeficiente de Variación (C.V.):&nbsp;{1:NUMERICAL:%100%" + alumn[i].CoeficienteVar + ":" + errCof + "#}</p>";

                    // Inicializamos variables para el CSV
                    string csvFileName = "", base64Csv = "";
                    if (isRutaCsv) {
                        // Crear el archivo CSV y convertirlo a base64
                        csvFileName = "datos_" + (i + 1) + ".csv";
                        string csvFilePath = Path.Combine(rutaCsv, csvFileName);

                        if (GenerarArchivoCSV(alumn[i], csvFilePath)) {
                            base64Csv = ConvertCsvToBase64(csvFilePath);
                        } else {
                            Console.WriteLine("Error al generar el archivo CSV.");
                            isRutaCsv = false; // Desactivar la opción CSV si falla
                        }
                    }

                    // Definir el texto de la pregunta con los datos y formatos
                    XmlElement questionTextTextElement = document.CreateElement("text");
                    if (!isRutaCsv) {
                        questionTextTextElement.InnerText = "<![CDATA[ <p dir=\"ltr\" style=\"text-align: left;\"></p>" +
                            "<p dir=\"ltr\">" + alumn[i].Ejercicio + "<br>" + impDatos + "</p>" +
                            sumatoriaTxt + mediaTxt + varianzaTxt + desEstandarTxt + cofVariacionTxt + "<br><p></p>";
                        questionTextElement.AppendChild(questionTextTextElement);
                    } else if (isRutaCsv && MenuEstadistica.IsAgruped) {
                        questionTextTextElement.InnerText = "<![CDATA[ <p dir=\"ltr\" style=\"text-align: left;\"></p>" +
                            "<p dir=\"ltr\">" + alumn[i].Ejercicio + "<br>" + impDatos + "</p>" +
                            "<br><p>Los datos se encuentran disponibles en el enlace <a href=\"@@PLUGINFILE@@/" + csvFileName + "\"><code>" + csvFileName + "</code></a>.</p>" +
                            sumatoriaTxt + mediaTxt + varianzaTxt + desEstandarTxt + cofVariacionTxt + "<br><p></p>";
                        questionTextElement.AppendChild(questionTextTextElement);
                    } else {
                        questionTextTextElement.InnerText = "<![CDATA[ <p dir=\"ltr\" style=\"text-align: left;\"></p>" +
                            "<p dir=\"ltr\">" + alumn[i].Ejercicio + "<br>" + "</p>" +
                            "<br><p>Los datos se encuentran disponibles en el enlace <a href=\"@@PLUGINFILE@@/" + csvFileName + "\"><code>" + csvFileName + "</code></a>.</p>" +
                            sumatoriaTxt + mediaTxt + varianzaTxt + desEstandarTxt + cofVariacionTxt + "<br><p></p>";
                        questionTextElement.AppendChild(questionTextTextElement);

                        // Añadir el archivo CSV codificado en base64 como un archivo en el XML
                        XmlElement fileElement = document.CreateElement("file");
                        fileElement.SetAttribute("name", csvFileName);
                        fileElement.SetAttribute("path", "/");
                        fileElement.SetAttribute("encoding", "base64");
                        fileElement.InnerText = base64Csv; // Contenido codificado en base64
                        questionTextElement.AppendChild(fileElement);
                    }

                    // Agregar sección de etiquetas comentada (desactivada temporalmente)
                    /*
                    XmlElement tagsElement = document.CreateElement("tags");
                    XmlElement tagElement = document.CreateElement("tag");
                    XmlElement tagTextElement = document.CreateElement("text");
                    tagTextElement.InnerText = nomProblema;
                    tagElement.AppendChild(tagTextElement);
                    tagsElement.AppendChild(tagElement);
                    questionElement.AppendChild(tagsElement);
                    */
                }

                // Crear un objeto XmlWriterSettings para la configuración de formato del archivo XML
                XmlWriterSettings settings = new XmlWriterSettings {
                    Indent = true,
                    IndentChars = "\t"
                };

                // Escribir el documento XML en un archivo
                using (XmlWriter writer = XmlWriter.Create(ruta, settings)) {
                    document.Save(writer);
                }
            } catch (Exception e) {
                Console.WriteLine("Error al generar el archivo XML: " + e.Message);
            }
        }

        // Método para generar el archivo CSV
        private static bool GenerarArchivoCSV(ProblemaAlumno alumn, string rutaCsv) {
            try {
                // Verificar y crear el directorio si no existe
                string directory = Path.GetDirectoryName(rutaCsv);
                if (!Directory.Exists(directory)) {
                    Directory.CreateDirectory(directory);
                }

                // Lógica para crear y guardar el archivo CSV con los datos de alumn en formato vertical
                using (StreamWriter writer = new StreamWriter(rutaCsv)) {
                    for (int i = 0; i < alumn.Valores.Length; i++) {
                        writer.WriteLine(alumn.Valores[i]);
                    }
                }
                return true;
            } catch (Exception ex) {
                Console.WriteLine("Error al generar el archivo CSV: " + ex.Message);
                return false;
            }
        }

        // Método para convertir un archivo CSV a base64
        public static string ConvertCsvToBase64(string rutaCsv) {
            byte[] csvBytes = File.ReadAllBytes(rutaCsv);
            return Convert.ToBase64String(csvBytes);
        }
    }
}
