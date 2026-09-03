public class SystemProxy
{
	protected static bool GetSystemProxyAndroid(out string host, out int port)
	{
		host = null;
		port = default;
		return false;
	}

	protected static bool GetSystemProxy(out string host, out int port)
	{
		host = null;
		port = default;
		return false;
	}

	public static void InitProxy()
	{
	}
}
