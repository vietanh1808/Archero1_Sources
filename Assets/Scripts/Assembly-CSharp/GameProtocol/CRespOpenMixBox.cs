using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenMixBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nMixBoxSinleCount;

		public ushort m_nMixBoxSingleTotalCount;

		public ushort m_nMixBoxTenCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
