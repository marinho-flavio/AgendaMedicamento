using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Bravo.Partners.Application.DTO.Aggregates.PartnersAgg.Validators {
    public class BasePartnersAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BasePartnersAggValidator() : base(){ }
            public BasePartnersAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Bravo.Partners.Application.DTO.Aggregates.PartnersAgg.Validators 
{
	using Requests;
    public partial class FornecedorStep1Validator : BasePartnersAggValidator<FornecedorDTO>
	{
        public FornecedorStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class PublicitarioStep1Validator : BasePartnersAggValidator<PublicitarioDTO>
	{
        public PublicitarioStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class PartnersAggSettingsStep1Validator : BasePartnersAggValidator<PartnersAggSettingsDTO>
	{
        public PartnersAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
        }
    }
}
