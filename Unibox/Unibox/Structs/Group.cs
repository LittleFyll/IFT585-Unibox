using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unibox
{
    class Group
    {
        public int groupId;
        public string groupName;
        public List<FileInfo> filesInfo;
        public List<User> members;
        public List<User> admins;
    }
}
