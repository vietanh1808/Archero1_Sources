using System.IO;

namespace GameProtocol
{
	public sealed class CRespPveSeasonHarvest : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

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
