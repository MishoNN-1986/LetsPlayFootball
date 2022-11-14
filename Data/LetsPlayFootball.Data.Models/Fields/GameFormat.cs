namespace LetsPlayFootball.Data.Models.Fields
{
    using System.ComponentModel.DataAnnotations;

    public enum GameFormat
    {
        [Display(Name = "5/5")]
        FiveVsFive = 1,

        [Display(Name = "6/6")]
        SixVsSix = 2,

        [Display(Name = "7/7")]
        SevenVsSeven = 3,

        [Display(Name = "8/8")]
        EightVsEight = 4,

        [Display(Name = "9/9")]
        NineVsNine = 5,

        [Display(Name = "10/10")]
        TenVsTen = 6,

        [Display(Name = "11/11")]
        ElevenVsEleven = 7,

        Other = 8,
    }
}
