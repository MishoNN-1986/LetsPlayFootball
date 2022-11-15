namespace LetsPlayFootball.Data.Models.Events
{
    using System.Collections.Generic;

    using LetsPlayFootball.Data.Common.Models;

    public class PlayerDemand : BaseModel<int>
    {
        public int NeededPlayers { get; set; }

        public int EventId { get; set; }

        public virtual Event Event { get; set; }

        public virtual ICollection<PlayerJoinRequest> PlayerJoinRequests { get; set; } = new HashSet<PlayerJoinRequest>();
    }
}
