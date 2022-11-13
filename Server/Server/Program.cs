using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Configuration;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ServerPort = ConfigurationManager.AppSettings["ServerPort"];
            TcpChannel channel = new TcpChannel(int.Parse(ServerPort));
            ChannelServices.RegisterChannel(channel, false);
        }
    }
}
