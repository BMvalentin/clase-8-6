using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_8_6
{
    public class SolicitarDatos
    {
        string tipoDocumento, numeroDocumento, nombreApellido, sexo,correoElectronico,telefonoCelular;
        int op;
        public void solicitarDatos(int op)
        {
            
            Console.WriteLine("Datos Personales");
            Console.WriteLine("Tipo de documento:\n<1> DNI\n<2> LC\n<3> LE\n<4> PAS");
            op = int.Parse(Console.ReadLine());
            elegirTipoDocumento(op, tipoDocumento);      
            Console.WriteLine("Número de documento: ");
            numeroDocumento = Console.ReadLine();   
            Console.WriteLine("Apellido y Nombre: ");
            nombreApellido = Console.ReadLine();
            Console.WriteLine("Sexo:\n<1> Femenino\n<2> Masculino");
            elegirSexo(op);    
            Console.WriteLine("Correo Electrónico: ");
            correoElectronico = Console.ReadLine();
            Console.WriteLine("Teléfono Celular: ");
            telefonoCelular = Console.ReadLine();
        }
        public void elegirTipoDocumento(int op, string tipoDocumento)
        {
            do
            {
                switch (op)
                {
                    case 1:
                        tipoDocumento = "DNI";
                        break;
                    case 2:
                        tipoDocumento = "LC";
                        break;
                    case 3:
                        tipoDocumento = "LE";
                        break;
                    case 4:
                        tipoDocumento = "PAS";
                        break;

                }
            } while (op != 1 || op != 2 || op != 3 || op != 4);
        }
        public void elegirSexo(int op)
        {
            do
            {
                switch (op)
                {
                    case 1:
                        sexo = "Femenino";
                        break;
                    case 2:
                        sexo = "Masculino";
                        break;
                }
            } while (op != 1 || op != 2);
        }
    }
}
