namespace LetsPlayFootball.Data.Models.Fields
{
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;

    public class Field : BaseDeletableModel<int>
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(2000)]
        public string PriceDetails { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public int ArenaId { get; set; }

        public virtual Arena Arena { get; set; }
    }
}
