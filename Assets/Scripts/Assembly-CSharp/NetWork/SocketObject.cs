using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using TCPPacket;

namespace NetWork
{
	public class SocketObject
	{
		private const int BufferSize = 8192;

		private Action<int> onSignal;

		private Thread recv_Thread;

		private Thread sendHeartBeat_Thread;

		private byte[] recvBuffer;

		private int bufferStart;

		private int bufferEndPos;

		private Socket m_socket;

		private bool isStartThread;

		private bool isgoingToShuDown;

		private long lastHeartBeatSendTime;

		private byte[] sendByte;

		private readonly int[] ExcutePacketCount;

		private Dictionary<short, ConcurrentQueue<TcpPacketBase>> recvDic;

		private ConcurrentQueue<byte[]> sendQueue;

		private Dictionary<ushort, Action<TcpPacketBase>> callBackFunc;

		private long lastTime;

		private SocketError errorCode;

		public bool IsConnect => false;

		public SocketObject(Action<int> signalFunc)
		{
		}

		protected List<IPAddress> GetServerIpAddress(string _hostname)
		{
			return null;
		}

		public bool Connect(string ip, int port)
		{
			return false;
		}

		private void Clear()
		{
		}

		private void ConnectCallback(IAsyncResult async)
		{
		}

		public void ShutDown(int type = 0)
		{
		}

		private void CreateRecvThread()
		{
		}

		public void Update(float deltaTime)
		{
		}

		private void Receive()
		{
		}

		private void ParseDataBuffer()
		{
		}

		private void SerializeMessage(int size)
		{
		}

		private void EnqueueRecvQueue(TcpPacketBase packet, short pLevel = 2)
		{
		}

		private void SendThreadFunc()
		{
		}

		private void CheckSendQueue()
		{
		}

		private void ParseSendByte(byte[] sendBytes)
		{
		}

		private void InitRecvQueue()
		{
		}

		private void ClearSendAndRecvQueue()
		{
		}

		private void UpdateRecv()
		{
		}

		private void ExcuteRecvPacket(short level, int Count)
		{
		}

		public void RegisterCallBack(ushort id, Action<TcpPacketBase> callBack)
		{
		}

		public void UnRegisterCallBack(ushort id)
		{
		}

		public void SendBuffer(byte[] pSendBuffer)
		{
		}

		public void Send(TcpPacketBase packet, ushort callBackPacket = 0)
		{
		}
	}
}
