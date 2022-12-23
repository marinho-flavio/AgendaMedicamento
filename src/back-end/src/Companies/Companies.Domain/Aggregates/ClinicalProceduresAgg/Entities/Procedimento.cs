using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;

namespace Bravo.Companies.Domain.Aggregates.ClinicalProceduresAgg.Entities
{
    public class Procedimento : Entity
    {
        public int CodigoProcedimento { get; set; }
        public int Descricao { get; set; }
        public string? Orientacao { get; set; }
    }
}