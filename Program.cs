using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase principal para mandar a llamar a los metodos Bienvenida() y Menu();
            Principal M = new Principal();
            M.Bienvenida();
            M.ObtenerDatos();
        }
    }
}
