using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenRelicsBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRelicsBoxCountLow;

		public ushort m_nRelicsBoxCountHigh;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
