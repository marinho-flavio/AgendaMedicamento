﻿using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.ValueObjects;
using Bravo.Core.Application.DTO.Attributes;
using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bravo.Companies.Domain.Aggregates.ProfessionalsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class ProfissionalConfiguracao : Entity
    {
        [Step(2), RequiredT4, RegisterOrder(0)]
        [Column(TypeName = "jsonb")]
        public ImageFileInfo? Logo { get; set; }

        [Step(2), RequiredT4, DisplayName("Setor Próprio"), RegisterOrder(1)]
        public bool? SetorProprio { get; set; }
    }
}
