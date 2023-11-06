namespace Tarea1._3;

public partial class ListaPage : ContentPage
{
	public ListaPage()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var listaPersonas = await App.DataBaseSQLite.ObtenerListaPersonas();
        lstPersonas.ItemsSource = listaPersonas;
    }

    private async void lstPersonas_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Models.Personas item = (Models.Personas) e.Item;

        var page = new UpdatePage();
        page.BindingContext = item;
        await Navigation.PushAsync(page);
    }
}