using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public class Usuario : Entidade//cadastro de usuario
    {

        public int Id { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }


        //um ou mais pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não foi informado");
        }
    }
}
