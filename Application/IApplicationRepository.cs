using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace resmon.core
{
    public interface IApplicationRepository
    {
        Task<IEnumerable<Resource>> GetApplications(string partitionKey = "", int currIndex = 0, int pageSize = 25, Resource resource = null);
        Task<bool> ApplicationExist(ApplicationId appId);
        Task CreateOrUpdateApplication(Application app, List<Resource> resources);
    }
}
