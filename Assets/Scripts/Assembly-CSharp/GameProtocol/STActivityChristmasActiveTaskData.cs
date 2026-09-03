using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityChristmasActiveTaskData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public uint m_nNeed;

		public bool m_bReceive;

		public uint m_nProcess;

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
