namespace LetsPlayFootball.Data.Models.Arenas
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Users;

    public class Arena : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(260)]
        public string WebUrl { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public ArenaStatus Status { get; set; }

        [Required]
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public int ArenaOwnerId { get; set; }

        public virtual ApplicationUser ArenaOwner { get; set; }

        public string MainImageId { get; set; }

        public virtual Image MainImage { get; set; }

        public int FeaturesId { get; set; }

        public virtual Features Features { get; set; }

        public virtual ICollection<WorkTime> WorkTimes { get; set; } = new HashSet<WorkTime>();

        public virtual ICollection<Image> Images { get; set; } = new HashSet<Image>();

        // TODO add navigation properties
    }
}
