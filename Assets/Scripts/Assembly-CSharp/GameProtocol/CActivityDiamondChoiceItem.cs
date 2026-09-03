using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityDiamondChoiceItem : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nId;

		public ushort[] m_vecChoiceIndex;

		public ushort m_nBuyCount;

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
