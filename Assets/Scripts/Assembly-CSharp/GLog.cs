using System;
using System.IO;
using System.Text;
using UnityEngine;

public class GLog
{
	public enum Tag
	{
		eBattle = 0,
		eUI = 1,
		eBattleStatus = 2,
		eFile = 3,
		eBuff = 4
	}

	public static GLog Instance;

	public const int LOG_DEBUG = 0;

	public const int LOG_INFO = 1;

	public const int LOG_WARNING = 2;

	public const int LOG_ERROR = 3;

	public const int LOG_EXCEPTION = 4;

	public const int LOG_ASSERT = 5;

	public const int FLAG_AUTO_FLUSH = 1;

	public const int FLAG_TO_CONSOLE = 2;

	public const int FLAG_TO_FILE = 4;

	public const int FLAG_TO_ALL = 6;

	public const int FLAG_STACKTRACE = 1024;

	private const int BUFFER_SIZE = 2048;

	private const float FLUSH_INTERVAL = 5f;

	private StreamWriter m_writer;

	private StringBuilder m_builder;

	private int[] m_flags;

	private float m_flushInterval;

	private bool m_fileOpened;

	private bool m_internalException;

	private bool _enabled;

	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Awake()
	{
	}

	public void Destroy()
	{
	}

	public void Update()
	{
	}

	public void SetFlag(int logType, int flag)
	{
	}

	private bool IsValid()
	{
		return false;
	}

	public void Flush()
	{
	}

	private void OnLogMessageReceived(string message, string stackTrace, LogType logType)
	{
	}

	private void Log(int logType, string message)
	{
	}

	private void LogException(Exception ex, string message)
	{
	}

	private void Assert(bool condition, string message)
	{
	}

	private string Format(int logType, object format, params object[] args)
	{
		return null;
	}

	private void WriteToFile(int flag, string message, string stackTrace)
	{
	}

	public static void Log(object message)
	{
	}

	public static void Log(Tag tag, string message, params object[] args)
	{
	}

	public static void Log(string message, params object[] args)
	{
	}

	public static void LogWarning(object message)
	{
	}

	public static void LogWarningFormat(string message, params object[] args)
	{
	}

	public static void LogError(object message)
	{
	}

	public static void LogError(string message, params object[] args)
	{
	}

	public static void LogDebug(object message)
	{
	}

	public static void LogDebugFormat(string message, params object[] args)
	{
	}

	public static void LogException(Exception ex)
	{
	}

	public static void LogException(Exception ex, object message)
	{
	}

	public static void LogExceptionFormat(Exception ex, string message, params object[] args)
	{
	}

	public static bool Assert(bool condition)
	{
		return false;
	}

	public static bool Assert(bool condition, object message)
	{
		return false;
	}

	public static bool AssertFormat(bool condition, string message, params object[] args)
	{
		return false;
	}
}
