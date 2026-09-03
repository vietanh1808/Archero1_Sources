using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonFire : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nStage;

		public ulong m_nPreTimestamp;

		public ulong m_nStartTimestamp;

		public ulong m_nEndTimestamp;

		public ulong m_nShowTimestamp;

		public uint m_nNum;

		public STShipBattleSeasonFireDamage[] m_vecFireDamage;

		public uint m_nTotalDamage;

		public uint m_nCampTotalDamage;

		public STShipBattleSeasonFireAchievement m_stAchievement;

		public STShipBattleSeasonFireRankInfo mstRankInfo;

		public ushort m_nActivityType;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
