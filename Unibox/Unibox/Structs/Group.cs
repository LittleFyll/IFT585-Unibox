using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unibox
{
    public struct Group
    {
        public int groupId;
        public string groupName;
        public List<FileInfo> filesInfo;
        public List<User> members;
        public List<User> admins;

        public User User
        {
            get => default(User);
            set
            {
            }
        }

        public FileInfo FileInfo
        {
            get => default(FileInfo);
            set
            {
            }
        }

        public User User1
        {
            get => default(User);
            set
            {
            }
        }

        public FileInfo FileInfo1
        {
            get => default(FileInfo);
            set
            {
            }
        }
    }
}
