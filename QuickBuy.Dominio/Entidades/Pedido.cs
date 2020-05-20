using QuickBuy.Dominio.Entidades.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        //endereço
        public string  CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }

        //forma de pagamento 
        public int  FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }


        //pedido deve ter pelo menos um pedido ou mais
        public ICollection<ItemPedido> ItemPedidos { get; set; }




   
    }
}
