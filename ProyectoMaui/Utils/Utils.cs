using ProyectoMaui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMaui.Utils
{
    class Utils
    {
        static public List<Producto> ListaProducto = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "CALM",
                Descripcion = "5 Seconds of Summer",
                Cantidad = 20
            },

            new Producto()
            {
                IdProducto = 2,
                Nombre = "Scaled and Icy",
                Descripcion = "Twenty One Pilots",
                Cantidad = 15
            },

            new Producto()
            {
                IdProducto = 3,
                Nombre = "Believer",
                Descripcion = "Imagine Dragons",
                Cantidad = 2
            },

            new Producto()
            {
                IdProducto = 3,
                Nombre = "The Maybe Man",
                Descripcion = "AJR",
                Cantidad = 27
            }


        };


    }
}
