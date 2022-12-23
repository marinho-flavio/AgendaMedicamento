using Bravo.Companies.Domain.Aggregates.CompaniesAgg.ValueObjects;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities
{
    [Steppable(4), EndpointsT4(EndpointTypes.HttpAll)]
    public class Empresa : BaseInstituicao
    {
        public Empresa()
        {
            this.InstituicaoType = IsFilial ? Enumerations.InstituicaoType.Empresa : Enumerations.InstituicaoType.Filial;
        }

        public int? EmpresaId { get; set; }

        public int? GrupoEmpresaId { get; set; }

        public bool IsFilial { get; set; }

        [Step(1), DisplayName("Cadastro Nacional de Estabelecimento de Saúde")]
        public string? CNES { get; set; }

        [Step(1), DisplayName("Registro ANS")]
        public string? ANS { get; set; }

        [Step(1), DisplayName("Código SUS")]
        public string? CodigoSUS { get; set; }

        [Step(1), DisplayName("A empresa é terceirizada?")]
        public bool Terceirizado { get; set; }

        [OneToOne]
        [ValidateComplexType]
        [Step(2), RequiredT4]
        public virtual EmpresaEndereco Endereco { get; set; }

        [OneToOne]
        [Step(3), RequiredT4]
        [ValidateComplexType]
        public virtual EmpresaContacts Contacts { get; set; }

        [OneToOne]
        [ValidateComplexType]
        [Step(4), RequiredT4]
        public virtual EmpresaConfiguracao Configuracao { get; set; }
    }
}