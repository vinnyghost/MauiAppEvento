namespace MauiAppEvento.Models
{
    // Model que armazena os dados do evento
    // e contém a lógica de negócio.
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Today;
        public DateTime DataTermino { get; set; } = DateTime.Today;
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Lógica que calcula a duração do evento em dias
        // Usamos .Date para ignorar a hora e garantir um cálculo de dias inteiros.
        public int DuracaoEmDias
        {
            get
            {
                // TimeSpan é usado para calcular a diferença
                TimeSpan duracao = DataTermino.Date - DataInicio.Date;

                // Adicionei 1 para tornar a contagem inclusiva.
                // Ex: 10/11 a 11/11 = 2 dias de evento. (11-10 = 1) + 1 = 2.
                // Ex: 10/11 a 10/11 = 1 dia de evento. (10-10 = 0) + 1 = 1.
                return duracao.Days + 1;
            }
        }

        // Lógica que calcula o custo total do evento
        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}