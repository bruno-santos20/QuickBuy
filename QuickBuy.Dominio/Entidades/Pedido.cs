using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public  DateTime DataPedido { get; set; }
        public string UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }


    }
}
