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
        public static ObservableCollection<Producto> ListaProducto = new ObservableCollection<Producto>
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
