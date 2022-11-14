namespace LetsPlayFootball.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;

    public class Rating : BaseModel<int>
    {
        [Required]
        [Range(typeof(int), "1", "5")]
        public int RatingValue { get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public int? UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int? ArenaId { get; set; }

        public virtual Arena Arena { get; set; }
    }
}
