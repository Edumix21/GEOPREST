using System;

namespace GEOPREST.com.tablasContingencia.data {
    internal class ProblemasPredefinidosTC {
        public int numProb;
        public string nombreFila;
        public string nombreColumna;
        public string txtEjercicio;
        public string valTabla1;
        public string valTabla2;
        public string valTabla3;
        public string valTabla4;
        public int nMin;
        public int nMax;

        public ProblemasPredefinidosTC() { }

        public ProblemasPredefinidosTC(int numProb, string nombreFila, string nombreColumna, string txtEjercicio, string valTabla1, string valTabla2, string valTabla3, string valTabla4, int nMin, int nMax) {
            this.numProb = numProb;
            this.nombreFila = nombreFila;
            this.nombreColumna = nombreColumna;
            this.txtEjercicio = txtEjercicio;
            this.valTabla1 = valTabla1;
            this.valTabla2 = valTabla2;
            this.valTabla3 = valTabla3;
            this.valTabla4 = valTabla4;
            this.nMin = nMin;
            this.nMax = nMax;
        }

        public ProblemasPredefinidosTC CargarProblema(int index) {
            numProb = 10;

            // NOTA: Hemos eliminado la nota explicativa al final del texto porque ahora
            // las letras A, B, C, D están integradas en los nombres de la tabla.

            if (index == 0) {
                txtEjercicio = "En una empresa de desarrollo de software, se realizó una auditoría para evaluar el rendimiento de los equipos. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Proyectos"; nombreColumna = "Desarrolladores";
                valTabla1 = "A. Proyecto A"; valTabla2 = "B. Proyecto B";
                valTabla3 = "C. Desempeño Alto"; valTabla4 = "D. Desempeño Bajo";
                nMin = 20; nMax = 60;
            } else if (index == 1) {
                txtEjercicio = "En una empresa de ciberseguridad, se evaluó la respuesta ante amenazas en dos tipos de redes. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Redes"; nombreColumna = "Conexiones";
                valTabla1 = "A. Red Interna"; valTabla2 = "B. Red Externa";
                valTabla3 = "C. Conexiones Seguras"; valTabla4 = "D. Conexiones Vulnerables";
                nMin = 20; nMax = 60;
            } else if (index == 2) {
                txtEjercicio = "En un análisis de rendimiento de aplicaciones, se midieron las respuestas de dos servicios web. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Servicios"; nombreColumna = "Tiempos de Respuesta";
                valTabla1 = "A. Servicio A"; valTabla2 = "B. Servicio B";
                valTabla3 = "C. Rápido"; valTabla4 = "D. Lento";
                nMin = 20; nMax = 60;
            } else if (index == 3) {
                txtEjercicio = "En un estudio de control de calidad de software, se revisaron dos aplicaciones. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Aplicaciones"; nombreColumna = "Estado";
                valTabla1 = "A. Aplicación X"; valTabla2 = "B. Aplicación Y";
                valTabla3 = "C. Con Errores"; valTabla4 = "D. Sin Errores";
                nMin = 20; nMax = 60;
            } else if (index == 4) {
                txtEjercicio = "En una prueba de estabilidad de bases de datos, se revisaron conexiones en dos bases de datos. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Bases de Datos"; nombreColumna = "Conexiones";
                valTabla1 = "A. Base de Datos 1"; valTabla2 = "B. Base de Datos 2";
                valTabla3 = "C. Estables"; valTabla4 = "D. Inestables";
                nMin = 20; nMax = 60;
            } else if (index == 5) {
                txtEjercicio = "En una empresa de tecnología, se evaluó el nivel de satisfacción de los usuarios de dos aplicaciones móviles. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Aplicaciones"; nombreColumna = "Usuarios";
                valTabla1 = "A. Aplicación Alfa"; valTabla2 = "B. Aplicación Beta";
                valTabla3 = "C. Satisfechos"; valTabla4 = "D. Insatisfechos";
                nMin = 20; nMax = 60;
            } else if (index == 6) {
                txtEjercicio = "En un análisis de seguridad informática, se revisaron dos tipos de archivos. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Tipos de Archivos"; nombreColumna = "Estado de Seguridad";
                valTabla1 = "A. Ejecutables"; valTabla2 = "B. Documentos";
                valTabla3 = "C. Limpios"; valTabla4 = "D. Infectados";
                nMin = 20; nMax = 60;
            } else if (index == 7) {
                txtEjercicio = "En una auditoría de redes, se evaluaron los dispositivos en dos segmentos de red. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Segmentos de Red"; nombreColumna = "Dispositivos";
                valTabla1 = "A. Segmento A"; valTabla2 = "B. Segmento B";
                valTabla3 = "C. Conectados"; valTabla4 = "D. Desconectados";
                nMin = 20; nMax = 60;
            } else if (index == 8) {
                txtEjercicio = "En una prueba de control de versiones, se compararon los commits en dos ramas de un proyecto. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Ramas"; nombreColumna = "Commits";
                valTabla1 = "A. Rama Principal"; valTabla2 = "B. Rama Experimental";
                valTabla3 = "C. Exitoso"; valTabla4 = "D. Fallido";
                nMin = 20; nMax = 60;
            } else if (index == 9) {
                txtEjercicio = "En una empresa de desarrollo de software, se evaluaron los tickets de soporte de dos equipos. En base a los siguientes datos, calcula las probabilidades que se solicitan.";
                nombreFila = "Equipos"; nombreColumna = "Tickets";
                valTabla1 = "A. Equipo Backend"; valTabla2 = "B. Equipo Frontend";
                valTabla3 = "C. Resueltos"; valTabla4 = "D. Pendientes";
                nMin = 20; nMax = 60;
            }

            ProblemasPredefinidosTC p1 = new ProblemasPredefinidosTC(numProb, nombreFila, nombreColumna, txtEjercicio, valTabla1, valTabla2, valTabla3, valTabla4, nMin, nMax);
            return p1;
        }
    }
}