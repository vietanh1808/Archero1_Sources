using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameClientData : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strClientData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
