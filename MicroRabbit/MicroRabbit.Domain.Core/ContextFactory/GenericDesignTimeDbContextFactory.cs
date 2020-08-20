using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MicroRabbit.Domain.Core.ContextFactory
{
    public class GenericDesignTimeDbContextFactory<T> : IDesignTimeDbContextFactory<T> where T : DbContext
    {
        private readonly string _connectionStringKey;

        public GenericDesignTimeDbContextFactory(string connectionStringKey)
        {
            _connectionStringKey = connectionStringKey;
        }

        public T CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<T>();
            //var connectionString = configuration.GetConnectionString("BankingDbConnection");
            var connectionString = configuration.GetConnectionString(_connectionStringKey);

            builder.UseSqlServer(connectionString);

            var dbContext = (T)Activator.CreateInstance(typeof(T), builder.Options);

            return dbContext;
        }
    }

    //public class BankingDesignTimeDbContextFactory : GenericDesignTimeDbContextFactory<BankingDesignTimeDbContextFactory>
    //{
    //}
}