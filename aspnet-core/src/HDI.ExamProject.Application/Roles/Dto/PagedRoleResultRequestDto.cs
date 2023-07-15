using Abp.Application.Services.Dto;

namespace HDI.ExamProject.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

