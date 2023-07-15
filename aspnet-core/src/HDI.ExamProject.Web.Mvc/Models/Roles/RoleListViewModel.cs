using System.Collections.Generic;
using HDI.ExamProject.Roles.Dto;

namespace HDI.ExamProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
