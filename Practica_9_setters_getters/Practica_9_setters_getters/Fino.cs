using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_9_setters_getters
{
    //Clase Heredada de Perro
    class Fino:Perro
    {
        private bool pedigree;
        private int spots;

        public bool Pedigree{ get { return this.pedigree; }set { this.pedigree = value; } }
        public int Spots { get { return this.spots; }set { this.spots = value; } }

        public override void show() {
            base.show();
            if (pedigree == true) { Console.WriteLine("Pedrigree: Si");
            } else { 
                Console.WriteLine("Pedigree: No");
            }
            Console.WriteLine("Cantidad de manchas: {0}", spots);
        }


    }
}
