namespace LetsPlayFootball.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;

    public class WorkTime : BaseModel<int>
    {
        [Required]
        public DayOfWeek Day { get; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndTime { get; set; }

        [Required]
        public int ArenaId { get; set; }

        public Arena Arena { get; set; }
    }
}
