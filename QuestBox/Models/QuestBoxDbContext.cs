using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace QuestBox.Models
{
    public class QuestBoxDbContext : IdentityDbContext<Users, IdentityRole<int>,int>
    {
        public QuestBoxDbContext(DbContextOptions<QuestBoxDbContext> options) : base(options)
        {

        }
        public DbSet<Comand> Comands { get; set; }
    }
}
