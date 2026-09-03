using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenBoxGem : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nType;

		public ushort m_nNum;

		public ushort m_nPrice;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
