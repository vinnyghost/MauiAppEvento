using MauiAppEvento.Views;

namespace MauiAppEvento
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            // Iniciar tela de Cadastro, dentro de uma NavigationPage para permitir a navegação.
            MainPage = new NavigationPage(new CadastroEvento());
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