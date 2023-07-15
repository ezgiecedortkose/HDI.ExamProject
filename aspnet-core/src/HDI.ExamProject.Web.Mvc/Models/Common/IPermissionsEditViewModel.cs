using System.Collections.Generic;
using HDI.ExamProject.Roles.Dto;

namespace HDI.ExamProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}