using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unibox
{
    static class LocalFilesService
    {
        /*
         * Description: Get every files in a group directory with their date modified as timestamp
         * Input: The groupId & name to find the directory with the format : <groupId>-<groupName>
         * Output:
         *      Every files in a group directory with their date modified as timestamp, format: List<FileName, timestamp>
         */
        static public List<Tuple<String, int>> GetDateModifiedPerFileFromGroup(int groupId, String groupName)
        {
            throw new NotImplementedException();
        }
    }
}
