namespace LetsPlayFootball.Data.Models
{
    using System;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Url { get; set; }

        // public string ImageContent { get; set; }

        public int? ArenaId { get; set; }

        public virtual Arena Arena { get; set; }

        public virtual ApplicationUser User { get; set; }

        // TODO Add Field
    }
}
