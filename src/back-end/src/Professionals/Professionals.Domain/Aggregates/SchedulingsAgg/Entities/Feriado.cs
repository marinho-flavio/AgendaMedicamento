using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities;
using Bravo.Schedulings.Enumerations;
using System.ComponentModel;

namespace Bravo.Professionals.Domain.Aggregates.SchedulingsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Feriado : ActivableEntity
    {
        [DisplayName("Nome do Feriado"), DisplayOnList(0), Unique, Title]
        public string Descricao { get; set; }
        
        [DisplayOnList(0)]
        public DateOnly Data { get; set; }
        
        [DisplayName("Tipo do Feriado"), DisplayOnList(0), Subtitle]
        public HolidayType Tipo { get; set; }

        public string UserId { get; set; }
        public int EmpresaId { get; set; }

        [IgnorePropertyT4]
        public User Responsavel { get; set; }
        
        [IgnorePropertyT4]
        public Empresa? Empresa { get; set; }
    }
}
