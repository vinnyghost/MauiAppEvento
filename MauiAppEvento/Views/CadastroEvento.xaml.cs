using MauiAppEvento.Models;

namespace MauiAppEvento.Views
{
    public partial class CadastroEvento : ContentPage
    {
        public CadastroEvento()
        {
            InitializeComponent();

            // Utiliza o BindingContext para associar
            // os dados a uma model de classe Evento.
            this.BindingContext = new Evento();
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Recupera o objeto Evento do BindingContext
            Evento evento = (Evento)this.BindingContext;

            // Validação de datas
            if (evento.DataTermino < evento.DataInicio)
            {
                await DisplayAlert("Erro", "A data de término não pode ser anterior à data de início.", "OK");
                return;
            }

            // Navega para a nova página, passando o objeto 'evento'
            // que contém todos os dados e os cálculos.
            await Navigation.PushAsync(new ResumoEvento(evento));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sobre());
        }
    }
}