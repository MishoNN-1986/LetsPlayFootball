// ReSharper disable VirtualMemberCallInConstructor

namespace LetsPlayFootball.Data.Models.Users
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;
    using LetsPlayFootball.Data.Models.Events;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        // Additional info
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        public Gender? Gender { get; set; }

        public UserStatus? Status { get; set; }

        [MaxLength(200)]
        public string FaceBookAccount { get; set; }

        public bool IsUserProfileUpdated { get; set; }

        // public decimal AverageRating { get; set; }
        // nav props
        public int AddressId { get; set; }

        public string AvatarId { get; set; }

        public Image Avatar { get; set; }

        public virtual Rating Rating { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Arena> Arenas { get; set; } = new HashSet<Arena>();

        public virtual ICollection<Rating> ReceivedRatings { get; set; } = new HashSet<Rating>();

        public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
