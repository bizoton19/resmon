using System;
using System.Threading.Tasks;

namespace resmon.core
{
   public interface IPollable
    {
        Task<State> Poll();
        string GetAbsoluteUri();
       
    }
}