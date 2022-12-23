namespace SES.Users.Domain.Aggregates.UsersAgg.ValueObjects
{
    public class UsuarioAcesso
    {
        public bool Inserir { get; set; }
        public bool Alterar { get; set; }
        public bool Consultar { get; set; }
        public bool Excluir { get; set; }
    }
}
