using System.Collections.Generic;
using HDI.ExamProject.Roles.Dto;

namespace HDI.ExamProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
