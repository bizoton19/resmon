
using System.Collections.Generic;
using System.Threading.Tasks;

namespace resmon.core
{
   public interface IResourceRepository
    {
        Task Save(ICollection<State> state);
        Task<IEnumerable<Resource>> GetResources(string partitionKey="",Resource clause=null);
    }
}
