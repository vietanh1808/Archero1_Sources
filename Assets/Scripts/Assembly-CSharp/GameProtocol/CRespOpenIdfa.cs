using System.IO;

namespace GameProtocol
{
	public sealed class CRespOpenIdfa : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

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
