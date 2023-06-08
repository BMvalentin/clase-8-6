using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_8_6
{
    public class Reclamo
    {
        public byte Opcion { get; set; } = 0;
        public string MensajeDeReclamo { get; set; }

        public void Main() {
            Console.WriteLine("                    RECLAMOS");
            Console.WriteLine("Elija la opcion que corresponda a su reclamo: ");
            Console.WriteLine("1. Vecinos");
            Console.WriteLine("2. Empleados municipales");
            Console.WriteLine("3. Estado del sector publico");
            Console.WriteLine("4. Pago de deudas");
            Console.WriteLine("5. Sector privado ");
            Console.WriteLine("6. Volver al menu anterior");
            Console.Write("Su opcion: ");
            try
            {
                Opcion = byte.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Ingrese su reclamo: ");
                MensajeDeReclamo = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Algo salio mal :( \n intente nuevamente");
                Console.ReadKey();
                Console.Clear();
            }
        }
        

    }
}
