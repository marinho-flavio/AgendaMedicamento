﻿using SES.Core.Application.DTO.Aggregates.CommonAgg.Commands.Responses;
using SES.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Companies.Adm.Panel.Shared.Extensions
{
    public static class HttpResponseDTOExtensions
    {
        public static async Task<object> ReadBodyFromContextResponse(this HttpContext context)
        {
            

            context.Request.EnableBuffering();
            context.Request.Body.Position = 0;

            var sr = new StreamReader(context.Request.Body);

            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            var stringBody = await sr.ReadToEndAsync();
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            sr.DiscardBufferedData();

            return JsonConvert.DeserializeObject<object>(stringBody);
        }

        

        public static GetHttpResponseDTO ConstructErrorMessages(this ModelStateDictionary response)
        {
            var result = GetHttpResponseDTO.BadRequest();

            foreach (var keyModelStatePair in response)
            {
                var key = keyModelStatePair.Key;
                var errors = keyModelStatePair.Value.Errors;
                if (errors != null && errors.Count > 0)
                {
                    if (errors.Count == 1)
                    {
                        var errorMessage = GetErrorMessage(errors[0]);
                        result.AddError(errorMessage);
                    }
                    else
                    {
                        var errorMessages = new string[errors.Count];
                        for (var i = 0; i < errors.Count; i++)
                        {
                            errorMessages[i] = GetErrorMessage(errors[i]);
                        }

                        result.AddError(errorMessages.ToArray());
                    }
                }
            }
            return result;
        }

        static string GetErrorMessage(ModelError error)
        {
            return string.IsNullOrEmpty(error.ErrorMessage) ?
            "O campo não é válido." :
            error.ErrorMessage;
        }

        public static GetHttpResponseDTO BadRequest(this GetHttpResponseDTO response, IdentityResult identityResult)
        {
            return GetHttpResponseDTO.BadRequest(identityResult.Errors.Select(x => x.Description).ToArray());
        }
    }
}
