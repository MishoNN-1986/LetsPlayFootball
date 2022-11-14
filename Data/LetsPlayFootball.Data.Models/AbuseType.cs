namespace LetsPlayFootball.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum AbuseType
    {
        [Display(Name = "Physical Aggression")]
        PhysicalAggression = 1,

        [Display(Name = "Sexual Harisement")]
        SexualHarisement = 2,

        [Display(Name = "Aggressive Language")]
        AggressiveLanguage = 3,

        [Display(Name = "Bad Language")]
        BadLanguage = 4,

        Spam = 5,
    }
}
