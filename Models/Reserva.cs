namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }

        
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int capacidade = 3;
            if (capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Exceção genérica, número de hóspedes maior que a capacidade dos quartos.");
            }
        }
            
               
            
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            Console.WriteLine($"O número de hóspedes hospedados no hotel é: {Hospedes.Count()}");
            return Hospedes.Count();
        }
            

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * this.Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                return valor - (valor * 0.1M);
            }
            return valor;
        }
    }
}


            
            
            
            

            
            
                

            
            
