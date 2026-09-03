using System.IO;

namespace GameProtocol
{
	public sealed class CRespDailyPlayInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strJsonInfo;

		public ushort m_nLife;

		public ushort m_nLifeMax;

		public ulong m_nLifeTimestamp;

		public ushort m_nSeasonId;

		public ulong m_nSeasonEndTimestamp;

		public string m_strJsonDailySeason;

		public ushort m_nMaxMazeMode;

		public ulong m_nPvpBanTimestamp;

		public ulong m_nCoopBanTimestamp;

		public ushort m_nMaxDifficult;

		public string m_strNewSeasonInfo;

		public uint m_nEndlessScore;

		public ushort m_nEndlessMaxLevel;

		public uint m_nServerMaxScore;

		public string m_strDailyTowerDefence;

		public ulong m_nWeekResetTimestamp;

		public uint m_reserved;

		public string[] m_vecTowerDefenceRewardConfig;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
