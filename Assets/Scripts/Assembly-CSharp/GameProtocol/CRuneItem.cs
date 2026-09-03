using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRuneItem : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public string m_strUUID;

		public ulong m_nRowID;

		public uint m_nRuneID;

		public uint m_nLevel;

		public uint m_nQualityExp;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
