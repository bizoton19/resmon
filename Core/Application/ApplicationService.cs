using System;
using System.Collections.Generic;
using System.Text;

namespace resmon.core
{
    public class ApplicationService
    {
        private IApplicationRepository _appRepo;
        public ApplicationService(IApplicationRepository appRepo)
        {
            _appRepo = appRepo;
        }
    }
}
