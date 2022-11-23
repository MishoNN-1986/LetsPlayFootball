namespace LetsPlayFootball.Data.Models
{
    using System;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;
    using LetsPlayFootball.Data.Models.Fields;
    using LetsPlayFootball.Data.Models.Users;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string ImageContent { get; set; }

        public int? ArenaId { get; set; }

        public virtual Arena Arena { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int? FieldId { get; set; }

        public virtual Field Field { get; set; }
    }
}
