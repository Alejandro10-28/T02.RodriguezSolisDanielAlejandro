using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class Operaciones
    {
        //Se generan los metodos de sobrecarga sumar donde se harán sumas de 1 a 3 parametros
        double R2;//Se genera una variable de tipo global donde podran utilizarlos 3 metodos para guardar los resultados
        public double Sumar(double a)//Metodo con un parametro de tipo double.
        {
            R2 = a +3;
            Console.WriteLine("El resultado es:" + R2);
            return R2;//Se regresa el valor guardado en R2.
        }
        public double Sumar(double a,double b)//Metodo con dos parametros de tipo double.
        {
            R2 = a + b;
            Console.WriteLine("El resultado es:" + R2);

            return R2;
        }
        public double Sumar(double a, double b, double c)//Metodo con 3 parametros de tipo double.
        {
            R2 = a + b + c;
            Console.WriteLine("El resultado es:" + R2);

            return R2;
        }
    }
}
