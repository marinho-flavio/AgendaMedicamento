using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Bravo.Professionals.Enumerations.Enum;
using System.ComponentModel.DataAnnotations;

namespace Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.ValueObjects
{
    public abstract class BaseFuncionario : Entity<string>
    {
        [Required]
        [DisplayOnList(0), Title, Step(1)]
        public string Nome { get; set; }

        [RegisterOrder(0), Step(1)]
        public string? NomeSocial { get; set; }

        [DisplayOnList(1), Step(1), RegisterOrder(1)]
        public string? CPF { get; set; }

        [DisplayOnList(2), Subtitle, Step(1)]
        [Required]
        public string CNPJ { get; set; }

        [RegisterOrder(2), Step(1)]
        public string UsuarioLogin { get; set; }
        [Required, RegisterOrder(3), Step(1)]
        public DateOnly DataNascimento { get; set; }
        [Required, RegisterOrder(4), Step(1)]
        public GeneroEnum Genero { get; set; }

        public string? Especialidade { get; set; }
        public string? SubEspecialidade { get; set; }
        public string? CorpoClinico { get; set; }
        public string? CodigoSus { get; set; }
        public string? CodigoCnes { get; set; }
        public int? CboId { get; set; }
        public string? Convenio { get; set; }
        public Escolaridade? Escolaridade { get; set; }
        public string? Funcao { get; set; }
        public string? Cargos { get; set; }
        [DisplayOnList(3)]
        public string? Telefone { get; set; }
        public int? EmpresaId { get; set; }
    }
}
