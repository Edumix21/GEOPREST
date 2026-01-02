using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOPREST.com.probabilidad.data {
    internal class ProblemasPredefinidosP {
        public int numProblemas;
        public double valMin;
        public double valMax;
        public string ejercicio;
        public bool[] circulos; // Activar/Desactivar circulos A, B y C

        public ProblemasPredefinidosP() {
        }

        public ProblemasPredefinidosP(int numProblemas, double valMin, double valMax, string ejercicio, bool[] circulos) {
            this.numProblemas = numProblemas;
            this.valMin = valMin;
            this.valMax = valMax;
            this.ejercicio = ejercicio;
            this.circulos = circulos;
        }

        public ProblemasPredefinidosP CargarProblemas(int index) {
            numProblemas = 10;
            circulos = new bool[3];
            if(index == 0) {
                ejercicio = "Si el espacio muestral de un experimento queda definido por los eventos A, B y C, que se muestran a continuación, calcular las siguientes probabilidades (respuestas con cuatro decimales):";
                valMin = 30; valMax = 130;
                circulos[0] = true; circulos[1] = true; circulos[2] = true;
            } else if (index == 1) {
                ejercicio = "En una empresa de software, los eventos A, B y C representan a los empleados que dominan Java, Python y C++, respectivamente. Si el espacio muestral está dado por estos eventos, calcula las siguientes probabilidades:";
                valMin = 10; valMax = 150;
                circulos[0] = true; circulos[1] = true; circulos[2] = true;
            } else if (index == 2) {
                ejercicio = "En una universidad, los eventos A, B y C representan a los estudiantes que están inscritos en los cursos de Redes y Bases de Datos. Con base en estos eventos, determina las probabilidades solicitadas:";
                valMin = 20; valMax = 200;
                circulos[0] = true; circulos[1] = true; circulos[2] = false;
            } else if (index == 3) {
                ejercicio = "Una empresa tecnológica realiza pruebas de compatibilidad de software con tres sistemas operativos: Windows (A), Linux (B) y MacOS (C). Si el espacio muestral está dado por estos eventos, calcula las siguientes probabilidades:";
                valMin = 15; valMax = 120;
                circulos[0] = true; circulos[1] = true; circulos[2] = true;
            } else if (index == 4) {
                ejercicio = "Los eventos A, B y C en un centro de investigación representan los proyectos que utilizan Machine Learning, Big Data y Cloud Computing. Calcula las probabilidades de los eventos mostrados a continuación:";
                valMin = 5; valMax = 50;
                circulos[0] = true; circulos[1] = true; circulos[2] = true;
            } else if (index == 5) {
                ejercicio = "En una empresa de desarrollo de videojuegos, los eventos A, B y C corresponden a los programadores que trabajan en Unreal Engine, Unity y Godot. Calcula las siguientes probabilidades:";
                valMin = 8; valMax = 75;
                circulos[0] = true; circulos[1] = true; circulos[2] = true;
            } else if (index == 6) {
                ejercicio = "En una compañía de ciberseguridad, A representa a los empleados que se especializan en firewalls y B en criptografía. Calcula las probabilidades de los siguientes eventos:";
                valMin = 12; valMax = 100;
                circulos[0] = true; circulos[1] = true; circulos[2] = false;
            } else if (index == 7) {
                ejercicio = "En un curso de ingeniería informática, A representa a los estudiantes que aprobaron el examen de estructuras de datos, B a los que aprobaron sistemas operativos, y C a los que aprobaron teoría de autómatas. Determina las probabilidades solicitadas:";
                valMin = 10; valMax = 180;
                circulos[0] = true; circulos[1] = true; circulos[2] = true;
            } else if (index == 8) {
                ejercicio = "Una empresa de desarrollo web tiene a sus programadores divididos en tres equipos: A (Frontend), B (Backend) y C (Fullstack). Calcula las probabilidades de los eventos definidos a continuación:";
                valMin = 7; valMax = 85;
                circulos[0] = true; circulos[1] = true; circulos[2] = true;
            } else if (index == 9) {
                ejercicio = "En una universidad, los eventos A, B y C representan a los estudiantes inscritos en los laboratorios de desarrollo móvil, inteligencia artificial y sistemas distribuidos, respectivamente. Con base en estos eventos, calcula las probabilidades:";
                valMin = 25; valMax = 210;
                circulos[0] = true; circulos[1] = true; circulos[2] = true;
            } else if (index == 10) {
                ejercicio = "En una empresa de tecnología, los eventos A y B representan a los empleados que utilizan servicios en la nube de AWS y Google Cloud, respectivamente. Determina las probabilidades de los eventos mostrados a continuación:";
                valMin = 20; valMax = 160;
                circulos[0] = true; circulos[1] = true; circulos[2] = false;
            }
            ProblemasPredefinidosP p1 = new ProblemasPredefinidosP(numProblemas, valMin, valMax, ejercicio, circulos);
            return p1;
        }
    }
}
