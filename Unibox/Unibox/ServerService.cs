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
         * Description: Add a file to the server filesystem
         * Input: The id of the group with whom the file must be shared, the name of the file, it's content and the timestamp at which the add was requested
         * Output:
         *      The ID generated for the newly added file if the addition was successful, or an error code otherwise
         */
        static public int AddFile(int groupId, String fileName, byte[] fileData, int timestamp)
        {
            throw new NotImplementedException();
        }

        /*
         * Description: Overwrites the content of an existing shared file to reflect its latest modifications
         * Input: The ID of the group with which the file is shared, the ID of the file to be updated, its data, and the timestamp at which the update was requested
         * Output:
         *      true: update successful
         *      false: error/no changes applied
         */
        static public bool UpdateFile(int groupId, int fileId, byte[] fileData, int timestamp)
        {
            throw new NotImplementedException();
        }

        /*
         * Description: Delete a shared file
         * Input: The ID of the group with which the file is shared, the ID of the file to be deleted
         * Output:
         *      true: file successfully deleted
         *      false: file couldn't be deleted
         */
        static public bool DeleteFile(int groupId, int fileId)
        {
            throw new NotImplementedException();
        }

        /*
         * Description: Request a file from the server
         * Input: the id of the group owning the file, and the id of the file
         * Output:
         *      None
         */
        static public void FetchFile(int groupId, int fileId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Group Management
        /*
         * Description: Fetch all the groups to which a given user belongs 
         * Input: a userID
         * Output:
         *      A list of groups
         */
        static public void FetchGroups(int userId)
        {
            // return a list of groups id & name
            throw new NotImplementedException();
        }

        /*
         * Description: Add the given userID to a group
         * Input: a user id 
         * Output:
         *      None
         */
        static public void AddGroup(int userId/*, GroupInfo*/)
        {
            throw new NotImplementedException();
        }

        /*
         * Description: Sets the admin property of a given user to true or false for a given group
         * Input: the id of the member that requested the change, the id of the user whose admin right will be modified, the id of the group whose admin must be changed, 
         *        and the new value of the admin right for the target.
         * Output:
         *      None
         */
        static public void SetAdminInGroup(int userSenderId, int userTargetId, int groupId, bool willTargetBeAdmin)
        {
            throw new NotImplementedException();
        }

        /*
         * Description: Remove a given user from a group
         * Input: The userID of the user who requested the change, the userID of the user to remove from a group, and the id of the group
         * Output:
         *      None
         */
        static public void RemoveUserFromGroup(int userSenderId, int userTargetId, int groupId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Invite Management
        /*
         * Description: Send an invitation to a user to join a given group
         * Input: The ID of the user who sent the invitation, the ID of the invited user, and the id of the group
         * Output:
         *      None
         */
        static public void SendInvite(int userSenderId, int userTargetId, int groupId)
        {
            throw new NotImplementedException();
        }

        /*
         * Description: Accepts or decline an invitaiton to a group
         * Input: The ID of the invitation, and the answer (accept = true, decline = false)
         * Output:
         *      None
         */
        static public void ResponseToInvite(int inviteId, bool response)
        {
            throw new NotImplementedException();
        }

        /*
         * Description: Fetches a list of all the invitation sent to a given user
         * Input: A userID
         * Output:
         *      A list of all the invitations sent to a given user
         */
        static public void FetchInvites(int userId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
