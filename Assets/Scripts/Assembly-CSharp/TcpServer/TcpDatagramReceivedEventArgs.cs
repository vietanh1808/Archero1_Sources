using System;
using System.Net.Sockets;

namespace TcpServer
{
	public class TcpDatagramReceivedEventArgs<T> : EventArgs
	{
		public TcpClientState Client { get; private set; }

		public TcpClient TcpClient { get; private set; }

		public T Datagram { get; private set; }

		public TcpDatagramReceivedEventArgs(TcpClientState tcpClientState, T datagram)
		{
		}
	}
}
