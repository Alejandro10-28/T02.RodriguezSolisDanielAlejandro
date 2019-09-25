using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    public class Principal
    {
        public void Bienvenida()//Metodo de bienvenida al usuario
        {
            Console.WriteLine("Bienvenido a mi programa para sumar");
        }
        public void ObtenerDatos()//Metodo para obtener datos.
        {
            Console.WriteLine("Para iniciar presione un número:");
           int M=Convert.ToInt32(Console.ReadLine());//Se crea una variable que dara inicio y fin al ciclo
            double R;//Se crea una variable de tipo double para guardar los resultados de las sumas
            Operaciones S = new Operaciones();

            do//Se usa un ciclo do-while para que este se repita hasta que el usuario asi lo desee presionando 2.
            {
                Console.WriteLine("Ingresa valores a sumar por 3 parametros:");
                Console.WriteLine("Valor a:");
                double S1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor b:");
                double S2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor c:");
                double S3 = Convert.ToDouble(Console.ReadLine());
                R = S.Sumar(S1, S2, S3);//Se manda como parametro los 3 datos ingresados por el usuario al metodo que almacena 3 valores.
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Ingresa valores a sumar por 2 parametros:");
                Console.WriteLine("Valor a:");
                double S4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor b:");
                double S5 = Convert.ToDouble(Console.ReadLine());
                R = S.Sumar(S4, S5);//Se manda como parametro los 2 datos ingresados por el usuario al metodo que almacena 2 parametros
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Ingresa valores a sumar por 1 parametro (Con el determinado número 3):");
                Console.WriteLine("Valor a:");
                double S6 = Convert.ToDouble(Console.ReadLine());
              
                R = S.Sumar(S6);//Se manda como parametro el dato ingresado por el usuario al metodo que almacena un parametro..
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("¿Quieres repetir?\n1.si\n2.no");//Le pregunta al usuario si gusta seguir repitiendo el procedimiento o si quiere salir
                M =Convert.ToInt32(Console.ReadLine());
                Console.Clear();


            } while (M != 2);

        }
    }
}
