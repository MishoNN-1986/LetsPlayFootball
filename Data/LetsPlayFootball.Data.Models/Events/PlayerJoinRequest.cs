namespace LetsPlayFootball.Data.Models.Events
{
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Users;

    public class PlayerJoinRequest : BaseModel<int>
    {
        [Required]
        public int JoinedPlayers { get; set; }

        public virtual RequestStatus RequestStatus { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
