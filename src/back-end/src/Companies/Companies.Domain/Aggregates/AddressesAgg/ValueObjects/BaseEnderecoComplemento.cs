using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Bravo.Companies.Domain.Aggregates.AddressesAgg.ValueObjects
{
    public abstract class BaseEnderecoComplemento<T> : Entity
        where T : BaseEndereco
    {
        public abstract int? EnderecoId { get; set; }

        [RequiredT4, DisplayName("Número")]
        public abstract string? Numero { get; set; }

        [RequiredT4, DisplayName("Referência")]
        public abstract string? Referencia { get; set; }

        [RequiredT4, DisplayName("Tipo Endereço")]
        public abstract string? TipoEndereco { get; set; }

        [RequiredT4]
        public abstract string? Complemento { get; set; }

        public abstract T Endereco { get; set; }
    }
}
