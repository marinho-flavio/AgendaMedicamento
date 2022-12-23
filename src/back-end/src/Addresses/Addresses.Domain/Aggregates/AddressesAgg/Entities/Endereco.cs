using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;

namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.Entities
{
    [EndpointsT4(0, EndpointTypes.HttpAll)]
    public class Endereco : Entity
    {
        [RequiredT4]
        public string? CEP { get; set; }
        [RequiredT4]
        public string? Logradouro { get; set; }
        [RequiredT4]
        public string? TipoLogradouro { get; set; }
        [RequiredT4]
        public string? Bairro_Distrito { get; set; }
        [RequiredT4]
        public string? Cidade_Localidade { get; set; }
        [RequiredT4]
        public string? UF { get; set; }
    }
}
