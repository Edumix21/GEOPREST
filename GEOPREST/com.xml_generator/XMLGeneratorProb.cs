using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Xml;
using GEOPREST.com.probabilidad.data;

namespace GEOPREST.com.xml_generator {
    public class XMLGeneratorProb {
        public static void GenerateXMLProb(ProblemaVenn[] problemasVenn, string nomProblema, string rutaImagen, string rutaArchivo, string categoria) {
            try {
                // Crear un objeto XmlDocument para representar el documento XML
                XmlDocument document = new XmlDocument();

                // Crear el elemento raíz
                XmlElement quizElement = document.CreateElement("quiz");
                document.AppendChild(quizElement);

                // *** Comentario inicial tras <quiz> ***
                XmlComment initialComment = document.CreateComment("  question: 0   ");
                quizElement.AppendChild(initialComment);

                // Crear <question type="category">
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

                // Base para comentarios seriales de preguntas
                int baseSerial = 152670;

                // Iterar sobre los datos para generar las preguntas
                for (int i = 0; i < problemasVenn.Length; i++) {
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

                    // Generar la imagen y guardarla como base64
                    string base64Image = ConvertImageToBase64(rutaImagen + (i + 1) + ".png");

                    // Guardar los datos de los problemas en variables
                    string ejercicio = problemasVenn[i].Ejercicio;
                    string[] valEjercicios = problemasVenn[i].ValEjercicios;
                    double[] resultados = problemasVenn[i].Resultados;

                    // Definir el texto de la pregunta con los datos correspondientes
                    StringBuilder questionText = new StringBuilder();
                    questionText.Append("<![CDATA[<p dir=\"ltr\">" + ejercicio + "</p>");
                    questionText.Append("<p><img src=\"data:image/png;base64," + base64Image + "\" alt=\"Diagrama Venn\"/></p>");
                    questionText.Append("<ol type=\"a\">");

                    for (int j = 0; j < valEjercicios.Length; j++) {
                        string expresion = ConvertToMathJax(valEjercicios[j]);
                        questionText.Append("<li>P( <span class=\"math inline\">" + expresion + "</span> ) {1:NUMERICAL:%100%" + resultados[j].ToString("0.####") + ":0.09#}</li>");
                    }

                    questionText.Append("</ol>");

                    XmlElement questionTextTextElement = document.CreateElement("text");
                    questionTextTextElement.InnerText = questionText.ToString();
                    questionTextElement.AppendChild(questionTextTextElement);

                    // Sección de etiquetas comentada (desactivada temporalmente)
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
                using (XmlWriter writer = XmlWriter.Create(rutaArchivo, settings)) {
                    document.Save(writer);
                }
            } catch (Exception e) {
                Console.WriteLine("Error al generar el archivo XML: " + e.Message);
            }
        }

        private static string ConvertImageToBase64(string imagePath) {
            try {
                using (Image image = Image.FromFile(imagePath)) {
                    using (MemoryStream ms = new MemoryStream()) {
                        image.Save(ms, ImageFormat.Png);
                        byte[] imageBytes = ms.ToArray();
                        return Convert.ToBase64String(imageBytes);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Error al convertir la imagen a Base64: " + e.Message);
                return null;
            }
        }

        // Metodo para convertir los caracteres de conjunciones a notacion MathJax
        public static string ConvertToMathJax(string expression) {
            return expression.Replace("∪", "\\(\\cup\\)")
                             .Replace("∩", "\\(\\cap\\)")
                             .Replace("'", "^C");
        }
        //public static string ConvertToMathJax(string expression) {
        //    return expression.Replace("∪", "<span style=\"font-family: 'Courier New', monospace;\">\\(\\cup\\)</span>")
        //                     .Replace("∩", "<span style=\"font-family: 'Courier New', monospace;\">\\(\\cap\\)</span>")
        //                     .Replace("'", "<span style=\"font-family: 'Courier New', monospace;\">^C</span>");
        //}

    }
}
