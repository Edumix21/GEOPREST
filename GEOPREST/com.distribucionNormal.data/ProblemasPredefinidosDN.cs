
namespace GEOPREST.com.distribucionNormal.data {
    internal class ProblemasPredefinidosDN {
        public string ejercicio;
        public int numProb;
        public double minMedia;
        public double maxMedia;
        public double minDesv;
        public double maxDesv;
        public int tipoProb;

        public ProblemasPredefinidosDN() {
        }

        public ProblemasPredefinidosDN(string ejercicio, int numProb, double minMedia, double maxMedia, double minDesv, double maxDesv, int tipoProb) {
            this.ejercicio = ejercicio;
            this.numProb = numProb;
            this.minMedia = minMedia;
            this.maxMedia = maxMedia;
            this.minDesv = minDesv;
            this.maxDesv = maxDesv;
            this.tipoProb = tipoProb;
        }

        public ProblemasPredefinidosDN CargarProblema(int index) {
            numProb = 10;
            if(index == 0) {
                ejercicio = "Un servidor web tiene un tiempo de respuesta que sigue una distribución normal con media (μ) de {m} ms y desviación estándar (σ) de {d} ms. Cuál es la probabilidad de que el tiempo de respuesta de una solicitud sea:";
                minMedia = 250; maxMedia = 350;
                minDesv = 35; maxDesv = 60; tipoProb = 1;
            } else if (index == 1) {
                ejercicio = "La latencia en una red de área local sigue una distribución normal con media (μ) de {m} ms y desviación estándar (σ) de {d} ms. Cuál es la probabilidad de que la latencia de una solicitud sea:";
                minMedia = 15; maxMedia = 25;
                minDesv = 3; maxDesv = 7; tipoProb = 1;
            } else if (index == 2) {
                ejercicio = "El tiempo que tarda una CPU en ejecutar un proceso sigue una distribución normal con una media (μ) de {m} ms y desviación estándar (σ) de {d} ms. Cuál es la probabilidad de que el tiempo de ejecución sea:";
                minMedia = 350; maxMedia = 700;
                minDesv = 60; maxDesv = 150; tipoProb = 0;
            } else if (index == 3) {
                ejercicio = "El servidor de bases de datos tiene un tiempo de consulta que sigue una distribución normal con media (μ) de {m} ms y desviación estándar (σ) de {d} ms. Cuál es la probabilidad de que una consulta aleatoria sea:";
                minMedia = 100; maxMedia = 170;
                minDesv = 10; maxDesv = 20; tipoProb = 0;
            } else if (index == 4) {
                ejercicio = "El tiempo que tarda en transferirse un archivo de 100 MB en una red local sigue una distribución normal con media (μ) de {m} segundos y desviación estándar (σ) de {d} segundos. Cuál es la probabilidad de que la transferencia sea:";
                minMedia = 1; maxMedia = 3;
                minDesv = 0.1; maxDesv = 0.3; tipoProb = 1;
            } else if (index == 5) {
                ejercicio = "El tiempo de carga de una página web sigue una distribución normal con media (μ) de {m} segundos y desviación estándar (σ) de {d} segundos. Cuál es la probabilidad de que una página tarde:";
                minMedia = 2; maxMedia = 3;
                minDesv = 0.2; maxDesv = 0.6; tipoProb = 0;
            } else if (index == 6) {
                ejercicio = "La cantidad de memoria usada por una aplicación en un servidor sigue una distribución normal con media (μ) de {m} MB y desviación estándar (σ) de {d} MB. Cuál es la probabilidad de que la aplicación consuma:";
                minMedia = 500; maxMedia = 550;
                minDesv = 60; maxDesv = 70; tipoProb = 1;
            } else if (index == 7) {
                ejercicio = "El tiempo que una conexión a una API permanece activa sigue una distribución normal con media (μ) de {m} ms y desviación estándar (σ) de {d} ms. Cuál es la probabilidad de que la conexión dure:";
                minMedia = 1000; maxMedia = 1500;
                minDesv = 80; maxDesv = 180; tipoProb = 0;
            } else if (index == 8) {
                ejercicio = "El tiempo que tarda un algoritmo de compresión en comprimir un archivo sigue una distribución normal con media (μ) de {m} segundos y desviación estándar (σ) de {d} segundos. Cuál es la probabilidad de que el algoritmo tarde:";
                minMedia = 7; maxMedia = 12;
                minDesv = 1; maxDesv = 2; tipoProb = 1;
            } else if (index == 9) {
                ejercicio = "El tiempo que tarda un sistema en verificar la integridad de un conjunto de datos sigue una distribución normal con media (μ) de {m} minutos y desviación estándar (σ) de {d} minutos. Cuál es la probabilidad de que el sistema tarde en realizar la verificación:";
                minMedia = 2.5; maxMedia = 5.5;
                minDesv = 0.2; maxDesv = 1; tipoProb = 0;
            }
            ProblemasPredefinidosDN p1 = new ProblemasPredefinidosDN(ejercicio, numProb, minMedia, maxMedia, minDesv, maxDesv, tipoProb);
            return p1;
        }
    }
}
