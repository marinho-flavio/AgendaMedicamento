using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Bravo.Companies.Adm.Panel.Server.Aggregates.CompaniesAgg.Validators {
    public class BaseCompaniesAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseCompaniesAggValidator() : base(){ }
            public BaseCompaniesAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Bravo.Companies.Application.DTO.Aggregates.CompaniesAgg.Validators 
{
	using Requests;
    public partial class EmpresaStep1Validator : BaseCompaniesAggValidator<EmpresaDTO>
	{
        public EmpresaStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(x=>x).MustAsync((x, y) => BeUnique<EmpresaDTO>(x.ExternalId, "CNPJ", x.CNPJ, CancellationToken.None)).WithMessage("CNPJ existente.").WithName("CNPJ");RuleFor(Q => Q.CNPJ).NotEmpty();RuleFor(x=>x).MustAsync((x, y) => BeUnique<EmpresaDTO>(x.ExternalId, "RazaoSocial", x.RazaoSocial, CancellationToken.None)).WithMessage("'Razão Social' existente.").WithName("RazaoSocial");RuleFor(Q => Q.RazaoSocial).NotEmpty();RuleFor(Q => Q.NomeFantasia).NotEmpty();
        }
    }
    public partial class EmpresaStep2Validator : BaseCompaniesAggValidator<EmpresaDTO>
	{
        public EmpresaStep2Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Endereco).NotNull();RuleFor(Q => Q.Endereco.Complemento).NotEmpty();RuleFor(Q => Q.Endereco.EmpresaId);RuleFor(Q => Q.Endereco.Endereco.Bairro_Distrito).NotEmpty();RuleFor(Q => Q.Endereco.Endereco.CEP).NotEmpty();RuleFor(Q => Q.Endereco.Endereco.Cidade_Localidade).NotEmpty();RuleFor(Q => Q.Endereco.Endereco.Logradouro).NotEmpty();RuleFor(Q => Q.Endereco.Endereco.UF).NotEmpty();RuleFor(Q => Q.Endereco.EnderecoId);RuleFor(Q => Q.Endereco.Numero).NotEmpty();RuleFor(Q => Q.Endereco.Referencia).NotEmpty();RuleFor(Q => Q.Endereco.TipoEndereco).NotEmpty();
        }
    }
    public partial class EmpresaStep3Validator : BaseCompaniesAggValidator<EmpresaDTO>
	{
        public EmpresaStep3Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Contacts).NotNull();RuleFor(Q => Q.Contacts.Email).NotEmpty();RuleFor(Q => Q.Contacts.Telefone).NotEmpty();RuleFor(Q => Q.Contacts.TipoTelefone).NotEmpty();RuleFor(Q => Q.Contacts.WebSite);
        }
    }
    public partial class EmpresaStep4Validator : BaseCompaniesAggValidator<EmpresaDTO>
	{
        public EmpresaStep4Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Configuracao).NotNull();RuleFor(Q => Q.Configuracao.Logo).NotEmpty();RuleFor(Q => Q.Configuracao.SetorProprio).NotEmpty();
        }
    }
    public partial class CompaniesAggSettingsStep1Validator : BaseCompaniesAggValidator<CompaniesAggSettingsDTO>
	{
        public CompaniesAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
        }
    }
    public partial class GrupoEmpresaStep1Validator : BaseCompaniesAggValidator<GrupoEmpresaDTO>
	{
        public GrupoEmpresaStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(x=>x).MustAsync((x, y) => BeUnique<GrupoEmpresaDTO>(x.ExternalId, "CNPJ", x.CNPJ, CancellationToken.None)).WithMessage("CNPJ existente.").WithName("CNPJ");RuleFor(Q => Q.CNPJ).NotEmpty();RuleFor(x=>x).MustAsync((x, y) => BeUnique<GrupoEmpresaDTO>(x.ExternalId, "RazaoSocial", x.RazaoSocial, CancellationToken.None)).WithMessage("'Razão Social' existente.").WithName("RazaoSocial");RuleFor(Q => Q.RazaoSocial).NotEmpty();RuleFor(Q => Q.NomeFantasia).NotEmpty();
        }
    }
    public partial class GrupoEmpresaStep2Validator : BaseCompaniesAggValidator<GrupoEmpresaDTO>
	{
        public GrupoEmpresaStep2Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.GrupoEmpresaEndereco).NotNull();RuleFor(Q => Q.GrupoEmpresaEndereco.Complemento).NotEmpty();RuleFor(Q => Q.GrupoEmpresaEndereco.Endereco.Bairro_Distrito).NotEmpty();RuleFor(Q => Q.GrupoEmpresaEndereco.Endereco.CEP).NotEmpty();RuleFor(Q => Q.GrupoEmpresaEndereco.Endereco.Cidade_Localidade).NotEmpty();RuleFor(Q => Q.GrupoEmpresaEndereco.Endereco.Logradouro).NotEmpty();RuleFor(Q => Q.GrupoEmpresaEndereco.Endereco.UF).NotEmpty();RuleFor(Q => Q.GrupoEmpresaEndereco.EnderecoId);RuleFor(Q => Q.GrupoEmpresaEndereco.GrupoEmpresaId);RuleFor(Q => Q.GrupoEmpresaEndereco.Numero).NotEmpty();RuleFor(Q => Q.GrupoEmpresaEndereco.Referencia).NotEmpty();RuleFor(Q => Q.GrupoEmpresaEndereco.TipoEndereco).NotEmpty();
        }
    }
    public partial class GrupoEmpresaStep3Validator : BaseCompaniesAggValidator<GrupoEmpresaDTO>
	{
        public GrupoEmpresaStep3Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Contacts).NotNull();RuleFor(Q => Q.Contacts.Email).NotEmpty();RuleFor(Q => Q.Contacts.Telefone).NotEmpty();RuleFor(Q => Q.Contacts.TipoTelefone).NotEmpty();RuleFor(Q => Q.Contacts.WebSite);
        }
    }
    public partial class GrupoEmpresaStep4Validator : BaseCompaniesAggValidator<GrupoEmpresaDTO>
	{
        public GrupoEmpresaStep4Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.GrupoEmpresaConfiguracao).NotNull();RuleFor(Q => Q.GrupoEmpresaConfiguracao.Logo).NotEmpty();RuleFor(Q => Q.GrupoEmpresaConfiguracao.SetorProprio).NotEmpty();
        }
    }
}
