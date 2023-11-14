using ProyectoMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMaui.Utils
{
    class Utils
    {
        public static List<Producto> ListaProducto = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "Harina",
                Descripcion = "Marca Patito",
                Cantidad = 20
            },

            new Producto()
            {
                IdProducto = 2,
                Nombre = "Cepillo",
                Descripcion = "Marca Patito",
                Cantidad = 15
            },

            new Producto()
            {
                IdProducto = 3,
                Nombre = "TV",
                Descripcion = "Marca Sony",
                Cantidad = 2
            }
        };


    }
}
