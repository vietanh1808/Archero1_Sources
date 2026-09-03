using System;
using System.Net.Sockets;

namespace TcpServer
{
	public class TcpClientDisconnectedEventArgs : EventArgs
	{
		public TcpClient TcpClient { get; private set; }

		public TcpClientDisconnectedEventArgs(TcpClient tcpClient)
		{
		}
	}
}
