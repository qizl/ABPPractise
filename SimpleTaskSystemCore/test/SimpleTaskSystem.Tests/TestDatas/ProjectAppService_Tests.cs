using Shouldly;
using SimpleTaskSystem.Tasks;
using Xunit;

namespace SimpleTaskSystem.Tests.TestDatas
{
    public class ProjectAppService_Tests : SimpleTaskSystemTestBase
    {
        private readonly IProjectAppService _projectAppService;

        public ProjectAppService_Tests()
        {
            this._projectAppService = Resolve<IProjectAppService>();
        }

        [Fact]
        public async System.Threading.Tasks.Task GetAllProjects()
        {
            var output = await this._projectAppService.GetAll(new Tasks.Dtos.GetAllProjectsInput());
            
            output.Items.Count.ShouldBe(0);
        }
    }
}
