using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOPREST.com.distribucionBinomial.data {
    internal class ProblemasPredefinidosDB {
        public string ejercicio;
        public string textoContextoN; // Nuevo campo para el contexto de 'n'
        public int numProb;
        public int minEnsayos;
        public int maxEnsayos;
        public double minProb;
        public double maxProb;

        public ProblemasPredefinidosDB() {
        }

        public ProblemasPredefinidosDB(string ejercicio, string textoContextoN, int numProb, int minEnsayos, int maxEnsayos, double minProb, double maxProb) {
            this.ejercicio = ejercicio;
            this.textoContextoN = textoContextoN;
            this.numProb = numProb;
            this.minEnsayos = minEnsayos;
            this.maxEnsayos = maxEnsayos;
            this.minProb = minProb;
            this.maxProb = maxProb;
        }

        public ProblemasPredefinidosDB CargarProblema(int index) {
            numProb = 10;
            // Valor por defecto para seguridad
            textoContextoN = "Se realizan {n} ensayos.";

            if (index == 0) {
                ejercicio = "En una red de computadoras vieja, la probabilidad de que un paquete no se pierda durante la transmisión es del {p}%.";
                textoContextoN = "Se transmiten {n} paquetes.";
                minEnsayos = 10; maxEnsayos = 30; minProb = 0.04; maxProb = 0.07;

            } else if (index == 1) {
                ejercicio = "Un estudiante de informática responde al azar preguntas de opción múltiple en un test.";
                textoContextoN = "El examen consta de {n} preguntas.";
                minEnsayos = 15; maxEnsayos = 30; minProb = 0.25; maxProb = 0.25;

            } else if (index == 2) {
                ejercicio = "En una aplicación web, solo el {p}% de las solicitudes al servidor no son rechazadas por errores de autenticación.";
                textoContextoN = "Se reciben {n} solicitudes consecutivas.";
                minEnsayos = 15; maxEnsayos = 25; minProb = 0.07; maxProb = 0.20;

            } else if (index == 3) {
                ejercicio = "Durante las pruebas de un programa, cada caso de prueba tiene una probabilidad del {p}% de no fallar.";
                textoContextoN = "Se ejecutan {n} casos de prueba.";
                minEnsayos = 12; maxEnsayos = 20; minProb = 0.15; maxProb = 0.27;

            } else if (index == 4) {
                ejercicio = "En un curso de programación, la probabilidad de que un alumno entregue una tarea a tiempo es del {p}%.";
                textoContextoN = "Se evalúa un grupo de {n} alumnos.";
                minEnsayos = 8; maxEnsayos = 15; minProb = 0.60; maxProb = 0.79;

            } else if (index == 5) {
                ejercicio = "En un torneo de eSports, la probabilidad de que un jugador acierte una habilidad especial en una partida es del {p}%.";
                textoContextoN = "Se toman a azar {n} jugadores.";
                minEnsayos = 10; maxEnsayos = 25; minProb = 0.30; maxProb = 0.45;

            } else if (index == 6) {
                ejercicio = "Un servidor en la nube responde correctamente a una solicitud con una probabilidad del {p}%.";
                textoContextoN = "Llegan {n} solicitudes al servidor.";
                minEnsayos = 20; maxEnsayos = 40; minProb = 0.80; maxProb = 0.95;

            } else if (index == 7) {
                ejercicio = "Un programador junior logra compilar un programa sin errores con probabilidad del {p}%.";
                textoContextoN = "Realiza {n} intentos de compilación.";
                minEnsayos = 10; maxEnsayos = 20; minProb = 0.25; maxProb = 0.40;

            } else if (index == 8) {
                ejercicio = "La probabilidad de que un dron entregue un paquete sin incidentes es del {p}%.";
                textoContextoN = "Se programan {n} entregas con drones.";
                minEnsayos = 12; maxEnsayos = 25; minProb = 0.70; maxProb = 0.90;

            } else if (index == 9) {
                ejercicio = "En una partida de un videojuego, un jugador tiene {p}% de probabilidad de encontrar un ítem raro en cada intento.";
                textoContextoN = "El jugador realiza {n} intentos de búsqueda.";
                minEnsayos = 15; maxEnsayos = 30; minProb = 0.05; maxProb = 0.15;

            } else if (index == 10) {
                ejercicio = "Un robot en una fábrica ensambla una pieza correctamente con una probabilidad del {p}%.";
                textoContextoN = "El robot procesa un lote de {n} piezas.";
                minEnsayos = 10; maxEnsayos = 20; minProb = 0.85; maxProb = 0.95;

            } else if (index == 11) {
                ejercicio = "En un curso online, la probabilidad de que un estudiante responda correctamente una pregunta de repaso es del {p}%.";
                textoContextoN = "El estudiante responde {n} preguntas.";
                minEnsayos = 12; maxEnsayos = 20; minProb = 0.40; maxProb = 0.60;

            } else if (index == 12) {
                ejercicio = "Un sensor de movimiento detecta correctamente la presencia en un área con una probabilidad del {p}%.";
                textoContextoN = "Se realizan {n} pruebas de detección.";
                minEnsayos = 15; maxEnsayos = 25; minProb = 0.65; maxProb = 0.85;

            } else if (index == 13) {
                ejercicio = "Un estudiante de informática logra compilar correctamente su código en el primer intento con probabilidad del {p}%.";
                textoContextoN = "Se observan {n} intentos de compilación independientes.";
                minEnsayos = 8; maxEnsayos = 15; minProb = 0.20; maxProb = 0.35;

            } else if (index == 14) {
                ejercicio = "En una encuesta digital, la probabilidad de que un usuario complete el formulario es del {p}%.";
                textoContextoN = "Se envía la encuesta a {n} usuarios.";
                minEnsayos = 10; maxEnsayos = 18; minProb = 0.50; maxProb = 0.70;

            } else if (index == 15) {
                ejercicio = "Un antivirus detecta correctamente un archivo malicioso con probabilidad del {p}%.";
                textoContextoN = "El antivirus escanea {n} archivos infectados.";
                minEnsayos = 15; maxEnsayos = 25; minProb = 0.75; maxProb = 0.90;

            } else if (index == 16) {
                ejercicio = "Un cajero automático entrega billetes sin errores con una probabilidad del {p}%.";
                textoContextoN = "Se realizan {n} operaciones de retiro.";
                minEnsayos = 10; maxEnsayos = 20; minProb = 0.85; maxProb = 0.98;

            } else if (index == 17) {
                ejercicio = "En un videojuego de disparos, la probabilidad de que un jugador acierte un tiro es del {p}%.";
                textoContextoN = "El jugador dispara {n} veces.";
                minEnsayos = 12; maxEnsayos = 25; minProb = 0.20; maxProb = 0.45;

            } else if (index == 18) {
                ejercicio = "Una impresora 3D completa correctamente una pieza con probabilidad del {p}%.";
                textoContextoN = "Se imprimen {n} piezas en serie.";
                minEnsayos = 8; maxEnsayos = 15; minProb = 0.60; maxProb = 0.80;

            } else if (index == 19) {
                ejercicio = "Un repartidor logra entregar un pedido en el tiempo estimado con probabilidad del {p}%.";
                textoContextoN = "El repartidor tiene {n} pedidos asignados.";
                minEnsayos = 12; maxEnsayos = 22; minProb = 0.55; maxProb = 0.75;

            } else if (index == 20) {
                ejercicio = "Un estudiante que practica algoritmos resuelve un problema correctamente con probabilidad del {p}%.";
                textoContextoN = "Intenta resolver {n} problemas distintos.";
                minEnsayos = 10; maxEnsayos = 18; minProb = 0.35; maxProb = 0.55;
            }

            return new ProblemasPredefinidosDB(ejercicio, textoContextoN, numProb, minEnsayos, maxEnsayos, minProb, maxProb);
        }
    }
}