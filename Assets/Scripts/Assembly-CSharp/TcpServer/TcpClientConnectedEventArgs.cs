using System;
using System.Net.Sockets;

namespace TcpServer
{
	public class TcpClientConnectedEventArgs : EventArgs
	{
		public TcpClient TcpClient { get; private set; }

		public TcpClientConnectedEventArgs(TcpClient tcpClient)
		{
		}
	}
}
