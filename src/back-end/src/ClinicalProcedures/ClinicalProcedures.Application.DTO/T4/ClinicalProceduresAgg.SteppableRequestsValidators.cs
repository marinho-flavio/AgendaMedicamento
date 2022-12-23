using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Bravo.ClinicalProcedures.Application.DTO.Aggregates.ClinicalProceduresAgg.Validators {
    public class BaseClinicalProceduresAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseClinicalProceduresAggValidator() : base(){ }
            public BaseClinicalProceduresAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Bravo.ClinicalProcedures.Application.DTO.Aggregates.ClinicalProceduresAgg.Validators 
{
	using Requests;
    public partial class ClinicalProceduresAggSettingsStep1Validator : BaseClinicalProceduresAggValidator<ClinicalProceduresAggSettingsDTO>
	{
        public ClinicalProceduresAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
        }
    }
}
