using Bravo.CrossCutting.Infra.Log.Contexts;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Bravo.Patients.Domain.Aggregates.PatientsAgg.CommandModels
{
    using Queries.Models; 
    using Bravo.Patients.Application.DTO.Aggregates.PatientsAgg.Requests; 
    public partial class CreatePacienteCommand : BaseRequestableCommand<PacienteQueryModel, PacienteDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreatePacienteCommand(ILogRequestContext ctx, PacienteDTO data, bool updateIfExists = true, PacienteQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeletePacienteCommand : BaseDeletionCommand<PacienteQueryModel>
    {
        public DeletePacienteCommand(ILogRequestContext ctx, PacienteQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangePacienteCommand : BaseDeletionCommand<PacienteQueryModel>
    {
        public DeleteRangePacienteCommand(ILogRequestContext ctx, PacienteQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangePacienteCommand : BaseRequestableRangeCommand<PacienteQueryModel, PacienteDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangePacienteCommand(ILogRequestContext ctx, Dictionary<PacienteQueryModel, PacienteDTO> query)
            : base(ctx, query) { }
        public UpdateRangePacienteCommand(ILogRequestContext ctx, PacienteQueryModel query, PacienteDTO data)
            : base(ctx, new Dictionary<PacienteQueryModel, PacienteDTO> { { query, data } }) { }
    }
    
    public partial class UpdatePacienteCommand : BaseRequestableCommand<PacienteQueryModel, PacienteDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdatePacienteCommand(ILogRequestContext ctx, PacienteQueryModel query, PacienteDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActivePacienteCommand : PacienteSearchableCommand
    {
        public ActivePacienteCommand(ILogRequestContext ctx, PacienteQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactivePacienteCommand : PacienteSearchableCommand
    {
        public DeactivePacienteCommand(ILogRequestContext ctx, PacienteQueryModel query)
            : base(ctx, query) { }
    }
    public class PacienteSearchableCommand : BaseSearchableCommand<PacienteQueryModel> {
        public PacienteSearchableCommand(ILogRequestContext ctx, PacienteQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreatePatientsAggSettingsCommand : BaseRequestableCommand<PatientsAggSettingsQueryModel, PatientsAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreatePatientsAggSettingsCommand(ILogRequestContext ctx, PatientsAggSettingsDTO data, bool updateIfExists = true, PatientsAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeletePatientsAggSettingsCommand : BaseDeletionCommand<PatientsAggSettingsQueryModel>
    {
        public DeletePatientsAggSettingsCommand(ILogRequestContext ctx, PatientsAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangePatientsAggSettingsCommand : BaseDeletionCommand<PatientsAggSettingsQueryModel>
    {
        public DeleteRangePatientsAggSettingsCommand(ILogRequestContext ctx, PatientsAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangePatientsAggSettingsCommand : BaseRequestableRangeCommand<PatientsAggSettingsQueryModel, PatientsAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangePatientsAggSettingsCommand(ILogRequestContext ctx, Dictionary<PatientsAggSettingsQueryModel, PatientsAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangePatientsAggSettingsCommand(ILogRequestContext ctx, PatientsAggSettingsQueryModel query, PatientsAggSettingsDTO data)
            : base(ctx, new Dictionary<PatientsAggSettingsQueryModel, PatientsAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdatePatientsAggSettingsCommand : BaseRequestableCommand<PatientsAggSettingsQueryModel, PatientsAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdatePatientsAggSettingsCommand(ILogRequestContext ctx, PatientsAggSettingsQueryModel query, PatientsAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActivePatientsAggSettingsCommand : PatientsAggSettingsSearchableCommand
    {
        public ActivePatientsAggSettingsCommand(ILogRequestContext ctx, PatientsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactivePatientsAggSettingsCommand : PatientsAggSettingsSearchableCommand
    {
        public DeactivePatientsAggSettingsCommand(ILogRequestContext ctx, PatientsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class PatientsAggSettingsSearchableCommand : BaseSearchableCommand<PatientsAggSettingsQueryModel> {
        public PatientsAggSettingsSearchableCommand(ILogRequestContext ctx, PatientsAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

}
