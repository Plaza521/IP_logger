using System.Net;

namespace SIP_log
{
    class Program
    {
        public static bool DEBUG_MODE = false;
        static void Main()
        {
            send_ip();
        }
        static int send_ip()
        {
            try
            {
                WebRequest request = WebRequest.Create("http://127.0.0.1");
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                response.Close();
                return 0;
            }
            catch
            {
                return 1;
            }
        }
    }
}
