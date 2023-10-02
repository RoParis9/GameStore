using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameStore.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        public DbSet<Game> Games {get;set;}
        
    }
}