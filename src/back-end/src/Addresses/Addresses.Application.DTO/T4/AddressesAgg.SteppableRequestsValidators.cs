using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Bravo.Addresses.Application.DTO.Aggregates.AddressesAgg.Validators {
    public class BaseAddressesAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseAddressesAggValidator() : base(){ }
            public BaseAddressesAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Bravo.Addresses.Application.DTO.Aggregates.AddressesAgg.Validators 
{
	using Requests;
    public partial class EnderecoStep1Validator : BaseAddressesAggValidator<EnderecoDTO>
	{
        public EnderecoStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.CEP).NotEmpty();RuleFor(Q => Q.Logradouro).NotEmpty();RuleFor(Q => Q.TipoLogradouro).NotEmpty();RuleFor(Q => Q.Bairro_Distrito).NotEmpty();RuleFor(Q => Q.Cidade_Localidade).NotEmpty();RuleFor(Q => Q.UF).NotEmpty();
        }
    }
}
