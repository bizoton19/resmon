using System.Collections.Generic;
using System.Threading.Tasks;
using resmon.core;
namespace resmon.core
{
    public interface IStateRepository
    {
        Task Save(ICollection<State> state);
        Task<IEnumerable<State>> GetStates(string partitionKey="");
        
    }
}
