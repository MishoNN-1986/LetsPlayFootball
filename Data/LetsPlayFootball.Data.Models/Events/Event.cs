namespace LetsPlayFootball.Data.Models.Events
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;
    using LetsPlayFootball.Data.Models.Fields;
    using LetsPlayFootball.Data.Models.Mappings;
    using LetsPlayFootball.Data.Models.Users;

    public class Event : BaseModel<int>
    {
        public Gender Gender { get; set; }

        public GameFormat GameFormat { get; set; }

        [Required]
        public DateTime Day { get; }

        [Required]
        public DateTime StartingHour { get; set; }

        public double DurationInMinutes { get; set; }

        public decimal TotalPrice { get; set; }

        [MaxLength(2000)]
        public string AdditionalInfo { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public RequestStatus RequestStatus { get; set; }

        public int ArenaId { get; set; }

        public virtual Arena Arena { get; set; }

        public int FieldId { get; set; }

        public virtual Field Field { get; set; }

        public virtual ICollection<EventUser> Users { get; set; } = new HashSet<EventUser>();

        public virtual ICollection<EventMessage> Messages { get; set; } = new HashSet<EventMessage>();

        public virtual ICollection<PlayerDemand> PlayerDemands { get; set; } = new HashSet<PlayerDemand>();
    }
}
