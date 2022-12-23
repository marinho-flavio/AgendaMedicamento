using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;

namespace Bravo.Companies.Domain.Aggregates.HealthPlansAgg.Entities
{
    [Steppable(5), MigrationOrder(4), EndpointsT4(EndpointTypes.HttpAll)]
    public class Convenio : Entity
    {
        [Step(1), DisplayName("Nome do convênio")]
        public string Nome { get; set; }

        [Step(1)]
        [Column(TypeName = "jsonb")]
        public ImageFileInfo? Logomarca { get; set; }

        [Step(1), DisplayName("Matrícula")]
        public string Matricula { get; set; }

        [Step(1), DisplayName("Código")]
        public string Codigo { get; set; }

        [Step(1), DisplayName("Registro ANS")]
        public string RegistroANS { get; set; }

        [Step(1), DisplayName("Código de referência")]
        public string CodigoReferencia { get; set; }

        [Step(1), DisplayName("Padronizar quantidade de dígitos")]
        public bool PadronizarQuantidadeDigitos { get; set; }

        [Step(1), DisplayName("Quantidade de dígitos")]
        public int? QuantidadeDigitos { get; set; }
    }
}
