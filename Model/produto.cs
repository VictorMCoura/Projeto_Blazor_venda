namespace AppVendasBlazor.Model
{
    public class Produto
    {
        public int Id { get; set;}

        public string Nome { get; set;}

        public string Descricao { get; set; }

        public int QuantidadeEstoque { get; set; }

        public string UnidadeMedida { get; set; }

        public Double PrecoUnitario { get; set; }

        public ICollection<ItemVenda> Itemvendas { get; set; }
    }
}
