namespace GEOPREST.com.data {
    internal class ProblemasPredefinidos {
        public string ejercicio;
        public int numAlumnos;
        public int minDatos;
        public int maxDatos;
        public double limInf;
        public double limSup;
        public int numDecimales;
        public int nIntervalos;

        public ProblemasPredefinidos() {
            //Constructor vacio
        }

        public ProblemasPredefinidos(string ejercicio, int numAlumnos, int minDatos, int maxDatos, double limInf,
            double limSup, int numDecimales, int nIntervalos) {
            this.ejercicio = ejercicio;
            this.numAlumnos = numAlumnos;
            this.minDatos = minDatos;
            this.maxDatos = maxDatos;
            this.limInf = limInf;
            this.limSup = limSup;
            this.numDecimales = numDecimales;
            this.nIntervalos = nIntervalos;
        }

        public ProblemasPredefinidos GenerarProblema(int index) {
            numAlumnos = 10;
            nIntervalos = 5;
            if (index == 0) {
                ejercicio = "Los siguientes datos muestran las Estaturas de los alumnos del grupo 1502. En base a estos datos, calcula la media, varianza, desviación estándar y el coeficiente de variación:";
                minDatos = 20; maxDatos = 30; numDecimales = 2;
                limInf = 1.55; limSup = 1.95;
            } else if (index == 1) {
                ejercicio = "Un alumno del grupo 1502 está desarrollando una página web para una empresa grande, en el cual, para brindar el mejor servicio, registro los tiempos de respuesta del servidor para calcular el posible tráfico que puede registrar su página. Con los siguientes datos calcula la media, varianza, desviación estándar y coeficiente de variación del tiempo de respuesta de la página web:";
                minDatos = 50; maxDatos = 100; numDecimales = 4;
                limInf = 0.0034; limSup = 2.7832;
            } else if (index == 2) {
                ejercicio = "Un técnico recibe un cliente el cual le pide que mejore la velocidad de su laptop. El técnico analiza los niveles de uso del procesador (%) para comprobar si es necesario comprar un nuevo equipo o no. Calcula el las medidas de dispersión de los datos obtenidos por el técnico e indica si es necesario actualizar el equipo o no (Un C.V. mayor a 35 indicaría un cambio de equipo):";
                minDatos = 20; maxDatos = 40; numDecimales = 1;
                limInf = 20; limSup = 98;
            } else if (index == 3) {
                ejercicio = "En base a los siguientes tamaños de los archivos (en megabytes) de una computadora, calcula la media y las medidas de dispersión de todos los archivos:";
                minDatos = 50; maxDatos = 100; numDecimales = 2;
                limInf = 15; limSup = 700;
            } else if (index == 4) {
                ejercicio = "El encargado del área de sistemas tomo la temperatura del servidor (en grados Celsius) durante una semana, para así determinar si es necesario modificar el equipo de enfriamiento o no. Calcula las medidas de dispersión de los datos e indica si se necesita cambiar el equipo de enfriamiento o no. (Un C.V. mayor a 23 podría resultar peligroso para el equipo)";
                minDatos = 40; maxDatos = 60; numDecimales = 1;
                limInf = 30; limSup = 94.4;
            } else if (index == 5) {
                ejercicio = "A continuación, se muestran los resultados de las encuestas de satisfacción de los usuarios por un nuevo servicio de Internet inalámbrico, siendo 1 = muy insatisfecho, hasta 5 = muy satisfecho. Calcula la media, varianza, desviación estándar y coeficiente de variación de dichos datos:";
                minDatos = 50; maxDatos = 100; numDecimales = 0;
                limInf = 1; limSup = 5;
            } else if (index == 6) {
                ejercicio = "Los siguientes datos son el número de líneas de código que tiene cada Script en un programa. Calcula la media, varianza, desviación estándar y coeficiente de variación de dichos datos:";
                minDatos = 50; maxDatos = 70; numDecimales = 0;
                limInf = 63; limSup = 514;
            } else if (index == 7) {
                ejercicio = "Un profesor de informática está interesado en saber cuántos errores producen los programas de sus alumnos en la primera compilación, por lo que investiga y obtiene los siguientes datos. Calcula las medidas de dispersión de dichos datos:";
                minDatos = 20; maxDatos = 30; numDecimales = 0;
                limInf = 0; limSup = 32;
            } else if (index == 8) {
                ejercicio = "Un informático está interesado en desarrollar un programa que reciba los correos electrónicos de los empleados de una empresa, para ello, debe calcular cuanto espacio deberá dedicar por persona para almacenar los correos. El informático decidió recabar los datos del número de correos electrónicos que tienen actualmente los empleados. Calcula las medidas de dispersión de dichos datos:";
                minDatos = 30; maxDatos = 50; numDecimales = 0;
                limInf = 200; limSup = 350;
            }
            ProblemasPredefinidos p1 = new ProblemasPredefinidos(ejercicio, numAlumnos, minDatos,
                maxDatos, limInf, limSup, numDecimales, nIntervalos);
            return p1;
        }

        public string GetEjercicio() {
            return ejercicio;
        }

        public string GetNumAlumnos() {
            return numAlumnos.ToString();
        }

        public string GetMinDatos() {
            return minDatos.ToString();
        }

        public string GetMaxDatos() {
            return maxDatos.ToString();
        }

        public string GetLimInf() {
            return limInf.ToString();
        }

        public string GetLimSup() {
            return limSup.ToString();
        }

        public string GetNumDecimales() {
            return numDecimales.ToString();
        }

        public string GetNIntervalos() {
            return nIntervalos.ToString();
        }

    }
}
