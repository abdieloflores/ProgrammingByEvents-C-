using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_8_Objetos
{
    class Gato
    {
        //Atributos (Los toma automaticamente como privados si no le ponemos el public) ---------------
        private string name;
        private string color;
        private string patas;
        private string colorOjos;
        //Metodos -------------------------------------------------------------------------------------
        //Constructor 1
        public Gato(string name, string color, string patas, string colorOjos) {
            this.name = name;
            this.color = color;
            this.patas = patas;
            this.colorOjos = colorOjos;
        }
        //Constructor 2
        public Gato() { }

        //Setters and Getters
        public void setName(string name) {
            this.name = name;
        }
        public void setColor(string color) {
            this.color = color;
        }
        public void setPatas(string patas) {
            this.patas = patas;
        }
        public void setColorOjos(string colorOjos) {
            this.colorOjos = colorOjos;
        }
        public void show() {
            Console.WriteLine("El gato llamada {0} de color {1}, tiene patas {2} y ojos de color {3}", name,color, patas, colorOjos);
        }
    }
}
