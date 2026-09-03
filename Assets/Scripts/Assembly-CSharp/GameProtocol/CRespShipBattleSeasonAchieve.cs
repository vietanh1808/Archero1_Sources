using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonAchieve : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CShipBattleAchieveData[] m_arrayAchieve;

		public Dictionary<uint, bool> m_mapReceivedBox;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
