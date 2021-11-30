using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudWeb.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Cenario> Cenarios { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            this.Cenarios.AddRange(new Cenario { NomeCenario = "Galáxia", pathImg = "/img/teste2_orange.jpeg" }
                                , new Cenario { NomeCenario = "Terra", pathImg = "/img/teste1_lightblue.jpg" }
                                , new Cenario { NomeCenario = "Wakanda", pathImg = "/img/teste3_orangewhite.jpeg" }
                                , new Cenario { NomeCenario = "Nova York", pathImg = "/img/teste4_yellow.jpeg" }
                                , new Cenario { NomeCenario = "Asgard", pathImg = "/img/teste2_orange.jpeg" });
        }
    }
}

