using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityMiningBlock : IProtocol
	{
		public byte m_nBlockType;

		public byte m_nRewardType;

		public byte m_nMaxHp;

		public byte m_nHp;

		public ushort m_nCount;

		public bool m_bLight;

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
