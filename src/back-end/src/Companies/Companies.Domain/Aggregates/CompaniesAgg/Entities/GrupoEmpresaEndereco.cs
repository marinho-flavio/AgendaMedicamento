using Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities;
using Bravo.Companies.Domain.Aggregates.AddressesAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities
{
    public class GrupoEmpresaEndereco : BaseEnderecoComplemento<Endereco>
    {
        public int GrupoEmpresaId { get; set; }

        [MustImplementT4]
        public override int? EnderecoId { get; set; }

        [MustImplementT4, RequiredT4, DisplayName("Número")]
        public override string? Numero { get; set; }

        [MustImplementT4, RequiredT4, DisplayName("Referência")]
        public override string? Referencia { get; set; }

        [MustImplementT4, RequiredT4, DisplayName("Tipo Endereço")]
        public override string? TipoEndereco { get; set; }

        [MustImplementT4, RequiredT4]
        public override string? Complemento { get; set; }

        [IgnorePropertyT4OnRequest]
        public override Endereco Endereco { get; set; }
    }
}
