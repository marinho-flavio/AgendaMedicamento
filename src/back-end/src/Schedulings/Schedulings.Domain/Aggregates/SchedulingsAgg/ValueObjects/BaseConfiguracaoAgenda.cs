using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Entities;

namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.ValueObjects
{
    public class BaseConfiguracaoAgenda : ActivableEntity
    {
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int TempoAtendimento { get; set; }

        public string Tipo { get; set; }

        public string AgendaStatus { get; set; }

        public int QuantidadeAgendamentos { get; set; }

        public int QuantidadeEncaixes { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
