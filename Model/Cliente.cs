namespace AppVendasBlazor.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string CpfCnpj { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

        public int Telefone { get; set;}
        public ICollection<Pedido> pedidos { get; set; }
    }
}
