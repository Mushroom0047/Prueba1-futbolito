using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1_futbolito {
    class Program {
        public static List<Jugador> Equipo = new List<Jugador>();

        public static Boolean CheckArr(int reg) {
            for (int i = 0; i < Equipo.Capacity; i++) {
                if (Equipo[i].registro == reg) {
                    return true;                    
                }
            }
            return false;
        }
        static void Main(string[] args) {           
            
            int option = -1;
            String[] playerValue = new string[7];

            while (option != 0) {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Bienvenido a Futbolito Man Boy");
                Console.ResetColor();

                Console.WriteLine("Escoge una opcion");
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("1: Agregar jugador \n2: Eliminar jugador \n3: Buscar jugador \n4: Mostrar equipo \n5: Cambiar titular a suplente \n6: Salir");
                try {
                    option = int.Parse(Console.ReadLine());                    
                } catch (System.FormatException) {
                    option = -1;                   
                }

                switch (option){
                    case 1:
                        int[] playerData = new int[5];

                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("------------Ingreso nuevo jugador------------");
                        Console.WriteLine("_______________________________________________________");
                        Console.ResetColor();
                        Console.WriteLine("Favor ingrese los datos del jugador");

                        //Save the register number
                        do {
                            Console.WriteLine("Ingrese el Registro del jugador");
                            playerData[0] = int.Parse(Console.ReadLine());
                        } while (CheckArr(playerData[0]));
                        //Save the player's name
                        Console.WriteLine("Ingrese el Nombre del jugador");
                        playerData[0] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la Posición del jugador");

                        Console.WriteLine("Ingrese la Resistencia del jugador");

                        Console.WriteLine("Ingrese la Velocidad del jugador");

                        Console.WriteLine("Ingrese la Fuerza del jugador");

                        Console.WriteLine("Ingrese la Destreza del jugador");

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        option = 0;
                        
                        break;
                }
            }
        }        
    }
}
