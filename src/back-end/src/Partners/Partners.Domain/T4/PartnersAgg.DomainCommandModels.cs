using Bravo.CrossCutting.Infra.Log.Contexts;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Bravo.Partners.Domain.Aggregates.PartnersAgg.CommandModels
{
    using Queries.Models; 
    using Bravo.Partners.Application.DTO.Aggregates.PartnersAgg.Requests; 
    public partial class CreateFornecedorCommand : BaseRequestableCommand<FornecedorQueryModel, FornecedorDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateFornecedorCommand(ILogRequestContext ctx, FornecedorDTO data, bool updateIfExists = true, FornecedorQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteFornecedorCommand : BaseDeletionCommand<FornecedorQueryModel>
    {
        public DeleteFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeFornecedorCommand : BaseDeletionCommand<FornecedorQueryModel>
    {
        public DeleteRangeFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeFornecedorCommand : BaseRequestableRangeCommand<FornecedorQueryModel, FornecedorDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeFornecedorCommand(ILogRequestContext ctx, Dictionary<FornecedorQueryModel, FornecedorDTO> query)
            : base(ctx, query) { }
        public UpdateRangeFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query, FornecedorDTO data)
            : base(ctx, new Dictionary<FornecedorQueryModel, FornecedorDTO> { { query, data } }) { }
    }
    
    public partial class UpdateFornecedorCommand : BaseRequestableCommand<FornecedorQueryModel, FornecedorDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query, FornecedorDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveFornecedorCommand : FornecedorSearchableCommand
    {
        public ActiveFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveFornecedorCommand : FornecedorSearchableCommand
    {
        public DeactiveFornecedorCommand(ILogRequestContext ctx, FornecedorQueryModel query)
            : base(ctx, query) { }
    }
    public class FornecedorSearchableCommand : BaseSearchableCommand<FornecedorQueryModel> {
        public FornecedorSearchableCommand(ILogRequestContext ctx, FornecedorQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreatePublicitarioCommand : BaseRequestableCommand<PublicitarioQueryModel, PublicitarioDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreatePublicitarioCommand(ILogRequestContext ctx, PublicitarioDTO data, bool updateIfExists = true, PublicitarioQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeletePublicitarioCommand : BaseDeletionCommand<PublicitarioQueryModel>
    {
        public DeletePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangePublicitarioCommand : BaseDeletionCommand<PublicitarioQueryModel>
    {
        public DeleteRangePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangePublicitarioCommand : BaseRequestableRangeCommand<PublicitarioQueryModel, PublicitarioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangePublicitarioCommand(ILogRequestContext ctx, Dictionary<PublicitarioQueryModel, PublicitarioDTO> query)
            : base(ctx, query) { }
        public UpdateRangePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query, PublicitarioDTO data)
            : base(ctx, new Dictionary<PublicitarioQueryModel, PublicitarioDTO> { { query, data } }) { }
    }
    
    public partial class UpdatePublicitarioCommand : BaseRequestableCommand<PublicitarioQueryModel, PublicitarioDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdatePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query, PublicitarioDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActivePublicitarioCommand : PublicitarioSearchableCommand
    {
        public ActivePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactivePublicitarioCommand : PublicitarioSearchableCommand
    {
        public DeactivePublicitarioCommand(ILogRequestContext ctx, PublicitarioQueryModel query)
            : base(ctx, query) { }
    }
    public class PublicitarioSearchableCommand : BaseSearchableCommand<PublicitarioQueryModel> {
        public PublicitarioSearchableCommand(ILogRequestContext ctx, PublicitarioQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreatePartnersAggSettingsCommand : BaseRequestableCommand<PartnersAggSettingsQueryModel, PartnersAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreatePartnersAggSettingsCommand(ILogRequestContext ctx, PartnersAggSettingsDTO data, bool updateIfExists = true, PartnersAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeletePartnersAggSettingsCommand : BaseDeletionCommand<PartnersAggSettingsQueryModel>
    {
        public DeletePartnersAggSettingsCommand(ILogRequestContext ctx, PartnersAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangePartnersAggSettingsCommand : BaseDeletionCommand<PartnersAggSettingsQueryModel>
    {
        public DeleteRangePartnersAggSettingsCommand(ILogRequestContext ctx, PartnersAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangePartnersAggSettingsCommand : BaseRequestableRangeCommand<PartnersAggSettingsQueryModel, PartnersAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangePartnersAggSettingsCommand(ILogRequestContext ctx, Dictionary<PartnersAggSettingsQueryModel, PartnersAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangePartnersAggSettingsCommand(ILogRequestContext ctx, PartnersAggSettingsQueryModel query, PartnersAggSettingsDTO data)
            : base(ctx, new Dictionary<PartnersAggSettingsQueryModel, PartnersAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdatePartnersAggSettingsCommand : BaseRequestableCommand<PartnersAggSettingsQueryModel, PartnersAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdatePartnersAggSettingsCommand(ILogRequestContext ctx, PartnersAggSettingsQueryModel query, PartnersAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActivePartnersAggSettingsCommand : PartnersAggSettingsSearchableCommand
    {
        public ActivePartnersAggSettingsCommand(ILogRequestContext ctx, PartnersAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactivePartnersAggSettingsCommand : PartnersAggSettingsSearchableCommand
    {
        public DeactivePartnersAggSettingsCommand(ILogRequestContext ctx, PartnersAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class PartnersAggSettingsSearchableCommand : BaseSearchableCommand<PartnersAggSettingsQueryModel> {
        public PartnersAggSettingsSearchableCommand(ILogRequestContext ctx, PartnersAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

}
