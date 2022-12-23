using Bravo.CrossCutting.Infra.Log.Contexts;
using Bravo.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Bravo.Addresses.Domain.Aggregates.AddressesAgg.CommandModels
{
    using Queries.Models; 
    using Bravo.Addresses.Application.DTO.Aggregates.AddressesAgg.Requests; 
    public partial class CreateEnderecoCommand : BaseRequestableCommand<EnderecoQueryModel, EnderecoDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateEnderecoCommand(ILogRequestContext ctx, EnderecoDTO data, bool updateIfExists = true, EnderecoQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteEnderecoCommand : BaseDeletionCommand<EnderecoQueryModel>
    {
        public DeleteEnderecoCommand(ILogRequestContext ctx, EnderecoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeEnderecoCommand : BaseDeletionCommand<EnderecoQueryModel>
    {
        public DeleteRangeEnderecoCommand(ILogRequestContext ctx, EnderecoQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeEnderecoCommand : BaseRequestableRangeCommand<EnderecoQueryModel, EnderecoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeEnderecoCommand(ILogRequestContext ctx, Dictionary<EnderecoQueryModel, EnderecoDTO> query)
            : base(ctx, query) { }
        public UpdateRangeEnderecoCommand(ILogRequestContext ctx, EnderecoQueryModel query, EnderecoDTO data)
            : base(ctx, new Dictionary<EnderecoQueryModel, EnderecoDTO> { { query, data } }) { }
    }
    
    public partial class UpdateEnderecoCommand : BaseRequestableCommand<EnderecoQueryModel, EnderecoDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateEnderecoCommand(ILogRequestContext ctx, EnderecoQueryModel query, EnderecoDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveEnderecoCommand : EnderecoSearchableCommand
    {
        public ActiveEnderecoCommand(ILogRequestContext ctx, EnderecoQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveEnderecoCommand : EnderecoSearchableCommand
    {
        public DeactiveEnderecoCommand(ILogRequestContext ctx, EnderecoQueryModel query)
            : base(ctx, query) { }
    }
    public class EnderecoSearchableCommand : BaseSearchableCommand<EnderecoQueryModel> {
        public EnderecoSearchableCommand(ILogRequestContext ctx, EnderecoQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateAddressesAggSettingsCommand : BaseRequestableCommand<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsDTO data, bool updateIfExists = true, AddressesAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteAddressesAggSettingsCommand : BaseDeletionCommand<AddressesAggSettingsQueryModel>
    {
        public DeleteAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeAddressesAggSettingsCommand : BaseDeletionCommand<AddressesAggSettingsQueryModel>
    {
        public DeleteRangeAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeAddressesAggSettingsCommand : BaseRequestableRangeCommand<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeAddressesAggSettingsCommand(ILogRequestContext ctx, Dictionary<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query, AddressesAggSettingsDTO data)
            : base(ctx, new Dictionary<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateAddressesAggSettingsCommand : BaseRequestableCommand<AddressesAggSettingsQueryModel, AddressesAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query, AddressesAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveAddressesAggSettingsCommand : AddressesAggSettingsSearchableCommand
    {
        public ActiveAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveAddressesAggSettingsCommand : AddressesAggSettingsSearchableCommand
    {
        public DeactiveAddressesAggSettingsCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class AddressesAggSettingsSearchableCommand : BaseSearchableCommand<AddressesAggSettingsQueryModel> {
        public AddressesAggSettingsSearchableCommand(ILogRequestContext ctx, AddressesAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

}
