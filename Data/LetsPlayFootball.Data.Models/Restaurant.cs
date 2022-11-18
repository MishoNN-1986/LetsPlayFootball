namespace LetsPlayFootball.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;

    public class Restaurant : BaseDeletableModel<int>
    {
        [MaxLength(15)]
        public int PhoneNumber { get; set; }

        [MaxLength(260)]
        public string WebUrl { get; set; }

        public int ArenaId { get; set; }

        public virtual Arena Arena { get; set; }
    }
}
