using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using Bravo.Core.Application.DTO.Attributes;
namespace Bravo.Partners.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	using Requests;
}
namespace Bravo.Partners.Application.DTO.Aggregates.PartnersAgg.Requests 
{
	using Requests;
    public partial class FornecedorListiningDTO : EntityDTO
	{
        [DisplayOnList(1)] public  string Nome { get; set; }[DisplayOnList(2)] public  string Cpf { get; set; }
    }
    public partial class PublicitarioListiningDTO : EntityDTO
	{
        [DisplayOnList(2)] public  string Cpf { get; set; }[DisplayOnList(1)] public  string Nome { get; set; }
    }
    public partial class PartnersAggSettingsListiningDTO : EntityDTO
	{
        
    }
}
namespace Bravo.Partners.Application.DTO.Aggregates.UsersAgg.Requests 
{
	using Requests;
}
