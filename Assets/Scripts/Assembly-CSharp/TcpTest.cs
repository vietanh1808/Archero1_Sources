using System.Collections.Concurrent;
using System.Threading;
using UnityEngine;

public class TcpTest : MonoBehaviour
{
	public struct LogData
	{
		public string str;

		public bool isError;
	}

	private static ConcurrentQueue<string> logList;

	private static object lockObj;

	private static Thread LogThread;

	private static string Path;

	public static void AddLog(string s, bool isError)
	{
	}

	private void Awake()
	{
	}

	private void WriteLog()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
