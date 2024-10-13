namespace CP2.API.Application.Dtos
{
    public class VendedorDto
    {
        public string Nome { get; set; }  
        public string Email { get; set; }  
        public string Telefone { get; set; }  
        public DateTime DataNascimento { get; set; }  
        public string Endereco { get; set; }  
        public DateTime DataContratacao { get; set; }  
        public decimal ComissaoPercentual { get; set; }  
        public decimal MetaMensal { get; set; }  
    }
}