namespace LetsPlayFootball.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;
    using LetsPlayFootball.Data.Models.Users;

    public class Address : BaseDeletableModel<int>
    {
        [MaxLength(100)]
        public string AddressInformation { get; set; }

        public virtual Arena Arena { get; set; }

        [Required]
        public int CityId { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; } = new HashSet<ApplicationUser>();
    }
}
