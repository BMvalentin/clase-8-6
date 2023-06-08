using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_8_6
{
    class elegirTurno 
    {
        public void seleccionTurno()
        {
            Console.WriteLine("SELECCIONE EL TURNO CORRESPONDIENTE");
            Console.WriteLine("<1> PARA LICENCIA DE CONDUCIR");
            Console.WriteLine("<2> ARM (TASAS E IMPUESTOS)");
           int  op = int.Parse(Console.ReadLine());

            

            switch (op)
            {
                case 1:


                break;

                case 2:
                            Random rnd = new Random();
                            int numeroAleatorio = rnd.Next(5000, 30000);
                            Console.WriteLine("ARM");
                            Console.WriteLine (" Ingrese <1> si quiere pagar factura \n\n ");
                            Console.WriteLine ("Ingrese <2> si quiere pagar su tasa ");
                            int op2 = int.Parse (Console.ReadLine());
                    SolicitarDatos();
                            switch (op2)
                           {
                            case 1: 
                                Console.WriteLine ("PAGAR FACTURAS");
                                Console.WriteLine ("Identifiquese con su dni: ");
                                int dniconsulta = int.Parse (Console.ReadLine());
                                Console.WriteLine ("El monto a pagar es de: $"+ numeroAleatorio);
                            break;

                            case 2:
                                Console.WriteLine("PAGAR TASA");
                                Console.WriteLine ("Identifiquese con su dni: ");
                                int dniconsulta1 = int.Parse (Console.ReadLine());
                                Console.WriteLine("El monto de la tasa fija anual es de $25000");
                            break;

                         }
                break;

                default:
                    Console.WriteLine("INGRESE UNA OPCION VALIDA");
                    break;

             }
         }

    }
    
}
