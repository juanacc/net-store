using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ContextStore : DbContext
    {
        //Creo el constructor
        public ContextStore(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }

    //Para poder utilizar ContextStore en cualquier otro componente, tengo que agregarlo al contenedor de inyeccion de dependencias.
    //A esto lo tengo que realizar en el proyecto API, archivo Program.cs
}