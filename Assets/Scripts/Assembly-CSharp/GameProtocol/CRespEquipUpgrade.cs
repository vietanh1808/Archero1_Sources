using System.IO;

namespace GameProtocol
{
	public sealed class CRespEquipUpgrade : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nRowId;

		public ushort m_nLevel;

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
