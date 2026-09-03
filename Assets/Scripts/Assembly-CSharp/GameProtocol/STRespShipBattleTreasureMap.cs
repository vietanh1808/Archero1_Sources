using System.IO;

namespace GameProtocol
{
	public class STRespShipBattleTreasureMap : IProtocol
	{
		public ushort m_nRewardBits;

		public CCommonRespMsg m_stRetMsg;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
