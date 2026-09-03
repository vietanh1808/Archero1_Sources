using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampBlock : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nCampIndex;

		public ulong m_nResetTime;

		public uint[] m_vecOccupyValue;

		public uint m_nNum;

		public STCampSeasonArrowDamage[] m_vecCampSeasonArrowDamage;

		public uint m_nTotalDamage;

		public uint[] m_vecReceivedBlockIndex;

		public bool m_bPassed;

		public uint m_nBattleTimes;

		public ushort m_nBossStage;

		public uint m_nReceivedBit;

		public Dictionary<uint, ulong> m_mapMarked;

		public uint[] m_vecTotalOccupyValueByMonster;

		public uint[] m_vecTotalOccupyValueByCampIndex;

		public ushort[] m_vecTotalOccupyValueRank;

		public STCampBuildingOccupyTime m_stCampBuildingOccupyTime;

		public CCampRank[] m_arrayBossCrownDamageRank;

		public CCampRank[] m_vecHomeRank;

		public ulong m_nBossDeadTime;

		public uint m_nExtraOccupyValue;

		public bool m_bReceived;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
