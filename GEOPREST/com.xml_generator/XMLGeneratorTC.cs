using System;
using System.Text;
using System.Xml;
using GEOPREST.com.tablasContingencia.data;

namespace GEOPREST.com.xml_generator {
    internal class XMLGeneratorTC {
        public static void GenerateXMLTC(string categoria, string nomProblema, string rutaArchivo, ProblemaContingencia[] problemasContingencia) {
            try {
                XmlDocument document = new XmlDocument();

                // Crear elemento raíz
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

                // Base para comentarios seriales de preguntas
                int baseSerial = 152670;

                // Iterar sobre los problemas de contingencia para crear las preguntas
                for (int i = 0; i < problemasContingencia.Length; i++) {
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

                    // Construir el contenido de la pregunta
                    StringBuilder questionText = new StringBuilder();
                    var problema = problemasContingencia[i];
                    questionText.Append("<![CDATA[<p dir=\"ltr\">" + problema.Ejercicio + "</p>");

                    // Formatear la tabla de contingencia en HTML
                    questionText.Append("<table border=\"1\" cellpadding=\"4\" cellspacing=\"0\">");
                    questionText.Append("<tr><td></td><td>" + problema.NombresTabla[0] + "</td><td>" + problema.NombresTabla[1] + "</td></tr>");
                    for (int j = 0; j < 2; j++) {
                        questionText.Append("<tr><td>" + problema.NombresTabla[j + 2] + "</td>");
                        for (int k = 0; k < 2; k++) {
                            questionText.Append("<td>" + problema.TablaContingencia[j, k] + "</td>");
                        }
                        questionText.Append("</tr>");
                    }
                    questionText.Append("</table>");

                    // Añadir preguntas con MathJax y respuestas
                    questionText.Append("<ol type=\"a\">");
                    for (int j = 0; j < problema.Preguntas.Length; j++) {
                        questionText.Append("<li>" + problema.Preguntas[j] + " {1:NUMERICAL:%100%" + problema.Respuestas[j].ToString("0.####") + ":0.09#}</li>");
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

                // Guardar el documento XML
                XmlWriterSettings settings = new XmlWriterSettings {
                    Indent = true,
                    IndentChars = "\t"
                };

                using (XmlWriter writer = XmlWriter.Create(rutaArchivo, settings)) {
                    document.Save(writer);
                }
            } catch (Exception e) {
                Console.WriteLine("Error al generar el archivo XML: " + e.Message);
            }
        }
    }
}
