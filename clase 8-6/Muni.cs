using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_8_6
{
    class elegirTurno 
    {
      public  void turnos()
        {
            
            Console.WriteLine("SELECCIONE EL TURNO CORRESPONDIENTE");
            Console.WriteLine("<L> TURNO PARA LICENCIA DE CONDUCIR");
            Console.WriteLine("<A> ARM (PAGO DE TAZAS E IMPUESTOS) ");
            char op = Console.ReadKey().KeyChar;
            char upperop = Char.ToUpper(op);

            switch(upperop) 
            {
                
            }
        }

      
    }
}
