namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int capacid=Suite.Capacidade;
            int qtd= Hospedes.Count;
             if (capacid>=qtd)
            {
                Hospedes = hospedes;
            }
            else
            {   //importante ser uma excessão pro programa parar de rodar
                throw new ArgumentException("A suite não comporta o número de hospedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = 0;
            quantidadeHospedes += Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = 0;
            valorDiaria = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10)
            {

                valorDiaria -= valorDiaria * 0.10M;
            }

            return valorDiaria;
        }
    }
}