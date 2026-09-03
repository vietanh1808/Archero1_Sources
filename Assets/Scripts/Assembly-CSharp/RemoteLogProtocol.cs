using System.Collections.Generic;

public static class RemoteLogProtocol
{
	public const int ProtocolVersion = 1;

	public const byte MsgHandshakeRequest = 1;

	public const byte MsgHandshakeResponse = 2;

	public const byte MsgLog = 16;

	public const byte MsgFileListRequest = 32;

	public const byte MsgFileListResponse = 33;

	public const byte MsgFileTransferRequest = 34;

	public const byte MsgFileTransferData = 35;

	public const byte MsgFileTransferComplete = 36;

	public const int MaxPayloadSize = 16777216;

	public const int FrameHeaderSize = 5;

	public static byte[] EncodeFrame(byte msgType, byte[] payload)
	{
		return null;
	}

	public static bool TryDecodeFrame(byte[] buffer, int offset, int count, out byte msgType, out byte[] payload, out int consumed)
	{
		msgType = default;
		payload = null;
		consumed = default;
		return false;
	}

	public static byte[] SerializeLog(LogEntry entry)
	{
		return null;
	}

	public static LogEntry DeserializeLog(byte[] payload)
	{
		return default;
	}

	public static byte[] SerializeHandshakeRequest(string deviceModel)
	{
		return null;
	}

	public static HandshakeRequest DeserializeHandshakeRequest(byte[] payload)
	{
		return default;
	}

	public static byte[] SerializeHandshakeResponse(bool accepted)
	{
		return null;
	}

	public static bool DeserializeHandshakeResponse(byte[] payload)
	{
		return false;
	}

	public static byte[] SerializeFileList(List<FileNode> nodes)
	{
		return null;
	}

	public static List<FileNode> DeserializeFileList(byte[] payload)
	{
		return null;
	}

	private static void SerializeFileNode(List<byte> list, FileNode node)
	{
	}

	private static FileNode DeserializeFileNode(byte[] payload, ref int offset)
	{
		return null;
	}

	public static byte[] SerializeFileTransferRequest(string path, bool isFolder)
	{
		return null;
	}

	public static (string, bool) DeserializeFileTransferRequest(byte[] payload)
	{
		return default;
	}

	private static void WriteInt32(byte[] buffer, ref int offset, int value)
	{
	}

	private static int ReadInt32(byte[] buffer, ref int offset)
	{
		return 0;
	}

	private static void WriteBytes(byte[] buffer, ref int offset, byte[] data)
	{
	}

	private static string ReadString(byte[] buffer, ref int offset)
	{
		return null;
	}

	private static string ReadNullableString(byte[] buffer, ref int offset)
	{
		return null;
	}
}
