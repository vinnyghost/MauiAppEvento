using MauiAppEvento.Models;

namespace MauiAppEvento.Views
{
    public partial class ResumoEvento : ContentPage
    {
        // O construtor recebe o objeto Evento preenchido da página anterior
        public ResumoEvento(Evento evento)
        {
            InitializeComponent();

            this.BindingContext = evento;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PopAsync();

            }
            catch (Exception ex)
            {
                DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

    }
}