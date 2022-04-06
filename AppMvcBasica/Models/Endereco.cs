namespace AppMvcBasica.Models
{
    public class Endereco : Entity 
    {
        public Guid FornecedorId { get; set; }
        public string Logradouro { get; set; }
    }
}
