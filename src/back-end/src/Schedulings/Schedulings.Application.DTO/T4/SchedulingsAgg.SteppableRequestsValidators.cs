using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Validators {
    public class BaseSchedulingsAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseSchedulingsAggValidator() : base(){ }
            public BaseSchedulingsAggValidator(HttpClient db) : base(db){ }
    }
}
namespace SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Validators 
{
	using Requests;
    public partial class SchedulingsAggSettingsStep1Validator : BaseSchedulingsAggValidator<SchedulingsAggSettingsDTO>
	{
        public SchedulingsAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
        }
    }
    public partial class FeriadoStep1Validator : BaseSchedulingsAggValidator<FeriadoDTO>
	{
        public FeriadoStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(x=>x).MustAsync((x, y) => BeUnique<FeriadoDTO>(x.ExternalId, "Descricao", x.Descricao, CancellationToken.None)).WithMessage("'Nome do Feriado' existente.").WithName("Descricao");RuleFor(Q => Q.Descricao);
        }
    }
}
