namespace Unibox
{
    static class CommandController
    {
        #region Authentication
        static public void SignIn()
        {
            // side effect: update connected list to all
        }

        static public void SignOut()
        {
            // side effect: update connected list to all
        }

        static public void SignUp()
        {
            // side effect: update connected list to all
        }
        #endregion

        #region GroupManagement
        static public void CreateGroup()
        {
            // side effect: none
        }

        static public void SendInviteToUserFromGroup()
        {
            // side effect: send invite to target
        }

        static public void RemoveUserFromGroup()
        {
            // side effect: update groupInfo to target
        }

        static public void SetAdminForGroup()
        {
            // side effect: update groupInfo to target
        }
        #endregion

        #region FileManagement
        static public void OpenFolder()
        {
        }

        static public void DeleteFile()
        {
        }
        #endregion

        #region InvitationManagement
        static public void ResponseToInvite(bool response)
        {
        }
        #endregion
    }
}
