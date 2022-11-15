namespace LetsPlayFootball.Data.Models.Users
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;

    public class PrivateMessage : BaseModel<string>
    {
        public PrivateMessage()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Content { get; set; }

        [Required]
        public string SenderId { get; set; }

        public virtual ApplicationUser Sender { get; set; }

        [Required]
        public string RecipientId { get; set; }

        public virtual ApplicationUser Recipient { get; set; }
    }
}
