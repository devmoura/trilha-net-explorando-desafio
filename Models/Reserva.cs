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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                try
                {
                    throw new Exception("Não há capacidade suficiente para registrar essa quantidade de hóspedes.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exceção capturada: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Programa Encerrado");
                }
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int QuantidadePessoas = Hospedes.Count;
            return QuantidadePessoas;
        }

        public decimal CalcularValorDiaria()
        {
            decimal CalculoTotal = 0.0M;

            if (DiasReservados >= 10)
            {
                CalculoTotal = (DiasReservados * Suite.ValorDiaria) - (DiasReservados * Suite.ValorDiaria * 10 / 100);
            }
            else
            {
                CalculoTotal = DiasReservados * Suite.ValorDiaria;
            }

            return CalculoTotal;
        }
    }
}
