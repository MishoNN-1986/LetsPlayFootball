namespace LetsPlayFootball.Data.Models.Arenas
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;

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

        public virtual ICollection<WorkTime> WorkTimes { get; set; } = new HashSet<WorkTime>();

        // TODO add navigation properties
    }
}
