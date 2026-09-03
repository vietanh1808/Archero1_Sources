using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityCostLife : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public STActivityRebateTask[] vecTaskData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
