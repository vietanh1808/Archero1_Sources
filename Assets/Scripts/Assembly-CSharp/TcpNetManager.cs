using System;
using System.Collections.Generic;
using NetWork;
using TCPPacket;

public class TcpNetManager
{
	public static bool isDebugTcp;

	private static TcpNetState m_State;

	private static TcpNetManager _instance;

	private SocketObject mSocket;

	private int signal;

	private static long serverTimeDistance;

	private static object mLock;

	private Dictionary<ushort, TcpPacketBase> cachePacketDic;

	public static TcpNetManager Instance => null;

	public static TcpNetState NetState
	{
		get
		{
			return (TcpNetState)0;
		}
		private set
		{
		}
	}

	public int OpponentGuid => 0;

	public bool IsOtherPlayerAppPaused { get; set; }

	public static void SetServerTimeDistance(long dis)
	{
	}

	public static long GetServerTime()
	{
		return 0L;
	}

	private void Init()
	{
	}

	public void Connect(string ip, int port, TcpNetState state)
	{
	}

	public void Disconnect()
	{
	}

	public static void SetNetState(TcpNetState state)
	{
	}

	private void OnSignal(int signal)
	{
	}

	public void Update(float time)
	{
	}

	private void ProcessSignal(int i)
	{
	}

	public void SendPacket(TcpPacketBase p, ushort waitCallBack = 0)
	{
	}

	public void SendBuffer(byte[] pSendTar)
	{
	}

	public void RegisterCallBack(ushort id, Action<TcpPacketBase> action)
	{
	}

	public void UnRegisterCallBack(ushort id)
	{
	}

	public TcpPacketBase GetCachePacket(ushort id)
	{
		return null;
	}

	public TcpPacketBase CreateProtoal(ushort protocolId)
	{
		return null;
	}
}
