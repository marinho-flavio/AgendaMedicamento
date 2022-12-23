using SES.Core.Application.DTO.Aggregates.CommonAgg.Commands.Responses;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Json;

namespace Companies.Adm.Panel.Shared
{
    public static class PageInitializator
    {
        public async static Task<T> OnInitializedAsync<T>(this HttpClient Http, string id)
            where T : EntityDTO, new()
        {
            try
            {
                var result = (await Http.GetFromJsonAsync<GetHttpResponseDTO<T>>($"{new T().GetRoute()}?ExternalIdEqual={id}"))?.Data;
                return result;
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
            }
            return null;
        }

        public async static Task<K[]> SearchAsync<T,K>(this HttpClient Http, string id)
            where T : EntityDTO, new()
            where K : EntityDTO, new()
        {
            try
            {
                var result = (await Http.GetFromJsonAsync<GetHttpResponseDTO<K[]>>($"{new T().GetSearchRoute()}"))?.Data;
                return result;
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
            }
            return null;
        }

        public async static Task<K[]> SelectAsync<T, K>(this HttpClient Http)
            where T : EntityDTO, new()
            where K : EntityDTO, new()
        {
            try
            {
                var result = (await Http.GetFromJsonAsync<GetHttpResponseDTO<K[]>>($"{new T().GetSelectRoute()}"))?.Data;
                return result;
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
            }
            return null;
        }

        public async static Task<K[]> SuummaryAsync<T, K>(this HttpClient Http)
            where T : EntityDTO, new()
            where K : EntityDTO, new()
        {
            try
            {
                var result = (await Http.GetFromJsonAsync<GetHttpResponseDTO<K[]>>($"{new T().GetSummaryRoute()}"))?.Data;
                return result;
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
            }
            return null;
        }
    }
}
