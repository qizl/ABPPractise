using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SimpleTaskSystem.Web.Models.People
{
    public class CreateTaskViewModel
    {
        public List<SelectListItem> People { get; set; }

        public CreateTaskViewModel(List<SelectListItem> people)
        {
            People = people;
        }
    }
}
