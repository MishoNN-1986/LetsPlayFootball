namespace LetsPlayFootball.Data.Models
{
    using System.Collections.Generic;

    using LetsPlayFootball.Data.Common.Models;
    using LetsPlayFootball.Data.Models.Arenas;
    using LetsPlayFootball.Data.Models.Fields;

    public class Features : BaseModel<int>
    {
        public bool Ball { get; set; }

        public bool Jerseys { get; set; }

        public bool Floodlights { get; set; }

        public bool Changeroom { get; set; }

        public bool BathAndToilet { get; set; }

        public bool Parking { get; set; }

        public bool Bench { get; set; }
    }
}
