using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenImprintBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nPetBoxCountLow;

		public ushort m_nPetBoxCountMid;

		public ushort m_nPetBoxCountHigh;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
