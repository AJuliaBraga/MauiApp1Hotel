
using MauiApp1Hotel.models;

namespace MauiApp1Hotel
{
    public partial class App : Application
    {

        public List<quarto> lista_quartos = new List<quarto>
        {
            new quarto()
            {
                Descricao = "Suíte Super Luxo",
                QuartoAdulto = 110.00,
                QuartoCrianca = 55.00, 
            },

            new quarto()
            {
                Descricao = "Suíte Luxo",
                QuartoAdulto = 80.00,
                QuartoCrianca = 40.00,
            },

            new quarto()
            {
                Descricao = "Suíte single",
                QuartoAdulto = 50.00,
                QuartoCrianca = 25.00,
            },

            new quarto()
            {
                Descricao = "Suíte",
                QuartoAdulto = 25.00,
                QuartoCrianca = 10.00,
            },
        };  // selecionar o using para include no model
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new views.contratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400; 
            window.Height = 600;

            return window;
      
    }  }
  
}
