using System;
using System.IO;
using Newtonsoft.Json;

[Serializable]
public abstract class CProtocolBase : IProtocol
{
	[JsonIgnore]
	private string _strUserID;

	[JsonIgnore]
	private string _strDeviceID;

	[JsonIgnore]
	private string _strAccessToken;

	public abstract ushort GetMsgType { get; }

	[JsonIgnore]
	public string m_strUserID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public ushort m_nSoftVersion
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public string m_strDeviceID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[JsonIgnore]
	public string m_strAccessToken
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void ReadFromStream(BinaryReader reader)
	{
	}

	protected abstract void OnReadFromStream(BinaryReader reader);

	public void WriteToStream(BinaryWriter writer)
	{
	}

	protected abstract void OnWriteToStream(BinaryWriter writer);

	public virtual byte[] buildPacket()
	{
		return null;
	}
}
