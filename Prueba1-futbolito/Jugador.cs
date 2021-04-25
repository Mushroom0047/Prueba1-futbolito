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

        public Jugador() {}

        public Jugador(int registro, String nombre, String posicion, int resistencia, int velocidad, int fuerza, int destreza) {
            Registro = registro;
            Nombre = nombre;
            Posicion = posicion;
            Resistencia = resistencia;
            Velocidad = velocidad;
            Fuerza = fuerza;
            Destreza = destreza;
    }

        public int registro { get { return Registro; } }
        public String posicion { get { return Posicion; } }


        public string DatosJugador() {
            String playerData;
            playerData = $"{Posicion}, {Nombre}, Resistencia: {Resistencia}, Velocidad: {Velocidad}, Fuerza: {Fuerza} y Destreza: {Destreza}";
            return playerData;
        }
    }
}
