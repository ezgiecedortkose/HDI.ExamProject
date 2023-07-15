using System.Threading.Tasks;
using HDI.ExamProject.Models.TokenAuth;
using HDI.ExamProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace HDI.ExamProject.Web.Tests.Controllers
{
    public class HomeController_Tests: ExamProjectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}