using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityLotteryRewardData : IProtocol
	{
		public ushort m_nId;

		public ushort m_nMinRound;

		public ushort m_nMaxRound;

		public ushort m_nType;

		public ushort m_nNumber;

		public uint[][] vecMustDropShow;

		public uint[][] vecDropShow;

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
