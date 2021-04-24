using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1_futbolito {
    class Program {
        public static List<Jugador> Equipo = new List<Jugador>();

        public static Boolean CheckArr(int reg) {
            Boolean result = false;
            //Change negative number
            if (reg < 0)reg = reg * -1;

            if (Equipo.Count >0) {
                for (int i = 0; i < Equipo.Capacity; i++) {
                    if (Equipo[i].registro == reg) {
                        result = true;
                        break;
                    }
                }
            } else {
                result =  false;
            }
            return result;
        }

        public static void AlertDialog() {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Los puntos superan el límite");
            Console.ResetColor();
        }

        public static void ConsoleIntro(int h) {
            Console.WriteLine("Ingrese un número de 0 a {0}", h);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("puntos restantes: {0}", h);
            Console.ResetColor();
            Console.WriteLine("_______________________________________________________");
        }

        static void Main(string[] args) {
            String playerPosition = "Sin posición";
            String playerName = "Sin nombre";
            int habilityPoints = 100;
            int option = -1;


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
                        Console.WriteLine("-----------------Ingreso nuevo jugador-----------------");
                        Console.WriteLine("_______________________________________________________");
                        Console.ResetColor();




                        //Save the register number
                        Boolean loopReg = true;
                        do {
                            Console.WriteLine("Ingrese el Registro del jugador");
                            try {
                                playerData[0] = int.Parse(Console.ReadLine());
                            }catch (System.FormatException) {
                                playerData[0] = 0;
                            }

                            //check if reg number exist or not
                            if (CheckArr(playerData[0])) {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("El registro ya existe! favor ingrese otro");
                                Console.ResetColor();
                            } else {
                                loopReg = false;
                            }
                            
                        } while (loopReg);

                        //Save the player's name
                        Console.WriteLine("Ingrese el Nombre del jugador");
                        playerName = Console.ReadLine();

                        //Save the position of player
                        int opc = -1;
                        while (opc != 0) {
                            Console.WriteLine("Ingrese la Posición del jugador");
                            Console.WriteLine("1: Portero \n2: Defensa \n3: Medio campo \n4: Delantero");

                            try {
                                opc = int.Parse(Console.ReadLine());
                            } catch (System.FormatException) {
                                opc = -1;
                            }
                            switch (opc) {
                                case 1:
                                    playerPosition = "Portero";
                                    opc = 0;
                                    break;
                                case 2:
                                    playerPosition = "Defensa";
                                    opc = 0;
                                    break;
                                case 3:
                                    playerPosition = "Medio campo";
                                    opc = 0;
                                    break;
                                case 4:
                                    playerPosition = "Delantero";
                                    opc = 0;
                                    break;
                                 default:
                                    opc = -1;
                                    break;
                            }
                        }
                        //check Attributes
                        Boolean loop = true;
                        int varSwi = 1;
                        int n;
                        while (loop) {
                            //Stop the loop
                            if (varSwi == 5) loop = false;
                            switch (varSwi) {
                                case 1:
                                    Console.WriteLine("Ingrese la Resistencia del jugador");
                                    ConsoleIntro(habilityPoints);                                    
                                    n = int.Parse(Console.ReadLine()); ;
                                    if (n > 0 && n <= habilityPoints) {                                        
                                        habilityPoints -= n;
                                        playerData[1] = n;
                                        varSwi = 2;
                                    } else {
                                        AlertDialog();
                                        varSwi = 1;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese la Velocidad del jugador");
                                    ConsoleIntro(habilityPoints);                                    
                                    n = int.Parse(Console.ReadLine()); ;
                                    if (n > 0 && n <= habilityPoints) {
                                        habilityPoints -= n;
                                        playerData[2] = n;
                                        varSwi = 3;
                                    } else {
                                        AlertDialog();
                                        varSwi = 2;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Ingrese la Fuerza del jugador");
                                    ConsoleIntro(habilityPoints);                                    
                                    n = int.Parse(Console.ReadLine()); ;
                                    if (n > 0 && n <= habilityPoints) {
                                        habilityPoints -= n;
                                        playerData[3] = n;
                                        varSwi = 4;
                                    } else {
                                        AlertDialog();
                                        varSwi = 3;
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Ingrese la Destreza del jugador");
                                    ConsoleIntro(habilityPoints);                                    
                                    n = int.Parse(Console.ReadLine()); ;
                                    if (n > 0 && n <= habilityPoints) {
                                        habilityPoints -= n;
                                        playerData[4] = n;
                                        varSwi = 5;
                                    } else {
                                        AlertDialog();
                                        varSwi = 4;
                                    }
                                    break;
                            }                            
                        }
                        //Create Jugador object                      
                        Jugador player = new Jugador(playerData[0], playerName, playerPosition, playerData[1], playerData[2], playerData[3], playerData[4]);
                        //Save object Jugador in tha array
                        Equipo.Add(player);

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
