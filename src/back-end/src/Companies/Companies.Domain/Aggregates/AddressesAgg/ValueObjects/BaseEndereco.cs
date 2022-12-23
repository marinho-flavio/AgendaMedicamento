using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Bravo.Companies.Domain.Aggregates.AddressesAgg.ValueObjects
{
    public abstract class BaseEndereco: Entity
    {
        [RequiredT4]
        public string? CEP { get; set; }

        [RequiredT4]
        public string? Logradouro { get; set; }

        [RequiredT4, DisplayName("Bairro / Distrito")]
        public string? Bairro_Distrito { get; set; }

        [RequiredT4, DisplayName("Cidade / Localidade"), DisplayOnList(order: 3)]
        public string? Cidade_Localidade { get; set; }

        [RequiredT4]
        public string? UF { get; set; }
    }
}
