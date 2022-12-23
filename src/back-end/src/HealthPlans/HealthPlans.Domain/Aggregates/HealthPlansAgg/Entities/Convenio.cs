using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Entities
{
    [Steppable(5), EndpointsT4(EndpointTypes.HttpAll)]
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

        //Verificar campos "horas especiais cadastradas

        [Step(1)]
        public List<ConvenioHorasEspeciais> HorasEspeciais { get; set; }

        [Step(1)]
        public List<PlanoConvenio> PlanoConvenio { get; set; }
    }
}
