using Volo.Abp.Modularity;

namespace Company.Portal
{
    [DependsOn(
        typeof(PortalApplicationModule),
        typeof(PortalDomainTestModule)
        )]
    public class PortalApplicationTestModule : AbpModule
    {

    }
}