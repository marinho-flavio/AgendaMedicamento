using Bravo.Companies.Domain.Aggregates.CompaniesAgg.ValueObjects;
using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities
{
    [Steppable(4), EndpointsT4(EndpointTypes.HttpAll)]
    public class GrupoEmpresa : BaseInstituicao
    {
        public GrupoEmpresa()
        {
            this.InstituicaoType = Enumerations.InstituicaoType.GrupoEmpresa;
        }
        [OneToOne]
        [ValidateComplexType]
        [Step(2), RequiredT4, DisplayOnList]
        public virtual GrupoEmpresaEndereco GrupoEmpresaEndereco { get; set; }

        [OneToOne]
        [Step(3), RequiredT4]
        [ValidateComplexType, DisplayOnList]
        public virtual GrupoEmpresaContacts Contacts { get; set; }

        [OneToOne]
        [ValidateComplexType]
        [Step(4), RequiredT4, DisplayOnList]
        public virtual GrupoEmpresaConfiguracao GrupoEmpresaConfiguracao { get; set; }
    }
}