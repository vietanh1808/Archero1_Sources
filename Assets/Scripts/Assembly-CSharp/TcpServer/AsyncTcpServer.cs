using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace TcpServer
{
	public class AsyncTcpServer : IDisposable
	{
		private TcpListener _listener;

		private ConcurrentDictionary<string, TcpClientState> _clients;

		private bool _disposed;

		[CompilerGenerated]
		private EventHandler<TcpDatagramReceivedEventArgs<byte[]>> m_DatagramReceived;

		[CompilerGenerated]
		private EventHandler<TcpDatagramReceivedEventArgs<string>> m_PlaintextReceived;

		[CompilerGenerated]
		private EventHandler<TcpClientConnectedEventArgs> m_ClientConnected;

		[CompilerGenerated]
		private EventHandler<TcpClientDisconnectedEventArgs> m_ClientDisconnected;

		public bool IsRunning { get; private set; }

		public IPAddress Address { get; private set; }

		public int Port { get; private set; }

		public Encoding Encoding { get; set; }

		public event EventHandler<TcpDatagramReceivedEventArgs<byte[]>> DatagramReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<TcpDatagramReceivedEventArgs<string>> PlaintextReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<TcpClientConnectedEventArgs> ClientConnected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<TcpClientDisconnectedEventArgs> ClientDisconnected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public AsyncTcpServer(int listenPort)
		{
		}

		public AsyncTcpServer(IPEndPoint localEP)
		{
		}

		public AsyncTcpServer(IPAddress localIPAddress, int listenPort)
		{
		}

		public AsyncTcpServer Start()
		{
			return null;
		}

		public AsyncTcpServer Start(int backlog)
		{
			return null;
		}

		public AsyncTcpServer Stop()
		{
			return null;
		}

		private void ContinueAcceptTcpClient(TcpListener tcpListener)
		{
		}

		private void HandleTcpClientAccepted(IAsyncResult ar)
		{
		}

		private void HandleDatagramReceived(IAsyncResult ar)
		{
		}

		private void ContinueReadBuffer(TcpClientState internalClient, NetworkStream networkStream)
		{
		}

		private void RaiseDatagramReceived(TcpClientState sender, byte[] datagram)
		{
		}

		private void RaisePlaintextReceived(TcpClientState sender, byte[] datagram)
		{
		}

		private void RaiseClientConnected(TcpClient tcpClient)
		{
		}

		private void RaiseClientDisconnected(TcpClient tcpClient)
		{
		}

		private void GuardRunning()
		{
		}

		public void Send(TcpClient tcpClient, byte[] datagram)
		{
		}

		public void Send(TcpClient tcpClient, string datagram)
		{
		}

		public void SendToAll(byte[] datagram)
		{
		}

		public void SendToAll(string datagram)
		{
		}

		private void HandleDatagramWritten(IAsyncResult ar)
		{
		}

		public void SyncSend(TcpClient tcpClient, byte[] datagram)
		{
		}

		public void SyncSend(TcpClient tcpClient, string datagram)
		{
		}

		public void SyncSendToAll(byte[] datagram)
		{
		}

		public void SyncSendToAll(string datagram)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
