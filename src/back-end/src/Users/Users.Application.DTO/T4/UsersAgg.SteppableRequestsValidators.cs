using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace SES.Users.Application.DTO.Aggregates.UsersAgg.Validators {
    public class BaseUsersAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseUsersAggValidator() : base(){ }
            public BaseUsersAggValidator(HttpClient db) : base(db){ }
    }
}
namespace SES.Users.Application.DTO.Aggregates.UsersAgg.Validators 
{
	using Requests;
    public partial class UsersAggSettingsStep1Validator : BaseUsersAggValidator<UsersAggSettingsDTO>
	{
        public UsersAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
        }
    }
    public partial class UserStep1Validator : BaseUsersAggValidator<UserDTO>
	{
        public UserStep1Validator(HttpClient db)
                    : base(db)
        {
            
        }
    }
}
