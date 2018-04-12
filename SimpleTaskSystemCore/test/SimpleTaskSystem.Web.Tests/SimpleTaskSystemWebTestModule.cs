using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SimpleTaskSystem.Web.Startup;
namespace SimpleTaskSystem.Web.Tests
{
    [DependsOn(
        typeof(SimpleTaskSystemWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class SimpleTaskSystemWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleTaskSystemWebTestModule).GetAssembly());
        }
    }
}