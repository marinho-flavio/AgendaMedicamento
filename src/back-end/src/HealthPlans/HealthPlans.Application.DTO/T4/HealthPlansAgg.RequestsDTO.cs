

using Bravo.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Bravo.Core.Application.DTO.Attributes;

namespace Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests 
{
	public partial class ConvenioDTO : EntityDTO
	{
	    [DisplayName("Nome do convênio")] public  string Nome { get; set; }
	    public Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO Logomarca { get; set; } = new Bravo.Companies.Application.DTO.Aggregates.CommonAgg.ValueObjects.ImageFileInfoDTO();
	    [DisplayName("Matrícula")] public  string Matricula { get; set; }
	    [DisplayName("Código")] public  string Codigo { get; set; }
	    [DisplayName("Registro ANS")] public  string RegistroANS { get; set; }
	    [DisplayName("Código de referência")] public  string CodigoReferencia { get; set; }
	    [DisplayName("Padronizar quantidade de dígitos")] public  bool PadronizarQuantidadeDigitos { get; set; }
	    [DisplayName("Quantidade de dígitos")] public  int? QuantidadeDigitos { get; set; }
	    public Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.ConvenioHorasEspeciaisDTO[] HorasEspeciais { get; set; } = new Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.ConvenioHorasEspeciaisDTO[0];
	    public Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.PlanoConvenioDTO[] PlanoConvenio { get; set; } = new Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.PlanoConvenioDTO[0];
	}
	public partial class HealthPlansAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  string UserId { get; set; }
	}
	public partial class PlanoConvenioDTO : EntityDTO
	{
	    public  int ConvenioId { get; set; }
	    public Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.ConvenioDTO Convenio { get; set; } = new Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.ConvenioDTO();
	    public  Bravo.HealthPlans.Enumerations.ClassificacaoServicoHospitalarEnum ClassificacaoServicoHospitalar { get; set; }
	    public  int TipoPlanoId { get; set; }
	    public Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.TipoPlanoDTO TipoPlano { get; set; } = new Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.TipoPlanoDTO();
	    public  decimal MultiplicadorHospitalar { get; set; }
	    public  decimal MultiplicadorProfissional { get; set; }
	    public  decimal MultiplicadorExame { get; set; }
	    public  decimal ProcedimentoPercentualPrincipal { get; set; }
	    public  decimal ProcedimentoPrincipalDiferente { get; set; }
	    public  decimal ProcedimentoPrincipalMesma { get; set; }
	    public  decimal ProcedimentoHospitalarPrincipal { get; set; }
	    public  decimal ProcedimentoHospitalarDiferente { get; set; }
	    public  decimal ProcedimentoHospitalarMesma { get; set; }
	    public  string DescricaoMedicamento { get; set; }
	    public  string MoedaMedicamento { get; set; }
	    public  Bravo.HealthPlans.Enumerations.TipoTabelaEnum TipoTabelaMedicamento { get; set; }
	}
	public partial class TipoPlanoDTO : EntityDTO
	{
	    public  string Nome { get; set; }
	}
	public partial class ConvenioHorasEspeciaisDTO : EntityDTO
	{
	    public  string Dia { get; set; }
	    [DisplayName("Hora inicial")] public  string HoraInicial { get; set; }
	    [DisplayName("Hora final")] public  string HoraFinal { get; set; }
	    public  int ConvenioId { get; set; }
	    public Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.ConvenioDTO Convenio { get; set; } = new Bravo.HealthPlans.Application.DTO.Aggregates.HealthPlansAgg.Requests.ConvenioDTO();
	}
}
namespace Bravo.HealthPlans.Application.DTO.Aggregates.UsersAgg.Requests 
{
	public partial class UserDTO : EntityDTO
	{
	}
}
