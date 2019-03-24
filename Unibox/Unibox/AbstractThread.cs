using System.Threading;

namespace Unibox
{
    abstract class AbstractThread
    {
        private Thread _thread;

        public AbstractThread()
        {
            _thread = new Thread(new ThreadStart(this.RunThread));
        }

        // Thread methods / properties
        public void Start() => _thread.Start();
        public void Join() => _thread.Join();
        public bool IsAlive => _thread.IsAlive;

        public abstract void RunThread();
        //{
        // Do stuff

        // Invite
        // ConnectedUserList
        // GroupList
        // NewFile
        // UpdateFile
        //}
    }
}
