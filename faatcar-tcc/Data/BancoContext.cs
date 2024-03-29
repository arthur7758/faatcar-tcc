﻿using faatcar_tcc.Models;
using Microsoft.EntityFrameworkCore;

namespace faatcar_tcc.Data
{
    public class BancoContext:DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options) {  } 

        public DbSet < UsuarioModel> Usuarios { get; set; }
    }

}
