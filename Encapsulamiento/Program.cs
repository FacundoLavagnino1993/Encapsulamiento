using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulamiento -- Dentro de la clase se tiiene lo que se necesita y solo mostrar datos.
            Producto prod1 = new Producto();
            Changuito chango = new Changuito();
            double precio;
            precio = prod1.PrecioCosto = 200;
            precio = prod1.precioFinal; // precioFinal deja de ser un atributo y pasa a ser una propiedad;

            chango.agregarProducto(prod1);

            foreach (Producto item in chango.ListadoProductos)
            {
                Console.WriteLine(item.precioFinal); 
            }

            List<Producto> NuevaLista = new List<Producto>(); 
         

           
        }

       
    }
}
