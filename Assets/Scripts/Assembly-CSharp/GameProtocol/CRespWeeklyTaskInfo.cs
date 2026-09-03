using System.IO;

namespace GameProtocol
{
	public sealed class CRespWeeklyTaskInfo : IProtocol
	{
		public ulong m_nEndTime;

		public ulong m_nTaskReward;

		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTowerLife;

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
