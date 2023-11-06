namespace Tarea1._3;

public partial class UpdatePage : ContentPage
{
    public UpdatePage()
    {
        InitializeComponent();
    }

    private async void btneliminar_Clicked(object sender, EventArgs e)
    {
        var personas = await App.DataBaseSQLite.ObtenerPersona(Convert.ToInt32(txtid.Text));

        if (personas != null)
        {
            await App.DataBaseSQLite.EliminarPersonas(personas);
            await DisplayAlert("Eliminado", "Registro eliminado correctamente", "Ok");
            ClearScreen();
        }
    }

    private async void btnactualizar_Clicked(object sender, EventArgs e)
    {

        var personas = new Models.Personas
        {
            id = Convert.ToInt32(txtid.Text),
            nombre = this.txtnombre1.Text,
            apellido = this.txtapellido1.Text,
            edad = Convert.ToInt32(this.txtedad1.Text),
            correo = txtcorreo1.Text,
            direccion = txtdireccion1.Text
            

        };

        if (await App.DataBaseSQLite.GrabarPersonas(personas) != 0)
            await DisplayAlert("Actualizado", "Registro actualizado", "ok");
        else
            await DisplayAlert("Error", "Registro no actualizado", "ok");



    }

    private async void ClearScreen()
    {
        this.txtnombre1.Text = String.Empty;
        this.txtapellido1.Text = String.Empty;
        this.txtedad1.Text = String.Empty;
        this.txtcorreo1.Text = String.Empty;
        this.txtdireccion1.Text = String.Empty;

    }
}