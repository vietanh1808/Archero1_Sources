using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespShipBattleSeasonPlayerInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CShipBattlePlayerInfo m_stPlayerInfo;

		public Dictionary<string, long> m_mapPlayerAttr;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
