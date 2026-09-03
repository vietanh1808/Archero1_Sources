using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityInvestCondition : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public ushort m_nMinGameLevel;

		public ushort m_nMaxGameLevel;

		public ushort m_nNotBreakCount;

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
