using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unibox
{
    class ServerService
    {
        /*
         * Description: Authenticate with the server
         * Input: The credentials
         * Output:
         *      true: authentification successful
         *      false: error while authentification
         */
        static public bool SignIn(String username, String password)
        {
           throw new NotImplementedException();
        }

        /*
         * Description: Logout from the server
         * Input: The username to logout
         * Output:
         *      true: logout successful
         *      false: error while authentification
         */
        static public bool SignOut(String username)
        {
            throw new NotImplementedException();
        }

        /*
         * Description: Create a new user on the server
         * Input: The username to logout
         * Output:
         *      true: logout successful
         *      false: error while authentification
         */
        static public bool SignUp(String username, String password)
        {
            throw new NotImplementedException();
        }

        static public int AddFile(int groupId, int fileName, byte[] fileData, int timestamp)
        {
            throw new NotImplementedException();
        }

        static public bool UpdateFile(int groupId, int fileId, byte[] fileData, int timestamp)
        {
            throw new NotImplementedException();
        }

        static public bool DeleteFile(int groupId, int fileId)
        {
            throw new NotImplementedException();
        }

        static public void FetchGroups(String username)
        {
            // return a list of groups id & name
            throw new NotImplementedException();
        }

        static public void FetchsFileFromGroup
    }
}
