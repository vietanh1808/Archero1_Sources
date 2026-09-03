using BestHTTP.WebSocket;

public class MatchDefenceTimeSocketCtrl : Singleton<MatchDefenceTimeSocketCtrl>
{
	public enum ConnectState
	{
		eConnecting = 0,
		eConnected = 1,
		eClose = 2
	}

	private const string url = "wss://api-archer.habby.mobi:4443/matching";

	private WebSocket webSocket;

	private ConnectState mState;

	private string otheruserid;

	private string myname;

	public ConnectState State => ConnectState.eConnecting;

	public bool IsConnected => false;

	public void init()
	{
	}

	public void Deinit()
	{
	}

	public void Connect()
	{
	}

	public void Close()
	{
	}

	private byte[] getBytes(string message)
	{
		return null;
	}

	public void Send(MatchMessageType msgtype, int arg = 0)
	{
	}

	public void Send(string str)
	{
	}

	private void OnOpen(WebSocket ws)
	{
	}

	private void OnMessageReceived(WebSocket ws, string message)
	{
	}

	private void OnBinaryReceived(WebSocket ws, byte[] bytes)
	{
	}

	private void OnClosed(WebSocket ws, ushort code, string message)
	{
	}

	private new void OnDestroy()
	{
	}

	private void OnError(WebSocket ws, string reason)
	{
	}
}
