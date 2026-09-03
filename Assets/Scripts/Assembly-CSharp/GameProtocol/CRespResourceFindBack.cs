using System.IO;

namespace GameProtocol
{
	public sealed class CRespResourceFindBack : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nRewardStartTime;

		public ulong m_nFindBackTime;

		public STFindBackDataOfDay[] vecFindBackDays;

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
