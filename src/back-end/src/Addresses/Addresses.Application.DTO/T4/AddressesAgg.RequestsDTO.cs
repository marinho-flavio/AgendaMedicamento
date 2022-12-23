

using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bravo.Core.Application.DTO.Attributes;

namespace Bravo.Addresses.Application.DTO.Aggregates.AddressesAgg.Requests 
{
	public partial class EnderecoDTO : EntityDTO
	{
	    public  string CEP { get; set; }
	    public  string Logradouro { get; set; }
	    public  string TipoLogradouro { get; set; }
	    public  string Bairro_Distrito { get; set; }
	    public  string Cidade_Localidade { get; set; }
	    public  string UF { get; set; }
	}
	public partial class AddressesAggSettingsDTO : EntityDTO
	{
	}
}
namespace Bravo.Addresses.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UserDTO : EntityDTO
	{
	}
}
