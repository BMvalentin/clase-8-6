using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_8_6
{
    public class elegirTurno 
    {

        SolicitarDatos solicitarDatos = new SolicitarDatos();
        public void seleccionLicencia()
        {
            Console.WriteLine("SELECCIONE LA OPCION CORRESPONDIENTE DE LICENCIA");
            Console.WriteLine("<1> PARA SACAR LA LICENCIA DE CONDUCIR");
            Console.WriteLine("<2> PARA RENOVAR");
            int  op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Random rnd = new Random();
                    int year = rnd.Next(2023, 2024);
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
                    DateTime fechaAleatoria = new DateTime(year, month, day);
                    Console.WriteLine("SACAR LICENCIA DE CONDUCIR");
                    solicitarDatos.solicitarDatos();
                    Console.WriteLine("Usted tiene turno para el el examén teórico el día: " + fechaAleatoria);
                    Console.WriteLine("Usted tiene turno para el el examén práctico el día: " + fechaAleatoria);
                    break;

                case 2:
                    Random rnd = new Random();
                    int year = rnd.Next(2023, 2024);
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
                    DateTime fechaAleatoria = new DateTime(year, month, day);
                    Console.WriteLine("RENOVAR LA LICENCIA DE CONDUCIR");
                    solicitarDatos.solicitarDatos(); 
                    Console.WriteLine("Usted tiene turno para renovar la licencia el dia: " + fechaAleatoria);
                    break;
                           

             }
         }
        public void seleccionArm() 
        {
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(5000, 30000);
            Console.WriteLine("ARM");
            Console.WriteLine(" Ingrese <1> si quiere pagar factura \n\n ");
            Console.WriteLine("Ingrese <2> si quiere pagar su tasa ");
            int op2 = int.Parse(Console.ReadLine());

            switch (op2)
            {
                case 1:
                    Console.WriteLine("PAGAR FACTURAS");
                    solicitarDatos.solicitarDatos();
                    Console.WriteLine("El monto a pagar es de: $" + numeroAleatorio);
                    break;

                case 2:
                    Console.WriteLine("PAGAR TASA");
                    solicitarDatos.solicitarDatos();
                    Console.WriteLine("El monto de la tasa fija anual es de $25000");
                    break;

            default:
                    Console.WriteLine("INGRESE UNA OPCION VALIDA");
            break; 
            }
        }
    }
}
