using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Validators {
    public class BaseProfessionalsAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseProfessionalsAggValidator() : base(){ }
            public BaseProfessionalsAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Bravo.Professionals.Application.DTO.Aggregates.ProfessionalsAgg.Validators 
{
	using Requests;
    public partial class ProfissionalConfiguracaoStep1Validator : BaseProfessionalsAggValidator<ProfissionalConfiguracaoDTO>
	{
        public ProfissionalConfiguracaoStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class FuncionarioStep1Validator : BaseProfessionalsAggValidator<FuncionarioDTO>
	{
        public FuncionarioStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Nome).NotEmpty();RuleFor(Q => Q.CNPJ).NotEmpty();RuleFor(Q => Q.DataNascimento).NotEmpty();RuleFor(Q => Q.Genero).NotEmpty();
        }
    }
    public partial class ProfissionalStep1Validator : BaseProfessionalsAggValidator<ProfissionalDTO>
	{
        public ProfissionalStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.Nome).NotEmpty();RuleFor(Q => Q.CNPJ).NotEmpty();RuleFor(Q => Q.DataNascimento).NotEmpty();RuleFor(Q => Q.Genero).NotEmpty();
        }
    }
    public partial class ProfissionalStep2Validator : BaseProfessionalsAggValidator<ProfissionalDTO>
	{
        public ProfissionalStep2Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.ProfissionalConfiguracao.Logo).NotEmpty();RuleFor(Q => Q.ProfissionalConfiguracao.SetorProprio).NotEmpty();
        }
    }
    public partial class ProfessionalsAggSettingsStep1Validator : BaseProfessionalsAggValidator<ProfessionalsAggSettingsDTO>
	{
        public ProfessionalsAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
        }
    }
    public partial class CboStep1Validator : BaseProfessionalsAggValidator<CboDTO>
	{
        public CboStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
}
