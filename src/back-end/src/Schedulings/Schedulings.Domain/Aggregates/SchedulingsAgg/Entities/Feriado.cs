using SES.Core.Application.DTO.Attributes;
using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Core.Domain.Attributes.T4;
using SES.Schedulings.Domain.Aggregates.CompaniesAgg.Entities;
using SES.Schedulings.Domain.Aggregates.UsersAgg.Entities;
using SES.Schedulings.Enumerations;
using System.ComponentModel;

namespace SES.Schedulings.Domain.Aggregates.SchedulingsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class Feriado : ActivableEntity
    {
        [DisplayName("Nome do Feriado"), Unique, Title, Step(1)]
        public string Descricao { get; set; }
        
        [DisplayOnList(0), Step(1), Subtitle]
        public DateOnly Data { get; set; }
        
        [DisplayName("Tipo do Feriado"), DisplayOnList(0), Step(1)]
        public HolidayType Tipo { get; set; }

        public string UserId { get; set; }
        public int EmpresaId { get; set; }

        [IgnorePropertyT4]
        public User Responsavel { get; set; }
        
        [IgnorePropertyT4]
        public Empresa? Empresa { get; set; }
    }
}
