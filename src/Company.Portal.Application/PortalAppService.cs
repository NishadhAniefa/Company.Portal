using System;
using System.Collections.Generic;
using System.Text;
using Company.Portal.Localization;
using Volo.Abp.Application.Services;

namespace Company.Portal
{
    /* Inherit your application services from this class.
     */
    public abstract class PortalAppService : ApplicationService
    {
        protected PortalAppService()
        {
            LocalizationResource = typeof(PortalResource);
        }
    }
}
