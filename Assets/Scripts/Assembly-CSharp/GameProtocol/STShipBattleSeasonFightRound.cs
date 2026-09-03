using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonFightRound
	{
		public long m_nTotalTick;

		public uint m_nAttrCalculationAccuracy;

		public STShipBattleSeasonFightInfoData[] m_vecInfo;

		public Dictionary<string, long> m_mapAttr;

		public Dictionary<string, STShipBattleSeasonFightBuff> m_mapBuff;

		public STShipBattleSeasonFightFrame[] m_vecRecord;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
