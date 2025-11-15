using MauiAppEvento.Views;

namespace MauiAppEvento
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            // Iniciar na tela Home, dentro de uma NavigationPage para permitir a navegação.
            MainPage = new NavigationPage(new Home());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 800;

            return window;
        }
    }
}