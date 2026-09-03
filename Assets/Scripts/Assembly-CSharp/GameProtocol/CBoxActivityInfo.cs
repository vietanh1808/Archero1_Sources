using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CBoxActivityInfo : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nChestType;

		public ulong m_nEndTimestamp;

		public string m_strEquipIds;

		public ushort m_nRate;

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
