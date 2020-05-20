using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _MensagensValidacao { get; set; }

        private List<string> MensagensValidacao
        {
            get { return _MensagensValidacao ?? (_MensagensValidacao = new List<string>()); }

        }

        /// <summary>
        /// limpar
        /// </summary>
        protected void LimparMensagensValidacao()
        {
            MensagensValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagensValidacao.Add(mensagem);

        }

           //fim

      

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !MensagensValidacao.Any(); }

        }


    }
}
