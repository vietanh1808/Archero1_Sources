using System;
using System.Collections.Generic;
using Poco;
using TcpServer;
using UnityEngine;

public class PocoManager : MonoBehaviour
{
	private class RPC : Attribute
	{
	}

	public const int versionCode = 6;

	public int port;

	private bool mRunning;

	public AsyncTcpServer server;

	private RPCParser rpc;

	private SimpleProtocolFilter prot;

	private UnityDumper dumper;

	private ConcurrentDictionary<string, TcpClientState> inbox;

	private VRSupport vr_support;

	private Dictionary<string, long> debugProfilingData;

	private void Awake()
	{
	}

	private static void server_ClientConnected(object sender, TcpClientConnectedEventArgs e)
	{
	}

	private static void server_ClientDisconnected(object sender, TcpClientDisconnectedEventArgs e)
	{
	}

	private void server_Received(object sender, TcpDatagramReceivedEventArgs<byte[]> e)
	{
	}

	[RPC]
	private object Dump(List<object> param)
	{
		return null;
	}

	[RPC]
	private object Screenshot(List<object> param)
	{
		return null;
	}

	[RPC]
	private object GetScreenSize(List<object> param)
	{
		return null;
	}

	public void stopListening()
	{
	}

	[RPC]
	private object GetDebugProfilingData(List<object> param)
	{
		return null;
	}

	[RPC]
	private object SetText(List<object> param)
	{
		return null;
	}

	[RPC]
	private object GetSDKVersion(List<object> param)
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDestroy()
	{
	}
}
