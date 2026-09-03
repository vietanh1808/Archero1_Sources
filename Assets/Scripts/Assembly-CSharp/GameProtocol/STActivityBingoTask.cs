using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityBingoTask : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public uint m_nProcess;

		public ushort m_nDone;

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
