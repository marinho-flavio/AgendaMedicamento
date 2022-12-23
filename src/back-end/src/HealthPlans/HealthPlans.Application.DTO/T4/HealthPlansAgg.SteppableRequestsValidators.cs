using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Validators {
    public class BaseHealthPlansAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseHealthPlansAggValidator() : base(){ }
            public BaseHealthPlansAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Validators 
{
	using Requests;
    public partial class ConvenioStep1Validator : BaseHealthPlansAggValidator<ConvenioDTO>
	{
        public ConvenioStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class ConvenioStep2Validator : BaseHealthPlansAggValidator<ConvenioDTO>
	{
        public ConvenioStep2Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class ConvenioStep3Validator : BaseHealthPlansAggValidator<ConvenioDTO>
	{
        public ConvenioStep3Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class ConvenioStep4Validator : BaseHealthPlansAggValidator<ConvenioDTO>
	{
        public ConvenioStep4Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class ConvenioStep5Validator : BaseHealthPlansAggValidator<ConvenioDTO>
	{
        public ConvenioStep5Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class HealthPlansAggSettingsStep1Validator : BaseHealthPlansAggValidator<HealthPlansAggSettingsDTO>
	{
        public HealthPlansAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
        }
    }
    public partial class PlanoConvenioStep1Validator : BaseHealthPlansAggValidator<PlanoConvenioDTO>
	{
        public PlanoConvenioStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class TipoPlanoStep1Validator : BaseHealthPlansAggValidator<TipoPlanoDTO>
	{
        public TipoPlanoStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class ConvenioHorasEspeciaisStep1Validator : BaseHealthPlansAggValidator<ConvenioHorasEspeciaisDTO>
	{
        public ConvenioHorasEspeciaisStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
}
