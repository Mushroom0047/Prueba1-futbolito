using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1_futbolito {
    class Jugador {
        private int Registro;
        private String Nombre;
        private String Posicion;
        private int Resistencia;
        private int Velocidad;
        private int Fuerza;
        private int Destreza;

        public Jugador() {

        }

        public int registro { get { return Registro; } }        


        public string DatosJugador() {
            String playerData;
            playerData = "posición";

            return playerData;
        }
    }
}
