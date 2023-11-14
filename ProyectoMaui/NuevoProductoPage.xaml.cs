using Microsoft.Maui.Graphics.Text;
using ProyectoMaui.Models;

namespace ProyectoMaui;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
	}

    private void OnClickGuardarProducto(object sender, EventArgs e)
    {
        int id = Utils.Utils.ListaProducto.Count;
        Utils.Utils.ListaProducto.Add(new Producto
        {
            IdProducto = id+1,
            Nombre = Nombre.Text,
            Descripcion = Descripcion.Text,
            Cantidad = Int32.Parse(Cantidad.Text),
        }
        );
    }
}