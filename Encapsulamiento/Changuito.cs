using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Changuito
    {
        public int numero = 0;
        private List<Producto> _listadoProductos;
        public List<Producto> ListadoProductos
        {
            get 
            {
                return this.ListadoProductos;
            }
        }

        public Changuito()
        {
            this._listadoProductos = new List<Producto>();
        }

        public void agregarProducto(Producto p)
        {
            this._listadoProductos.Add(p);
     
        }

        
        

    }
}
