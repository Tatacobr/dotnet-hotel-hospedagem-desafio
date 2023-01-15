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

        public void CadastrarHospedes(List<Pessoa> hospedes){
            Console.WriteLine($"Capacidade da Suite: {Suite.Capacidade} Número de hospedes: {hospedes.Count()}");
            if (Suite.Capacidade >= hospedes.Count()){
                Hospedes = hospedes;
            }
            else{
                Console.WriteLine("Não foi possível realizar cadastro: Capacidade ultrapassada");
            }
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria(){
            decimal valor = DiasReservados * Suite.ValorDiaria;

            return DiasReservados >= 10 ? (valor/100 * 90) : valor;
        }
    }
}