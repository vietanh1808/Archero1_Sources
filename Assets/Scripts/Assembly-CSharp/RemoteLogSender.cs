using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class RemoteLogSender
{
	private static RemoteLogSender _instance;

	[CompilerGenerated]
	private Action m_OnConnected;

	[CompilerGenerated]
	private Action m_OnDisconnected;

	[CompilerGenerated]
	private Action<string> m_OnError;

	private bool _isConnected;

	private bool _isInitialized;

	private bool _shutdownRequested;

	private bool _isReconnecting;

	private string _deviceModel;

	private string _serverIp;

	private int _serverPort;

	private string _cachedPersistentDataPath;

	private SynchronizationContext _unitySynchronizationContext;

	private Socket _socket;

	private readonly object _socketLock;

	private readonly Queue<LogEntry> _sendQueue;

	private readonly object _sendQueueLock;

	private Thread _sendThread;

	private ManualResetEvent _sendEvent;

	private Thread _receiveThread;

	private readonly Queue<LogEntry> _cacheQueue;

	private readonly object _cacheQueueLock;

	private RemoteLogFileWriter _fileWriter;

	public static RemoteLogSender Instance => null;

	public int MaxCacheCount { get; set; }

	public float ReconnectTimeout { get; set; }

	public bool IsConnected => false;

	public string ConnectedDeviceModel => null;

	public bool Connected => false;

	public bool Reconnecting => false;

	public event Action OnConnected
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

	public event Action OnDisconnected
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

	public event Action<string> OnError
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

	public static void SendLog(string tag, string message)
	{
	}

	public static void Initialize()
	{
	}

	public static void Shutdown()
	{
	}

	private void DoInitialize()
	{
	}

	private void DoShutdown()
	{
	}

	public void Connect(string address)
	{
	}

	public void Connect(string ip, int port)
	{
	}

	public void Disconnect()
	{
	}

	private void ConnectThreadProc()
	{
	}

	private bool PerformHandshake()
	{
		return false;
	}

	private void OnLogMessageReceived(string condition, string stackTrace, LogType type)
	{
	}

	private void EnqueueLog(LogEntry entry)
	{
	}

	private void SendThreadLoop()
	{
	}

	private void RequeueUnsent(List<LogEntry> batch, int startIndex)
	{
	}

	private void HandleDisconnect()
	{
	}

	private void ReconnectLoop()
	{
	}

	private void FlushCacheOnConnect()
	{
	}

	private void StartReceiveThread()
	{
	}

	private void ReceiveThreadLoop()
	{
	}

	private void DispatchReceivedMessage(byte msgType, byte[] payload)
	{
	}

	private void HandleFileListRequest()
	{
	}

	private void HandleFileTransferRequest(byte[] requestPayload)
	{
	}

	private void SendSingleFile(string filePath)
	{
	}

	private void SendFolderAsZip(string folderPath)
	{
	}

	private List<FileNode> BuildFileNodeTree(string basePath)
	{
		return null;
	}

	private FileNode BuildFolderNode(string folderPath, string basePath)
	{
		return null;
	}

	private FileNode BuildFileNode(string filePath, string basePath)
	{
		return null;
	}

	private string GetRelativePath(string fullPath, string basePath)
	{
		return null;
	}

	private string GetRemoteLogsBasePath()
	{
		return null;
	}

	private void RaiseConnected()
	{
	}

	private void RaiseDisconnected()
	{
	}

	private void RaiseError(string message)
	{
	}

	private void PostToMainThread(Action action)
	{
	}

	private void SendFrame(byte[] frame)
	{
	}

	private void CloseSocket()
	{
	}
}
