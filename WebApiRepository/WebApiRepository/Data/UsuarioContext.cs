﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRepository.Models;

namespace WebApiRepository.Data
{
    public class UsuarioContext:DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        { 
        
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
