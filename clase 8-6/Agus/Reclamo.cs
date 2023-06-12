using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_8_6
{
    
    public class Reclamo
    {
        SolicitarDatos SolicitarDatos = new SolicitarDatos();
        public byte Opcion { get; set; } = 0;
        public string MensajeDeReclamo { get; set; }

        public void Reclamos1()
        {
            console.WriteLine("Ingrese sus datos");
            SolicitarDatos.solicitarDatos();
            Console.WriteLine("Ingrese su reclamo: ");
            Console.ReadLine (MensajeDeReclamo());
            Console.WriteLine( MensajeDeReclamo());
        }
    }
}
