using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleTalent : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CShipBattleTalent[] m_arrayTalent;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
