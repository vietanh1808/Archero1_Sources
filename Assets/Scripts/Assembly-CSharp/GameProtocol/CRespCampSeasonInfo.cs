using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampSeasonInfo : IProtocol
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

		public ushort m_nHomeLevel;

		public uint m_nPeerage;

		public uint m_nPeerageExp;

		public uint m_nCampSeasonArrow;

		public uint m_nCampSeasonSuperArrow;

		public uint m_nCampSeasonFood;

		public uint m_nCampSeasonWood;

		public uint m_nCampSeasonIron;

		public uint m_nCampSeasonCrystal;

		public uint m_nCampGold;

		public uint m_nCampSeasonTalent;

		public ushort m_nJoinTagCount;

		public string m_strRewardPreview;

		public uint m_nSelfBaseCampIndex;

		public ushort m_nBuyLifeCnt;

		public ushort m_nAdLifeCnt;

		public ushort m_nPassedMaxBlockLv;

		public ushort m_nBossStage;

		public uint m_nCampTalentBigPoint;

		public STCampBuildingOccupyTime m_stCampBuildingOccupyTime;

		public ushort m_nCrownRewardStatus;

		public ulong m_nBossDeadTime;

		public ushort m_nBossPreviewRewardReceived;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
