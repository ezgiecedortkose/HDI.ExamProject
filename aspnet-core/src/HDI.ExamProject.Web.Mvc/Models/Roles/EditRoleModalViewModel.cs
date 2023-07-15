using Abp.AutoMapper;
using HDI.ExamProject.Roles.Dto;
using HDI.ExamProject.Web.Models.Common;

namespace HDI.ExamProject.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
