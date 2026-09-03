using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityRebate : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public STActivityRebateTask[] vecTaskData;

		public ushort m_nBoxType;

		public Dictionary<ushort, STActivityRebateItem> m_mapRebateItems;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
