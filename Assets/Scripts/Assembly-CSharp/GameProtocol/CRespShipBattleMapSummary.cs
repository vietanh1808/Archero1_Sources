using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleMapSummary : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint[] m_vecBlockStatus;

		public Dictionary<uint, ushort> m_mapSpecialBlockCampIndex;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
