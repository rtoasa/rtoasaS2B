using System.Runtime.CompilerServices;

namespace rtoasaS2B.Views;

public partial class vHome : ContentPage
{
	public vHome()
	{
		InitializeComponent();
	}

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
		try
		{
			if (pkCiudades.SelectedIndex == -1) {
                DisplayAlert("Alerta", "No hay seleccion", "Cerrar");
            }else { 
            string dato = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();//0.1.2
            DisplayAlert("Alerta", "SELECCIONASTE " + dato, "Cerrar");
            }
            //FECHAS

            string fecha = dFechas.Date.ToString();
            lblFecha.Text = "LA FECHA SELECCIONADA ES " + fecha;


        }
		catch (Exception ex)
		{

           // DisplayAlert("Alerta", "No hay seleccion: Error  " +ex.Message, "Cerrar");
        }
		
    }
}