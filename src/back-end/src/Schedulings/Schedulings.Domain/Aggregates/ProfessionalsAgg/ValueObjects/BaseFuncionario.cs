using SES.Core.Application.DTO.Attributes;
using SES.Core.Domain.Aggregates.CommonAgg.Entities;
using SES.Schedulings.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace SES.Schedulings.Domain.Aggregates.ProfessionalsAgg.ValueObjects
{
    public abstract class BaseFuncionario : Entity<string>
    {
        [Required]
        [DisplayOnList(0)]
        public string Nome { get; set; }

        public string? NomeSocial { get; set; }
        [DisplayOnList(1)]
        public string? CPF { get; set; }
        [DisplayOnList(2)]
        [Required]
        public string CNPJ { get; set; }
        public string? Especialidade { get; set; }
        public string? SubEspecialidade { get; set; }
        public string? CorpoClinico { get; set; }
        public string? CodigoSus { get; set; }
        public string? CodigoCnes { get; set; }
        public int? CboId { get; set; }
        public string? Convenio { get; set; }
        public EscolaridadeEnum? Escolaridade { get; set; }
        public string? Funcao { get; set; }
        public string? Cargos { get; set; }
        [DisplayOnList(3)]
        public string? Telefone { get; set; }
        public int? EmpresaId { get; set; }
        public string UsuarioLogin { get; set; }
        [Required]
        public DateOnly DataNascimento { get; set; }
        [Required]
        public GeneroEnum Genero { get; set; }
    }
}
