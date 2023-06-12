using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clase_8_6
{
    public class MenuPrincipal
    {
        Reclamo reclamo = new Reclamo();
        elegirTurno elegirTurno = new elegirTurno();
        public int opcion { get; set; }
        public bool banderaGeneral { get; set; } = false;
        public void MenuInicial(){
            do{
                Console.WriteLine("\nMunicipalidad de general pueyrredon: Atención al publico\n\n" +
                    "Elija una opción para continuar\n\n[1] Reclamos\n[2] Turnos\n[-1] Salir\n");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("RECLAMOS:\n\n");
                        reclamo.Reclamos1();
                        break;
                    case 2:
                        Console.WriteLine("TURNOS:\n\nElija una opción para continuar\n\n" +
                            "[1] Licencia de conducir\n[2] A.R.M\n[-1] Volver al Menu Principal\n");
                        opcion = int.Parse(Console.ReadLine());
                        do
                        {
                            banderaGeneral = false;
                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("Licencia de conducir:\n\n");
                                    elegirTurno.seleccionLicencia();
                                    break;
                                case 2:
                                    Console.WriteLine("A.R.M:\n\n");
                                    elegirTurno.seleccionArm();
                                    break;
                                case -1:
                                    Console.WriteLine("\nVolviendo al menu principal");                              
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("\nLa opción elegida es incorrecta o no esta disponible\n" +
                                    "Intentelo de nuevo");
                                    Console.Clear();
                                    banderaGeneral = true;
                                    break;
                            }
                        } while (banderaGeneral != false);                        
                        break;
                    case -1:
                        Console.WriteLine("\nGracias por consultar");
                        banderaGeneral = true;
                        break;
                    default:
                        Console.WriteLine("\nLa opción elegida es incorrecta o no esta disponible\n" +
                            "Intentelo de nuevo");
                        Console.Clear();
                        break;
                }
            }while (banderaGeneral != true);
        }

    }
}
