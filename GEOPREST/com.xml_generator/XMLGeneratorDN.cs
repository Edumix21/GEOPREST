using System;
using System.Text;
using System.Xml;
using GEOPREST.com.distribucionNormal.data;

namespace GEOPREST.com.xml_generator {
    public class XMLGeneratorDN {
        public static void GenerateXMLDN(string categoria, string nomProblema, string rutaArchivo, ProblemaDistNormal[] problemasDistNormal) {
            try {
                XmlDocument document = new XmlDocument();

                // Crear el elemento raíz
                XmlElement quizElement = document.CreateElement("quiz");
                document.AppendChild(quizElement);

                // Comentario inicial
                XmlComment initialComment = document.CreateComment("  question: 0   ");
                quizElement.AppendChild(initialComment);

                // Crear categoría
                XmlElement questionCategoryElement = document.CreateElement("question");
                questionCategoryElement.SetAttribute("type", "category");
                quizElement.AppendChild(questionCategoryElement);

                XmlElement categoryElement = document.CreateElement("category");
                questionCategoryElement.AppendChild(categoryElement);

                XmlElement categoryTextElement = document.CreateElement("text");
                categoryTextElement.InnerText = "$course$/top/" + categoria;
                categoryElement.AppendChild(categoryTextElement);

                int baseSerial = 152670;

                for (int i = 0; i < problemasDistNormal.Length; i++) {
                    int serialNumber = baseSerial + i;
                    XmlComment serialComment = document.CreateComment($"  question: {serialNumber}   ");
                    quizElement.AppendChild(serialComment);

                    XmlElement questionElement = document.CreateElement("question");
                    questionElement.SetAttribute("type", "cloze");
                    quizElement.AppendChild(questionElement);

                    XmlElement nameElement = document.CreateElement("name");
                    questionElement.AppendChild(nameElement);

                    XmlElement nameTextElement = document.CreateElement("text");
                    nameTextElement.InnerText = $"Q01-V{(i + 1):000}";
                    nameElement.AppendChild(nameTextElement);

                    XmlElement questionTextElement = document.CreateElement("questiontext");
                    questionTextElement.SetAttribute("format", "html");
                    questionElement.AppendChild(questionTextElement);

                    string enunciado = FormatearProblemaIndividual(problemasDistNormal[i]);
                    StringBuilder cuerpoPregunta = new StringBuilder();
                    cuerpoPregunta.Append($"<p dir=\"ltr\">{enunciado}</p>");

                    for (int j = 0; j < problemasDistNormal[i].Z.Length; j++) {
                        string literal = ((char)('a' + j)) + ")";
                        // Aquí es donde cambia la lógica para generar preguntas acumuladas o de intervalo
                        if (j < 2) { // Asumimos que las primeras dos opciones son acumuladas
                            cuerpoPregunta.Append($"<p>{literal} P(X &lt; {problemasDistNormal[i].Z[j]:0.##}): {{1:NUMERICAL:={problemasDistNormal[i].Respuesta[j]:0.##}:0.01#}}</p>");
                        } else { // Las siguientes opciones son de intervalo
                            // Aseguramos que el valor inferior sea menor que el superior para el formato de intervalo
                            double zInf = problemasDistNormal[i].ZInferior[j];
                            double zSup = problemasDistNormal[i].Z[j];
                            if (zInf > zSup) { // Intercambiar si el orden es incorrecto
                                double temp = zInf;
                                zInf = zSup;
                                zSup = temp;
                            }
                            cuerpoPregunta.Append($"<p>{literal} P({zInf:0.##} ≤ X ≤ {zSup:0.##}): {{1:NUMERICAL:={problemasDistNormal[i].Respuesta[j]:0.##}:0.01#}}</p>");
                        }
                    }

                    XmlElement questionTextTextElement = document.CreateElement("text");
                    questionTextTextElement.InnerText = $"<![CDATA[{cuerpoPregunta}</p>";
                    questionTextElement.AppendChild(questionTextTextElement);
                }

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

        public static string FormatearProblemaIndividual(ProblemaDistNormal problema) {
            double media = problema.Media;
            double desviacion = problema.Desviacion;
            double[] valoresZ = problema.Z;
            double[] valoresZInf = problema.ZInferior;

            string formato = problema.Descripcion;

            // Asegúrate de que todos los valores Z y ZInferior necesarios estén disponibles en el formato
            // Aquí se asume que tu descripción puede manejar hasta 4 valores Z y 2 valores ZInferior
            string problemaFormateado = formato
                .Replace("{m}", media.ToString("0.##"))
                .Replace("{d}", desviacion.ToString("0.##"))
                .Replace("{v1}", valoresZ[0].ToString("0.##"))
                .Replace("{v2}", valoresZ[1].ToString("0.##"))
                .Replace("{v3}", valoresZ[2].ToString("0.##"))
                .Replace("{v4}", valoresZ[3].ToString("0.##"));

            // Reemplazar valores de ZInferior solo si están presentes y son relevantes
            if (valoresZInf != null && valoresZInf.Length > 0) {
                if (valoresZInf.Length > 0) problemaFormateado = problemaFormateado.Replace("{vI1}", valoresZInf[0].ToString("0.##"));
                if (valoresZInf.Length > 1) problemaFormateado = problemaFormateado.Replace("{vI2}", valoresZInf[1].ToString("0.##"));
            }

            return problemaFormateado;
        }
    }
}