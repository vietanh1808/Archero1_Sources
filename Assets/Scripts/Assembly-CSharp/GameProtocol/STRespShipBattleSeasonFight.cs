using System;
using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STRespShipBattleSeasonFight : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public STShipBattleSeasonFightRound m_vecRound;

		public int m_nNum;

		public Dictionary<string, long> m_mapBiData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
