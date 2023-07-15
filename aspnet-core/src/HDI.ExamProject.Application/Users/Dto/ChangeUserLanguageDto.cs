using System.ComponentModel.DataAnnotations;

namespace HDI.ExamProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}