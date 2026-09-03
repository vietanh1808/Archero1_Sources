using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CNoviceRank : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong m_nUserID;

		public uint m_nRank;

		public ulong m_nValue;

		public string m_strName;

		public uint m_nHeadId;

		public uint m_nHeadFrame;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
