using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using SES.Core.Application.DTO.Attributes;
namespace SES.Schedulings.Application.DTO.Aggregates.CompaniesAgg.Requests 
{
	using Requests;
    public partial class EmpresaListiningDTO : EntityDTO
	{
        
    }
}
namespace SES.Schedulings.Application.DTO.Aggregates.SchedulingsAgg.Requests 
{
	using Requests;
    public partial class SchedulingsAggSettingsListiningDTO : EntityDTO
	{
        
    }
    public partial class FeriadoListiningDTO : EntityDTO
	{
        [DisplayOnList(0),Subtitle] public  System.DateOnly Data { get; set; }[DisplayOnList(0),DisplayName("Tipo do Feriado")] public  SES.Schedulings.Enumerations.HolidayType Tipo { get; set; }
    }
}
namespace SES.Schedulings.Application.DTO.Aggregates.ProfessionalsAgg.Requests 
{
	using Requests;
    public partial class ProfissionalListiningDTO : EntityDTO
	{
        
    }
}
namespace SES.Schedulings.Application.DTO.Aggregates.UsersAgg.Requests 
{
	using Requests;
    public partial class UserListiningDTO : EntityDTO
	{
        
    }
}
namespace SES.Schedulings.Application.DTO.Aggregates.PartnersAgg.Requests 
{
	using Requests;
    public partial class FornecedorListiningDTO : EntityDTO
	{
        [DisplayOnList(1)] public  string Nome { get; set; }
    }
    public partial class PublicitarioListiningDTO : EntityDTO
	{
        [DisplayOnList(1)] public  string Nome { get; set; }
    }
}
