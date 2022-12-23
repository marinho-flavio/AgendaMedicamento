using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SES.Core.Domain.Aggregates.CommonAgg.ValueObjects
{
    public class EventsHistory
    {
        public EventsHistory(string userId, string userName)
        {
            UserId = userId;
            UpdatedAt = DateTime.UtcNow;
            UserName = userName;
        }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
