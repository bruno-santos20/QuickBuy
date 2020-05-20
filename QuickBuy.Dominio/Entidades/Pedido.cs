using QuickBuy.Dominio.Entidades.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
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
        public ICollection<ItemPedido>ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Critica - Pedido Não pode ficar vazio!");
                

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Critica - CEP deve estar preenchido!");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Crítica - Não informado a forma de pagamento");

        }
    }
}
