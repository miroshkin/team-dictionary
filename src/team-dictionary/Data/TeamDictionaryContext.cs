using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace team_dictionary.Data
{
public class TeamDictionaryContext : DbContext
{
    public TeamDictionaryContext (DbContextOptions<TeamDictionaryContext> options)
        : base(options)
    {
    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Translation> Translations { get; set; }
    public DbSet<SqlQuery> SqlQueries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("TeamDictionaryContext");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
}
