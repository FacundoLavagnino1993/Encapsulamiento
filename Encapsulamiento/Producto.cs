using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Producto
    {
        public int id;
        Random random = new Random();

        private double _precioCosto;
        public double PrecioCosto
        {
            set
            {
                this._precioCosto = value;
            }
        }

        //Creamos propiedad; atributo sin ";" y se abren llaves.
        // Tienen dos metodos el get y el set.
        public Producto()
        {

        }
        public Producto(double precioCosto)
        {
            this.PrecioCosto = precioCosto;
            
        }
        public Producto(double precioCosto, int id):this()
        {
            this.id = random.Next(0, 10);
            
        }

        public double precioFinal
        {/*
            set 
            {
                value;// Siempre asigna algo, la palabra value trae el valor.
            }*/ 

            get
            {

                return this.calcularPrecioFinal();// Siempre retorna algo. 
            }
        }
        

        public double calcularPrecioFinal()
        {
            return this._precioCosto * 1.25;        
        }

        //Crear las funcionalidades necesarias para que retorne un id que no exista en el listado
        // que sea random y que este dentro de los margenes

    }
}
