using System.IO;

namespace GameProtocol
{
	public sealed class STRespShipBattleSeasonGhostShip : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nRemainFreeChallenges;

		public uint m_nPayChallengeCount;

		public uint m_nDailyChallengeCount;

		public STGhostShipProtoData[] m_vecGhostShipData;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nRankEndTime;

		public STShipBattleSeasonIsLandRankInfo mstRankInfo;

		public uint m_nChallengeLimit;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
