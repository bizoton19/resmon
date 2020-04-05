using System;
using System.Collections.Generic;

namespace resmon.core
{
    
    public class Application
    {
        private string _name;
        private string _description;
        private List<ResourceId> _resources;
        private ApplicationId _appId;
        public Application(ApplicationId appId, string name, string description)
        {
            _appId = appId;
            _name = name;
            _description = description;
            
        }
       
        public string Name { get => _name; private set => _name = value; }
        public string Description { get => _description; private set => _description = value; }
        public List<ResourceId> Resources { get => _resources; set => _resources = value; }
        public ApplicationId AppId { get => _appId; set => _appId = value; }
        public ApplicationContact Contact { get; set; }
        public string GetAbsoluteUri()
        {
            throw new NotImplementedException();
        }
        
    }
}
