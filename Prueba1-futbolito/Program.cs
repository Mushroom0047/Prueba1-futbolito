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
                    } else {
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
        public static void ConsoleTitle(String text) {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-----------------{0}-----------------", text);
            Console.WriteLine("_______________________________________________________");
            Console.ResetColor();
        }

        public static void AddPlayers() {
            int v = 20;
            String[] names = { "Adrián Droide", "Andrés Trozado", "Igor Dito", "Juan Macho Seco", "Jorge Nitales", "Miguel Marco Gol", "Antonio Bragueta Suelta", "Oscar Acol", "Julio Feo", "Paul Vazo" };

            for (int i = 0; i < names.Length; i++) {
                Jugador x = new Jugador(i+100, names[i], "Delantero", v, v, v, v);
                Equipo.Add(x);
            }
        }
      

        static void Main(string[] args) {
            String playerPosition = "Sin posición";
            String playerName = "Sin nombre";
            int habilityPoints = 100;
            int option = -1;

            AddPlayers();
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

                        ConsoleTitle("Ingreso nuevo jugador");

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
                        if (Equipo.Count < 15) {
                            Equipo.Add(player);
                        } else {
                            Equipo.Add(player);
                            Equipo.RemoveAt(0);
                        }
                        
                        habilityPoints = 100;

                        break;
                    case 2://Delete player
                        ConsoleTitle("Eliminar jugador");
                        //Request player register
                        loop = true;
                        do {
                            Console.WriteLine("Ingrese el número de registro del jugador");
                            int playerNum = int.Parse(Console.ReadLine());

                            if (Equipo.Count > 0) {
                                foreach (Jugador j in Equipo){
                                    if (j.registro == playerNum) {
                                        //Show player data
                                        ConsoleTitle("Jugador encontrado !!!");
                                        Console.WriteLine(j.DatosJugador());

                                        //Check if the player is a goalkeeper
                                        if (j.posicion == "Portero") {
                                            Console.BackgroundColor = ConsoleColor.Red;
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("No puedes eliminar al portero del equipo");
                                            Console.ResetColor();
                                            loop = false;
                                        } else {
                                            //Ask if you are sure
                                            opc = -1;
                                            ConsoleTitle("¿ Esta seguro que lo desea eliminar ?");
                                            Console.WriteLine("1: SI \n2: NO");
                                            opc = int.Parse(Console.ReadLine());
                                            if (opc == 1) {
                                                Equipo.RemoveAt(Equipo.IndexOf(j));
                                                ConsoleTitle("Jugador eliminado");
                                                loop = false;
                                                break;
                                            } else {
                                                loop = true;
                                            }
                                        }
                                    } else {
                                        ConsoleTitle("El jugador NO existe");
                                    }
                                }
                            }
                        } while (loop);
                        break;
                    case 3://Serch player
                        ConsoleTitle("Ingrese jugador a buscar");
                        String wordToSearch = Console.ReadLine();
                        if (Equipo.Count > 0) {
                            foreach (Jugador j in Equipo) {
                                String chain = j.DatosJugador();
                                Boolean contain = chain.Contains(wordToSearch);
                                if (contain) {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Jugador encontrado:");
                                    Console.ResetColor();
                                    Console.WriteLine(j.DatosJugador());
                                }
                            }
                        } else {
                            ConsoleTitle("Sin coincidencias");
                        }
                        break;
                    case 4://Show team
                        //ConsoleTitle("Ingrese el número de jugador");
                        //int numb;
                        //try {
                        //    numb = int.Parse(Console.ReadLine());
                        //} catch (System.FormatException) {
                        //    numb = -1;
                        //}
                        //if (Equipo.Count >=  numb) {
                        //    Equipo[numb].DatosJugador
                        //} else {
                        //    ConsoleTitle("Sin coincidencias");
                        //}
                        break;
                    case 5://Change principal to secondary
                        break;
                    case 6://Exit
                        option = 0;
                        
                        break;
                }
            }
        }        
    }
}
