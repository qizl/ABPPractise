using Abp.AspNetCore.Mvc.Controllers;

namespace SimpleTaskSystem.Web.Controllers
{
    public abstract class SimpleTaskSystemControllerBase: AbpController
    {
        protected SimpleTaskSystemControllerBase()
        {
            LocalizationSourceName = SimpleTaskSystemConsts.LocalizationSourceName;
        }
    }
}