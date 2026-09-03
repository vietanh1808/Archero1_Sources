using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivity7thAnniversary : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nShopStartTime;

		public ulong m_nShopEndTime;

		public ulong m_nSignStartTime;

		public ulong m_nSignEndTime;

		public ulong m_nBpStartTime;

		public ulong m_nBpEndTime;

		public ulong m_nLuckyPlinkoStartTime;

		public ulong m_nLuckyPlinkoGameEndTime;

		public ulong m_nLuckyPlinkoEndTime;

		public ushort m_nOpenGameLevel;

		public ushort m_nLayerGameLevel;

		public STActivity7thAnniversaryBattlePass m_stBattlePass;

		public STActivity7thAnniversarySign m_stSign;

		public STActivity7thAnniversaryShop m_stShop;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public ulong m_nArtifactStartTime;

		public ulong m_nArtifactGameEndTime;

		public ulong m_nArtifactEndTime;

		public ulong m_nGiftTowerStartTime;

		public ulong m_nGiftTowerGameEndTime;

		public ulong m_nGiftTowerEndTime;

		public ulong m_nAngelPurifyStartTime;

		public ulong m_nAngelPurifyGameEndTime;

		public ulong m_nAngelPurifyEndTime;

		public ulong m_nAnniversaryCardStartTime;

		public ulong m_nAnniversaryCardGameEndTime;

		public ulong m_nAnniversaryCardEndTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
