using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public uint m_nZone;

		public uint m_nSubZone;

		public ushort m_nCamp;

		public ulong m_mBanTimestamp;

		public bool m_bRegistered;

		public ushort m_nCampLife;

		public ushort m_nMaxCampLife;

		public uint m_nPeerage;

		public uint m_nPeerageExp;

		public ushort m_nJoinTagCount;

		public string m_strRewardPreview;

		public ushort m_nBuyLifeCnt;

		public ushort m_nAdLifeCnt;

		public uint m_nShipSpeed;

		public uint m_nShipDistance;

		public CShipBattleRank[] m_vecShipBattleRankDetail;

		public ushort m_nFindBackLife;

		public CShipBattleMultipleEventsConf m_stCostLifeRankConf;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
