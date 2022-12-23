using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Bravo.Patients.Application.DTO.Aggregates.PatientsAgg.Validators {
    public class BasePatientsAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BasePatientsAggValidator() : base(){ }
            public BasePatientsAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Bravo.Patients.Application.DTO.Aggregates.PatientsAgg.Validators 
{
	using Requests;
    public partial class PacienteStep1Validator : BasePatientsAggValidator<PacienteDTO>
	{
        public PacienteStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
    public partial class PatientsAggSettingsStep1Validator : BasePatientsAggValidator<PatientsAggSettingsDTO>
	{
        public PatientsAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
        }
    }
}
