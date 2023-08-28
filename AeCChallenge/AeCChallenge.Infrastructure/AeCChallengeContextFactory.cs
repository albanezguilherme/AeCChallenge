using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AeCChallenge.Infrastructure
{
    public class AeCChallengeContextFactory : IDesignTimeDbContextFactory<AeCChallengeContext>
    {
        public AeCChallengeContext CreateDbContext(string[] args)
        {
            string environment = "Development";

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<AeCChallengeContext>();

            var connectionString = configuration.GetConnectionString("dbConnection");
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("The connection string was not set " +
                "in the 'EFCORETOOLSDB' environment variable.");
            builder.UseSqlServer(connectionString);

            return new AeCChallengeContext(builder.Options);
        }
    }
}
