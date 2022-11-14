namespace LetsPlayFootball.Data.Models.Fields
{
    using System.ComponentModel.DataAnnotations;

    public enum SurfaceType
    {
        Grass = 1,

        [Display(Name = "Artificial Grass")]
        ArtificialGrass = 2,

        Wooden = 3,
        Asphalt = 4,
        Rubber = 5,
        Other = 6,
    }
}
