using Renci.SshNet;

namespace Core.Instances
{
    public class SSHInstance
    {
        private static SSHInstance _instance;
        private SshClient client;

        private SSHInstance () { }

        public SSHInstance GetInstance()
        {
            if (_instance == null)
                _instance = new SSHInstance();
            
            return _instance;
        }

        public void Close()
        {
            if (client.IsConnected == false)
                return;

            client.Disconnect();
        }

        public void Start(string host, string username, string password)
        {
            if (client.IsConnected)
                Close();

            ConnectionInfo connection = new ConnectionInfo(host,
                username,
                new PasswordAuthenticationMethod(username, password));

            client = new SshClient(connection);

            client.Connect();
        }

        public void SendMessage(string command)
        {
            if (client.IsConnected == false)
                return;

            client.CreateCommand(command);        }

    }
}
