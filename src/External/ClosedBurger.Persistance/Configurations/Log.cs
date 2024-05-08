using ClosedBurger.Domain.CompanyEntities;
using ClosedBurger.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClosedBurger.Persistance.Configurations
{
    public sealed class Log : IEntityTypeConfiguration<Logs>
    {
        public void Configure(EntityTypeBuilder<Logs> builder)
        {
            builder.ToTable(TableNames.Logs);
            builder.HasKey(t => t.Id);
        }
    }
}
