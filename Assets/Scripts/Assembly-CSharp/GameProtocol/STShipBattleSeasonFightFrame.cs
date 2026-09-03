using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonFightFrame
	{
		public long m_nTick;

		public ushort m_nType;

		public ushort m_nFireComponentId;

		public ushort m_nHitComponentId;

		public ushort m_nFighter;

		public Dictionary<string, long> m_mapAttr;

		public Dictionary<string, long> m_mapEffect;

		public Dictionary<string, STShipBattleSeasonFightBuff> m_mapBuff;

		public string[] m_vecDestroyBuff;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
