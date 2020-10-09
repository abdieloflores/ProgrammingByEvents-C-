using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Practica_9_setters_getters
{
    class Perro
    {
        //Atributos
        private string name;
        private string race;
        private string size;
        private string color;
        private string colorEyes;
        //Constructores
        public Perro() { }
        public Perro(string name, string race, string size, string color, string colorEyes) {
            this.name = name;
            this.race = race;
            this.size = size;
            this.color = color;
            this.colorEyes = colorEyes;
        }
        //Getters & Setters
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Race { get { return this.race; }set { this.race = value; } }
        public string Size { get { return this.size; }set { this.size = value; } }
        public string Color { get { return this.color; }set { this.color = value; } }
        public string ColorEyes { get { return this.colorEyes; }set { this.colorEyes = value; } }
        //Metodos
        public virtual void show() {
            Console.WriteLine("Nombre: {0}", name);
            Console.WriteLine("Raza: {0}", race);
            Console.WriteLine("Tamaño: {0}", size);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Color de Ojos: {0}", colorEyes);
        }
    }
}
