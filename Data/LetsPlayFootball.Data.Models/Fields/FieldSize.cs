namespace LetsPlayFootball.Data.Models.Fields
{
    using LetsPlayFootball.Data.Common.Models;

    public class FieldSize : BaseModel<int>
    {
        public int Length { get; set; }

        public int Width { get; set; }

        public int FieldId { get; set; }

        public virtual Field Field { get; set; }
    }
}
