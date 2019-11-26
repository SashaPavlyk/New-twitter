using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPPTwitter.Models
{
    [Serializable]
    class Messages
    {
        public string Name { get; set; }
        public string Msg { get; set; }
        public override string ToString()
        {
            return $"{Name}:{Msg}";
        }
    }
}
