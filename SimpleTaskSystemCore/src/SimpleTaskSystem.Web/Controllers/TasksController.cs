using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SimpleTaskSystem.People;
using SimpleTaskSystem.Tasks;
using SimpleTaskSystem.Tasks.Dtos;
using SimpleTaskSystem.Web.Models.People;
using SimpleTaskSystem.Web.Models.Tasks;

namespace SimpleTaskSystem.Web.Controllers
{
    public class TasksController : SimpleTaskSystemControllerBase
    {
        private readonly ITaskAppService _taskAppService;
        private readonly IPersonAppService _personAppService;

        public TasksController(ITaskAppService taskAppService, IPersonAppService personAppService)
        {
            this._taskAppService = taskAppService;
            this._personAppService = personAppService;
        }

        public async Task<IActionResult> Index(GetAllTasksInput input)
        {
            var output = await this._taskAppService.GetAll(input);

            var model = new IndexViewModel(output.Items)
            {
                SelectedTaskState = input.State
            };

            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            var peopleSelectListItems = (await this._personAppService.GetPeopleComboboxItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            peopleSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("Unassigned"), Selected = true });

            return View(new CreateTaskViewModel(peopleSelectListItems));
        }
    }
}