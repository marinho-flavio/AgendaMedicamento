using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities
{
    public class GrupoEmpresaConfiguracao : Entity
    {
        [RequiredT4, DisplayName("Logomarca"), RegisterOrder(0)]
        [Column(TypeName = "jsonb")]
        public ImageFileInfo? Logo { get; set; }

        [RequiredT4, DisplayName("Setor Próprio"), RegisterOrder(1)]
        public bool? SetorProprio { get; set; }
    }
}
