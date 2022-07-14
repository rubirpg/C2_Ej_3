using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor para X: ");
            int numx = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numx el valor de x
            Console.WriteLine("Introduzca el valor para y: ");
            int numy = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numy el valor de y
            
            
            Console.WriteLine("Introduzca el valor para N (número con decimales largo): ");
            double numn = Convert.ToDouble(Console.ReadLine()); //leemos y asignamos a numn el valor de N
            Console.WriteLine("Introduzca el valor para N (número con decimales largo): ");
            double numm = Convert.ToDouble(Console.ReadLine()); //leemos y asignamos a numm el valor de M



            //mostramos por pantalla los valores contenidos en las variables
            Console.WriteLine();
            Console.WriteLine("El valor de X es: " + numx);
            Console.WriteLine("El valor de Y es: " + numy);
            Console.WriteLine("El valor de N es: " + numn);
            Console.WriteLine("El valor de M es: " + numm);

            //mostramos por pantalla el resultado de sumar X e Y
            Console.WriteLine("Las suma del número X ({0}) y el numero Y ({1}) es: {2}.", numx, numy, numx + numy);

            //mostramos por pantalla el resultado de restar a X el valor de Y
            Console.WriteLine("Las resta del número X ({0}) y el número Y ({1}) es: {2}.", numx, numy, numx - numy);

            //mostramos por pantalla el resultado de multiplicar X por el valor de Y
            Console.WriteLine("El producto del número X ({0}) y el número Y ({1}) es: {2}.", numx, numy, numx * numy);

            //mostramos por pantalla el cociente de X entre el valor de Y
            Console.WriteLine("El cociente del número X ({0}) entre el número Y ({1}) es: {2}.", numx, numy, numx / numy);

            // mostramos por pantalla el resto X entre el valor de Y
            Console.WriteLine("El resto del número X ({0}) entre el número Y ({1}) es: {2}.", numx, numy, numx % numy);

            //mostramos por pantalla el resultado de sumar N y M
            Console.WriteLine("Las suma del número N ({0}) y el numero M ({1}) es: {2}.", numn, numm, numn + numm);

            //mostramos por pantalla el resultado de restar a N el valor de M
            Console.WriteLine("Las resta del número N ({0}) y el número M ({1}) es: {2}.", numn, numm, numn - numm);

            //mostramos por pantalla el resultado de multiplicar N por el valor de M
            Console.WriteLine("El producto del número N ({0}) y el número M ({1}) es: {2}.", numn, numm, numn * numm);

            //mostramos por pantalla el cociente de N entre el valor de M
            Console.WriteLine("El cociente del número N ({0}) entre el número M ({1}) es: {2}.", numn, numm, numn / numm);

            //mostramos por pantalla el resto N entre el valor de M
            Console.WriteLine("El resto del número N ({0}) entre el número M ({1}) es: {2}.", numn, numm, numn % numm);

            //mostramos por pantalla el doble de cada variable
            Console.WriteLine("El doble del número X ({0}) es: {1}.", numx, numx * numx);
            Console.WriteLine("El doble del número Y ({0}) es: {1}.", numy, numy * numy);
            Console.WriteLine("El doble del número N ({0}) es: {1}.", numn, numn * numn);
            Console.WriteLine("El doble del número M ({0}) es: {1}.", numm, numm * numm);

            //mostramos por pantalla la suma de todas las variables
            Console.WriteLine("La suma de X ({0}), Y ({1}), N ({2}) y M ({3}) es : {4}.", numx, numy, numn, numm, numx + numy + numn + numm);

            //mostramos por pantalla la producto de todas las variables
            Console.WriteLine("El producto de X ({0}), Y ({1}), N ({2}) y M ({3}) es : {4}.", numx, numy, numn, numm, numx * numy * numn * numm);
        }
    }
}