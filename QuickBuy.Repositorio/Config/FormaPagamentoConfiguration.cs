﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {

        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            throw new NotImplementedException();
        }
    }
}
