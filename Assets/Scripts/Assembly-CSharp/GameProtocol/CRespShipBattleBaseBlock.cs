using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleBaseBlock : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public STCampSeasonBaseBlockRole m_stBaseBlockRole;

		public STCampSeasonBlock m_stBlock;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
