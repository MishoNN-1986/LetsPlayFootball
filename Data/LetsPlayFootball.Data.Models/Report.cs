namespace LetsPlayFootball.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Users;

    public class Report : BaseDeletableModel<int>
    {
        [Required]
        public string SenderId { get; set; }

        public ApplicationUser Sender { get; set; }

        [Required]
        [MaxLength(4000)]
        public string Content { get; set; }

        [Required]
        public string ReportedUserId { get; set; }

        public ApplicationUser ReportedUser { get; set; }

        public AbuseType Abuse { get; set; }
    }
}
