using Bravo.Companies.Enumerations;
using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.ValueObjects
{
    public class BaseInstituicao : ActivableEntity
    {
        [Step(1)]
        [Required, Unique, DisplayOnList(order: 2), Subtitle]
        public string CNPJ { get; set; }

        [Required]
        [Step(1), Unique, DisplayOnList(order: 1), Title]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [Required]
        [Step(1), DisplayName("Nome Fantasia"), DisplayOnList(order: 0), RegisterOrder(0)]
        public string NomeFantasia { get; set; }

        public int CurrentStep { get; set; }
        
        [RegisterOrder(1), ParameterType]
        public InstituicaoType InstituicaoType { get; set; }

    }
}
