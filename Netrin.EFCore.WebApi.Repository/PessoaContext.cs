﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Netrin.EFCore.WebApi.Domain;

namespace Netrin.EFCore.WebApi
{
    //Classe responsável pelo encapsulamento das entidades
    // CodeFist: Banco será criado a partir do contexto
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options){}

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }

}
