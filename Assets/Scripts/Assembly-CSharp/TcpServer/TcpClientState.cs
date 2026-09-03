using System.Net.Sockets;

namespace TcpServer
{
	public class TcpClientState
	{
		public TcpClient TcpClient { get; private set; }

		public byte[] Buffer { get; private set; }

		public ProtoFilter Prot { get; private set; }

		public NetworkStream NetworkStream => null;

		public TcpClientState(TcpClient tcpClient, byte[] buffer, ProtoFilter prot)
		{
		}
	}
}
