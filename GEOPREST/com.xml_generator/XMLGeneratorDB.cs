using System;
using System.Text;
using System.Xml;
using System.Collections.Generic;
using GEOPREST.com.distribucionBinomial.data;

namespace GEOPREST.com.xml_generator {
    public class XMLGeneratorDB {
        public static void GenerateXMLDB(string categoria, string nomProblema, string rutaArchivo, ProblemaDistBinomial[] problemasDistBinomial) {
            try {
                XmlDocument document = new XmlDocument();

                // Crear el elemento raíz <quiz>
                XmlElement quizElement = document.CreateElement("quiz");
                document.AppendChild(quizElement);

                // Comentario inicial
                XmlComment initialComment = document.CreateComment("  question: 0   ");
                quizElement.AppendChild(initialComment);

                // Crear la categoría de las preguntas
                XmlElement questionCategoryElement = document.CreateElement("question");
                questionCategoryElement.SetAttribute("type", "category");
                quizElement.AppendChild(questionCategoryElement);

                XmlElement categoryElement = document.CreateElement("category");
                questionCategoryElement.AppendChild(categoryElement);

                XmlElement categoryTextElement = document.CreateElement("text");
                categoryTextElement.InnerText = "$course$/top/" + categoria;
                categoryElement.AppendChild(categoryTextElement);

                int baseSerial = 152670;

                // Iterar sobre los problemas de 4 en 4
                for (int i = 0; i < problemasDistBinomial.Length; i += 4) {
                    if (i + 3 >= problemasDistBinomial.Length) {
                        break; // No hay suficientes sub-problemas para formar una pregunta completa
                    }

                    // Obtenemos los 4 problemas que corresponden a un único enunciado principal
                    ProblemaDistBinomial problemaBase = problemasDistBinomial[i]; // El primero del grupo (para descripción general)
                    ProblemaDistBinomial problemaExacto = problemasDistBinomial[i];
                    ProblemaDistBinomial problemaASumo = problemasDistBinomial[i + 1];
                    ProblemaDistBinomial problemaALMenos = problemasDistBinomial[i + 2];
                    ProblemaDistBinomial problemaIntervalo = problemasDistBinomial[i + 3];

                    // Crear el elemento <question> para este problema principal
                    XmlElement questionElement = document.CreateElement("question");
                    questionElement.SetAttribute("type", "cloze");
                    quizElement.AppendChild(questionElement);

                    // 1. Nombre de la pregunta: Formato QXX-VYYY (ej. Q01-V001)
                    XmlElement nameElement = document.CreateElement("name");
                    XmlElement nameTextElement = document.CreateElement("text");

                    //Nombre del problema
                    nameTextElement.InnerText = $"Q01-V{((i/4) + 1):000}";
                    nameElement.AppendChild(nameTextElement);
                    questionElement.AppendChild(nameElement);

                    // Texto de la pregunta principal
                    XmlElement questionTextElement = document.CreateElement("questiontext");
                    questionTextElement.SetAttribute("format", "html");
                    questionElement.AppendChild(questionTextElement);

                    XmlElement textElement = document.CreateElement("text");
                    StringBuilder questionContent = new StringBuilder();

                    // La descripción base del problema principal (ej: "En n ensayos, la probabilidad es p...")
                    // ya viene pre-formateada desde DistBinomial.cs con {n} y {p}
                    questionContent.Append($"<p>{problemaBase.Descripcion}</p>");
                    questionContent.Append("<p>Calcule lo siguiente:</p>");
                    questionContent.Append("<ol type=\"a\">"); // Lista ordenada con letras (a, b, c, d)

                    // a) Exacto
                    // Quitamos "en n intentos" porque ya está dicho en el enunciado principal
                    questionContent.Append($"<li>La probabilidad de que sean <b>exactamente</b> {problemaExacto.K} éxitos: {{1:NUMERICAL:={Math.Round(problemaExacto.Respuesta, 4):F4}:0.0001}}</li>");

                    // b) A lo sumo
                    questionContent.Append($"<li>La probabilidad de que sean <b>a lo sumo</b> {problemaASumo.K} éxitos: {{1:NUMERICAL:={Math.Round(problemaASumo.Respuesta, 4):F4}:0.0001}}</li>");

                    // c) Al menos
                    questionContent.Append($"<li>La probabilidad de que sean <b>al menos</b> {problemaALMenos.K} éxitos: {{1:NUMERICAL:={Math.Round(problemaALMenos.Respuesta, 4):F4}:0.0001}}</li>");

                    // d) Intervalo
                    int kInf = problemaIntervalo.KInferior.GetValueOrDefault();
                    int kSup = problemaIntervalo.K;
                    // (Lógica de swap kInf/kSup se mantiene igual)
                    questionContent.Append($"<li>La probabilidad de que sean <b>entre {kInf} y {kSup}</b> éxitos: {{1:NUMERICAL:={Math.Round(problemaIntervalo.Respuesta, 4):F4}:0.0001}}</li>");

                    questionContent.Append("</ol>"); // Cerrar lista ordenada

                    textElement.InnerText = questionContent.ToString();
                    questionTextElement.AppendChild(textElement);

                    // Retroalimentación general
                    XmlElement generalFeedbackElement = document.CreateElement("generalfeedback");
                    generalFeedbackElement.SetAttribute("format", "html");
                    XmlElement feedbackTextElement = document.CreateElement("text");
                    StringBuilder feedbackContent = new StringBuilder();
                    feedbackContent.Append("<p>Respuestas:</p>");
                    feedbackContent.Append("<ol type=\"a\">");
                    feedbackContent.Append($"<li>Exactamente {problemaExacto.K} éxitos: {problemaExacto.Respuesta:F4}</li>");
                    feedbackContent.Append($"<li>A lo sumo {problemaASumo.K} éxitos: {problemaASumo.Respuesta:F4}</li>");
                    feedbackContent.Append($"<li>Al menos {problemaALMenos.K} éxitos: {problemaALMenos.Respuesta:F4}</li>");
                    feedbackContent.Append($"<li>Entre {kInf} y {kSup} éxitos: {problemaIntervalo.Respuesta:F4}</li>");
                    feedbackContent.Append("</ol>");
                    feedbackTextElement.InnerText = feedbackContent.ToString();
                    generalFeedbackElement.AppendChild(feedbackTextElement);
                    questionElement.AppendChild(generalFeedbackElement);

                    // Información oculta de Moodle
                    XmlElement hiddenTagsElement = document.CreateElement("hidden");
                    hiddenTagsElement.InnerText = "0";
                    questionElement.AppendChild(hiddenTagsElement);

                    // Elemento para las penalizaciones
                    XmlElement penaltyElement = document.CreateElement("penalty");
                    penaltyElement.InnerText = "0.3333333";
                    questionElement.AppendChild(penaltyElement);

                    // Elemento para el ID del archivo
                    XmlElement qtypeTagElement = document.CreateElement("qtype_tag");
                    qtypeTagElement.InnerText = (baseSerial + (i / 4)).ToString();
                    questionElement.AppendChild(qtypeTagElement);
                }

                // Guardar el documento XML
                document.Save(rutaArchivo);
            } catch (Exception ex) {
                throw new Exception("Ocurrió un error al generar el archivo XML de Distribución Binomial: " + ex.Message, ex);
            }
        }
    }
}