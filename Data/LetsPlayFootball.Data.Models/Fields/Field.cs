namespace LetsPlayFootball.Data.Models.Fields
{
    using System.Collections.Generic;
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

        [Required]
        public GameFormat GameFormat { get; set; }

        public FieldType FieldType { get; set; }

        public SurfaceType SurfaceType { get; set; }

        public FieldStatus Status { get; set; }

        public int ArenaId { get; set; }

        public virtual Arena Arena { get; set; }

        public int SizeId { get; set; }

        public virtual FieldSize Size { get; set; }

        public int FeaturesId { get; set; }

        public virtual Features Features { get; set; }

        public virtual ICollection<Image> Images { get; set; } = new HashSet<Image>();
    }
}
