using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Entidades.ObjetodeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
   public class QuickBuyContexto : DbContext
    {
        

        public DbSet<Usuario> Usuarios   { get; set; }//criar tabela na base de dados

        public DbSet<Produto> Produtos { get; set; }//criar tabela na base de dados

        public DbSet<Pedido> Pedidos { get; set; }//criar tabela na base de dados

        public DbSet<ItemPedido> ItensPedidos { get; set; }//criar tabela na base de dados

        public DbSet<FormaPagamento> FormaPagamento { get; set; }//criar tabela na base de dados


        //-----


        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//calsses de mapeamento
        {
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());


            base.OnModelCreating(modelBuilder);
        }


    }
}
           