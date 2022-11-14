namespace LetsPlayFootball.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;

    public class Restaurant : BaseDeletableModel<int>
    {
        [MaxLength(15)]
        public int PhoneNumber { get; set; }

        [MaxLength(260)]
        public string WebUrl { get; set; }

        public int FeaturesId { get; set; }

        public virtual Features Features { get; set; }
    }
}
