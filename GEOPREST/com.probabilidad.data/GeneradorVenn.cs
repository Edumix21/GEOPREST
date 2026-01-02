using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace GEOPREST.com.probabilidad.data {
    internal class GeneradorVenn {
        private Random random = new Random();
        private bool[] visibilidadCirculos;
        private bool[] mostrarNumeros;
        private string variableExterna;
        private string variableInterseccion;
        private int rangoMin;
        private int rangoMax;

        public GeneradorVenn(bool[] visibilidadCirculos, bool[] mostrarNumeros, string variableExterna, string variableInterseccion, int rangoMin, int rangoMax) {
            this.visibilidadCirculos = visibilidadCirculos;
            this.mostrarNumeros = mostrarNumeros;
            this.variableExterna = variableExterna;
            this.variableInterseccion = variableInterseccion;
            this.rangoMin = rangoMin;
            this.rangoMax = rangoMax;
        }

        //Si el valor isPreview es true, no se generaran numeros aleatorios
        public int[] GenerarImagen(Graphics graphics, bool isPreview = false) {
            //Arreglo int donde se guardan los valores de los circulos
            int[] valCirculos = new int[4];
            for (int i = 0; i < valCirculos.Length; i++) {
                valCirculos[i] = 0;
            }

            //Se declara el tamaño de los circulos
            int circleSize = 125;

            //Fondo de color blanco
            graphics.Clear(Color.White);

            //Se generan los 3 circulos de distinto color cada uno
            Color[] colors = { Color.Red, Color.Blue, Color.Green };
            Rectangle[] circles = {
                new Rectangle(50, 50, circleSize, circleSize),
                new Rectangle(135, 50, circleSize, circleSize),
                new Rectangle(225, 175, circleSize, circleSize)
            };
            string[] letras = { "A", "B", "C" };

            //Recorre el array de 3 elementos para saber que circulos se van a mostrar y cuales no
            for (int i = 0; i < circles.Length; i++) {
                if (visibilidadCirculos[i]) {
                    DibujarCirculo(graphics, circles[i], colors[i]);
                    valCirculos[i] = DibujarContenido(graphics, circles[i], circleSize, letras[i], mostrarNumeros[i], isPreview);
                }
            }

            string sumatoria = "" + Sumatoria(valCirculos);

            //Verifica si se requiere dibujar una variable fuera de los circulos
            if (!string.IsNullOrEmpty(variableExterna)) {
                DibujarVariableExterna(graphics, variableExterna, sumatoria, isPreview);
            }

            //Verifica si se requiere dibujar una variable en la interseccion de los circulos
            if (!string.IsNullOrEmpty(variableInterseccion) && visibilidadCirculos[0] && visibilidadCirculos[1]) {
                valCirculos[3] = DibujarInterseccion(graphics, circles[0], circles[1], variableInterseccion, isPreview, valCirculos);
            }
            return valCirculos;
        }

        //Metodo para dibujar los circulos
        private void DibujarCirculo(Graphics graphics, Rectangle rect, Color color) {
            using (Pen pen = new Pen(color, 2)) {
                graphics.DrawEllipse(pen, rect);
            }
        }

        //Metodo para dibujar las letras o variables
        private int DibujarContenido(Graphics graphics, Rectangle rect, int circleSize, string letra, bool mostrarNumero, bool isPreview) {
            int randomNumber = 0;
            using (Font font = new Font("Arial", 12)) {
                //Verifica si quiere colocar el numero o solo la letra
                if (mostrarNumero) {
                    if (isPreview) randomNumber = 1;
                    else randomNumber = random.Next(rangoMin, rangoMax + 1);
                    graphics.DrawString(randomNumber.ToString(), font, Brushes.Black, rect.X + circleSize / 2 - 8, rect.Y + circleSize / 2 - 8);
                }
                //Dibujar la letra del circulo
                graphics.DrawString(letra, font, Brushes.Black, rect.X + circleSize / 2 - 8, rect.Y + circleSize / 2 + 8);
            }
            return randomNumber;
        }

        //Metodo para dibujar la variable fuera de los circulos
        private void DibujarVariableExterna(Graphics graphics, string variable, string valSumatoria, bool isPreview) {
            using (Font font = new Font("Arial", 12)) {
                graphics.DrawString(variable, font, Brushes.Black, 10, 10); // Posición fuera del círculo
                graphics.DrawString(valSumatoria, font, Brushes.Black, 60, 10);
            }
        }

        //Metodo para dibujar la variable dentro de la interseccion de los circulos
        private int DibujarInterseccion(Graphics graphics, Rectangle rect1, Rectangle rect2, string variable, bool isPreview, int[] valCirculos) {
            int valInterseccion;
            using (Font font = new Font("Arial", 12)) {
                //Ver el valor mas grande de los dos circulos
                int minValor;
                if (valCirculos[0] < valCirculos[1]) minValor = (int)(valCirculos[0] * 0.6);
                else minValor = (int)(valCirculos[1] * 0.6);

                //Dibujar la letra y el numero correspondiente
                int x = (rect1.X + rect2.X + rect1.Width) / 2 - 8;
                int y = (rect1.Y + rect2.Y) / 2 - 8;
                y = y + 40;
                graphics.DrawString(variable, font, Brushes.Black, x, y);
                if (isPreview) valInterseccion = 1;
                //Calcular un numero aleatorio para la interseccion (este sera max el 60% del valor maximo
                else valInterseccion = random.Next(1, minValor + 1);
                graphics.DrawString(valInterseccion.ToString(), font, Brushes.Black, x, y + 15);
            }
            return valInterseccion;
        }

        private int Sumatoria(int[] valores) {
            int sumatoria = 0;
            for (int i = 0; i < valores.Length; i++) {
                sumatoria += valores[i];
            }
            return sumatoria;
        }
    }
}