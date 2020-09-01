using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfajor a = new Alfajor(10, 8.5); //Clase Alfajor que se encarga de asignar el precio
            Kiosco k = new Kiosco(); //Clase Kiosko que se encarga de ver si pueden comprar, y de cambiar la moneda
            //No cumple con el modelo SRP, dado a que la clase Kiosko tiene más de una responsabilidad, las cuales deberian estar separadas

            if (k.PuedeComprar(a, 15, "$"))
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}
