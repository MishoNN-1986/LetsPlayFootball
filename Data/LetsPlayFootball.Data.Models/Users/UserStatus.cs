namespace LetsPlayFootball.Data.Models.Users
{
    using System.ComponentModel.DataAnnotations;

    public enum UserStatus
    {
        [Display(Name = "Proposal Open")]
        ProposalOpen = 1,

        [Display(Name = "Proposal Closed")]
        ProposalClosed = 2,

        Unavailable = 3,
    }
}
