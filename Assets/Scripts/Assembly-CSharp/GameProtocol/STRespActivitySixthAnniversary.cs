using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivitySixthAnniversary : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nOpenTime;

		public ulong m_nEndTime;

		public ulong m_nShopStartTime;

		public ulong m_nShopEndTime;

		public ulong m_nSignStartTime;

		public ulong m_nSignEndTime;

		public ulong m_nBpStartTime;

		public ulong m_nBpEndTime;

		public ulong m_nMinecarStartTime;

		public ulong m_nMinecarGameEndTime;

		public ulong m_nMinecarEndTime;

		public ulong m_nMonopolyStartTime;

		public ulong m_nMonopolyGameEndTime;

		public ulong m_nMonopolyRewardEndTime;

		public ulong m_nMonopolyEndTime;

		public ushort m_nOpenGameLevel;

		public ushort m_nLayerGameLevel;

		public STActivitySixthAnniversaryBattlePass m_stBattlePass;

		public STActivitySixthAnniversarySign m_stSign;

		public STActivitySixthAnniversaryShop m_stShop;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public ulong m_nArtifactTrialStartTime;

		public ulong m_nArtifactTrialEndTime;

		public ulong m_nArtifactTrialRankEndTime;

		public ulong m_nArtifactIdentifyStartTime;

		public ulong m_nArtifactIdentifyGameEndTime;

		public ulong m_nArtifactIdentifyEndTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
