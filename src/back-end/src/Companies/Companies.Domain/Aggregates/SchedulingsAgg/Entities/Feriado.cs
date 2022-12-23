using Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities;
using Bravo.Companies.Domain.Aggregates.UsersAgg.Entities;
using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Schedulings.Enumerations;
using System.ComponentModel;

namespace Bravo.Companies.Domain.Aggregates.SchedulingsAgg.Entities
{
    [Steppable(1), EndpointsT4(EndpointTypes.HttpAll)]
    public class Feriado : ActivableEntity
    {
        [DisplayName("Nome do Feriado"), DisplayOnList(0), Title, Unique, Step(1)]
        public string Descricao { get; set; }
        
        [DisplayOnList(1), Step(1), Subtitle]
        public DateOnly Data { get; set; }
        
        [DisplayName("Tipo do Feriado"), DisplayOnList(2), ParameterType, Step(1)]
        public HolidayType Tipo { get; set; }
        
        public string UserId { get; set; }
        public int EmpresaId { get; set; }

        [IgnorePropertyT4]
        public User Responsavel { get; set; }
        
        [IgnorePropertyT4]
        public Empresa? Empresa { get; set; }
    }
}
