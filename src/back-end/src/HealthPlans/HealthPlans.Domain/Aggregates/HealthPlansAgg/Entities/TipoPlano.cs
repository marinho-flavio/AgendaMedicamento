using Bravo.Core.Domain.Aggregates.CommonAgg.Entities;
using Bravo.Core.Domain.Attributes.T4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.HealthPlans.Domain.Aggregates.HealthPlansAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class TipoPlano : Entity
    {
        public string Nome { get; set; }
    }
}
