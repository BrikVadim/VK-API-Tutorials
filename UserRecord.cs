using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_API_Tutorial
{
    class UserRecord
    {
        public uint id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userInfo
        {
            get { return firstName + " " + lastName + "\n"; }
        }
    }
}
