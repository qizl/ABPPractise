using System.Linq;
using SimpleTaskSystem.Tasks;
using SimpleTaskSystem.Tasks.Dtos;

namespace SimpleTaskSystem.Web.Models
{
    public static class SeedData
    {
        public static void Initialize(ITaskAppService taskAppService)
        {
            if (taskAppService.GetAll(new GetAllTasksInput()).Result.Items.Any())
                return;
            
            for (int i = 0; i < 500; i++)
                taskAppService.Create(new CreateTaskInput()
                {
                    Title = $"测试数据-{i}",
                    Description = $"测试数据描述 {i}"
                });
        }
    }
}