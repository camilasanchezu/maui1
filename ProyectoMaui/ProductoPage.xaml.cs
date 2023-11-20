using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ProductoApp1;
using ProyectoMaui.Models;
using System.Collections.ObjectModel;

namespace ProyectoMaui;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
		InitializeComponent();
		
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var productos = new ObservableCollection<Producto>(Utils.Utils.ListaProducto);
        listaProductos.ItemsSource = productos;
    }



    private async void OnClickNuevoProducto(object sender, EventArgs e)
    {
		//var toast = Toast.Make("On Click Boton Nuevo Producto", ToastDuration.Short, 14);
		//await toast.Show();
		await Navigation.PushAsync(new NuevoProductoPage());


    }
    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Click en ver producto", ToastDuration.Short, 14);

        await toast.Show();
        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage()
        {
            BindingContext = producto,
        });
    }

}