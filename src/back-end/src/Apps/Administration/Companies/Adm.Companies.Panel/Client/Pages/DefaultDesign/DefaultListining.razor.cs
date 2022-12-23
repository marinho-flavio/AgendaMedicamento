using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using SES.Core.Application.DTO.Aggregates.CommonAgg.ValueObjects;
using Microsoft.AspNetCore.Components;

namespace Companies.Adm.Panel.Client.Pages.DefaultDesign
{
    public class BaseListiningPage : ComponentBase
    {
        [SupplyParameterFromQuery][Parameter] public int? Page { get; set; }
        [SupplyParameterFromQuery][Parameter] public int? Size { get; set; }
        [SupplyParameterFromQuery][Parameter] public bool? OrderByDesc { get; set; }
        [SupplyParameterFromQuery][Parameter] public string OrderBy { get; set; }
    }

    public class ListiningContext : IListiningContext
    {
        public ListiningContext(
            NavigationManager navigationManager,
            string title,
            int totalOfItems,
            IEnumerable<PropertyDetails> properties,
            Func<Task> paginationLayoutRefresh,
            string queryString = null,
            int? page = 0,
            int? size = 5,
            string orderBy = null,
            bool? orderByDescending = null)
        {
            Size = size ?? 5;
            Page = page ?? 0;
            Title = title;
            OrderBy = orderBy ?? $"{nameof(EntityDTO.CreatedAt)}";
            Properties = properties;
            PaginationLayoutRefresh = paginationLayoutRefresh;
            QueryString = queryString ?? $"{nameof(ActivableEntityDTO.Ativo)}=true";
            OrderByDesc = orderByDescending;
            TotalOfItems = totalOfItems;
            NavigationManager = navigationManager;
        }

        public string Title { get; set; }
        public string QueryString { get; set; }
        public IEnumerable<PropertyDetails> Properties { get; set; }
        public Func<Task> PaginationLayoutRefresh { get; set; }
        public bool? OrderByDesc { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public string OrderBy { get; set; }
        public int TotalOfItems { get; set; }
        public int Max { get { return (int)(TotalOfItems / Size); } }
        public int Min { get { return Page - 2 > 0 ? Page - 2 : 0; } }

        public NavigationManager NavigationManager { get; set; }

        public void Navigate<T>(string queryString = null, int? page = null, int? size = null, bool? orderByDescending = null)
           where T : EntityDTO, new()
        {
            this.QueryString = queryString ?? this.QueryString;
            this.Page = page ?? this.Page;
            this.Size = size ?? this.Size;
            this.OrderByDesc = orderByDescending ?? this.OrderByDesc;

            NavigationManager.NavigateTo($"{new T().GetMyTypeName()}?" +
                $"{buildParam(nameof(Page), Page)}" +
                $"{buildParam(nameof(Size), Size)}" +
                $"{buildParam(nameof(OrderBy), OrderBy)}" +
                $"{buildParam(nameof(OrderByDesc), OrderByDesc)}" +
                $"{QueryString}");
            PaginationLayoutRefresh();
        }

        string buildParam(string name, object val, bool and = true)
        {
            if (string.IsNullOrWhiteSpace(val?.ToString())) return null;
            return $"{name}={val}{(and ? "&" : "")}";
        }
    }

    public interface IListiningContext
    {
        string OrderBy { get; set; }
        bool? OrderByDesc { get; set; }
        int Page { get; set; }
        int Size { get; set; }
        string Title { get; set; }
        string QueryString { get; set; }
        int TotalOfItems { get; set; }
        int Max { get; }
        int Min { get; }
        IEnumerable<PropertyDetails> Properties { get; set; }
        Func<Task> PaginationLayoutRefresh { get; set; }
        NavigationManager NavigationManager { get; }

        public void Navigate<T>(string queryString = null, int? page = null, int? size = null, bool? orderByDescending = null) where T : EntityDTO, new();
    }
}
