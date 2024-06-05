namespace AppVendasBlazor.Model
{
    public class ItemVenda
    {
        public int ProdutoId { get; set; } 

        public Produto Produto { get; set; }

        public int PedidoId { get; set; }

        public Pedido pedido { get; set; }

        public int QuantidadeProduto { get; set;}

        public double PrecoUnitario { get; set; }
    }
}
