using System.IO;

namespace GameProtocol
{
	public sealed class CRespBatchGemcomposite : IProtocol
	{
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
