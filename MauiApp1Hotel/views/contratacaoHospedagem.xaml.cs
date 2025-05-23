namespace MauiApp1Hotel.views;

public partial class contratacaoHospedagem : ContentPage
{

	App PropriedadeApp; 
	public contratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadeApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadeApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);


		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkout.Date.AddMonths(6);

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContratada());

		}
		catch (Exception ex)
		{
			DisplayAlert("ops", ex.Message, "OK");
		
		}
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada = elemento.Date;

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkout.Date.AddMonths(6);


    }
}