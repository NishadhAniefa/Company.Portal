using Company.Portal.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Company.Portal
{
    [DependsOn(
        typeof(PortalEntityFrameworkCoreTestModule)
        )]
    public class PortalDomainTestModule : AbpModule
    {

    }
}