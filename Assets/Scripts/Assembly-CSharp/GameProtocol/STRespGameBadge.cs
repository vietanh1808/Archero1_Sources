using System;
using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STRespGameBadge : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public Dictionary<uint, ushort> m_mapCardRewardReceived;

		public Dictionary<uint, ushort> m_mapCardHolderRewardReceived;

		public Dictionary<uint, ushort> m_mapDeckRewardReceived;

		public Dictionary<uint, CRewardItem[]> m_mapCardReward;

		public Dictionary<uint, CRewardItem[]> m_mapCardHolderReward;

		public Dictionary<uint, CRewardItem[]> m_mapDeckReward;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
