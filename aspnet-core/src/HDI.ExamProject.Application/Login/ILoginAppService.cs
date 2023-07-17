using System;
using System.Threading.Tasks;

namespace HDI.ExamProject.Login
{
    public interface ILoginAppService
    {
        Task<bool> LoginAsync(string username, string password);
    }

}

