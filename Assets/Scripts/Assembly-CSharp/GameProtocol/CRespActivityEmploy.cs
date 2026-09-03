using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityEmploy : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nType;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ushort m_nSendCount;

		public ushort m_nAdRefreshEmployCnt;

		public ushort m_nRefreshEmployCnt;

		public uint m_nPointSmall;

		public uint m_nPointBig;

		public CEmployTaskData[] arr_EmployTask;

		public uint[] vecEmployId;

		public CEmploySendingData[] arr_EEmploySending;

		public uint m_nStyleId;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
