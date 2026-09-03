using System.IO;

namespace GameProtocol
{
	public sealed class CRespMysticShop : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint[] vecShowIds;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
