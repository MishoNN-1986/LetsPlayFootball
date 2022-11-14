namespace LetsPlayFootball.Data.Models.Fields
{
    using System.ComponentModel.DataAnnotations;

    public enum FieldStatus
    {
        Reserved = 1,
        Available = 2,

        [Display(Name = "Temporary Unavailable")]
        TemporatyUnavailable = 3,
    }
}
