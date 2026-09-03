using System.IO;

namespace GameProtocol
{
	public sealed class CRespGuildTaskInfo : IProtocol
	{
		public ulong m_nEndTime;

		public ushort m_nFreshCnt;

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
