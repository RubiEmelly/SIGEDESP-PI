﻿using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Data.Map
{
    public class FornecedorMap : IEntityTypeConfiguration<FornecedorModel>
    {
        public void Configure(EntityTypeBuilder<FornecedorModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeFantasia).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Situacao).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Rua).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(50);
            builder.Property(x => x.nomeRazaoSocial).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);

        }
    }
}