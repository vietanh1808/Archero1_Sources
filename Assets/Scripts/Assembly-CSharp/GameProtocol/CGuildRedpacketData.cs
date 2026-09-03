using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CGuildRedpacketData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

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
