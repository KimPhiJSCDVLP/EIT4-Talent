using System.ComponentModel.DataAnnotations;

namespace EIT4Talent.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}