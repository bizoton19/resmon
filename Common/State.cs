using System;

namespace resmon.core{
    public struct State{
       
        public string Url { get; set; }
        public string Status { get; set; }
        public int ResponseTime { get; set; }
        public string Description { get; set;   }

        public string Type { get; set; }

       
    
    }
}