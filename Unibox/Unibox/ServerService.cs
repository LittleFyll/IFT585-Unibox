using System;

namespace Unibox
{
    class ServerService
    {
        #region Authentication
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
        #endregion

        #region File Management
        /*
         * Description: Create a new user on the server
         * Input: The username to logout
         * Output:
         *      true: logout successful
         *      false: error while authentification
         */
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

        static public void FetchFile(int groupId, int fileId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Group Management
        static public void FetchGroups(int userId)
        {
            // return a list of groups id & name
            throw new NotImplementedException();
        }

        static public void AddGroup(int userId/*, GroupInfo*/)
        {
            throw new NotImplementedException();
        }

        static public void SetAdminInGroup(int userSenderId, int userTargetId, int groupId, bool newAdminValue)
        {
            throw new NotImplementedException();
        }

        static public void RemoveUserFromGroup(int userSenderId, int userTargetId, int groupId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Invite Management
        static public void SendInvite(int userSenderId, int userTargetId, int groupId)
        {
            throw new NotImplementedException();
        }

        static public void ResponseToInvite(int inviteId, bool response)
        {
            throw new NotImplementedException();
        }

        static public void FetchInvites(int userId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
