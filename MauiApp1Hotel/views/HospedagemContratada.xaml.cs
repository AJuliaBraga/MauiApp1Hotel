using System.Linq.Expressions;

namespace MauiApp1Hotel.views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync(); 
		}
		catch (Exception ex)
		{
			DisplayAlert("ops", ex.Message, "OK");
		}
    }
}