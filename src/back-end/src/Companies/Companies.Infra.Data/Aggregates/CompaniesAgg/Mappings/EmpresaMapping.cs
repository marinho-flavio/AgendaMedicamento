using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bravo.Companies.Infra.Data.Aggregates.CompaniesAgg.Mappings
{
    public partial class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasOne<Empresa>().WithOne().HasForeignKey<Empresa>(x => x.EmpresaId);
            builder.HasOne<GrupoEmpresa>().WithOne().HasForeignKey<Empresa>(x => x.GrupoEmpresaId);
        }
    }
}
