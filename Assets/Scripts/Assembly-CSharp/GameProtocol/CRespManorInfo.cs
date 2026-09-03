using System.IO;

namespace GameProtocol
{
	public sealed class CRespManorInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nManorLevel;

		public uint m_nManorExp;

		public uint m_nStoreCoin;

		public CManorWorker[] m_arrayWorker;

		public CManorBuilding[] m_arrayBuilding;

		public string m_strOrders;

		public ushort m_nTodayOrderDone;

		public ulong m_nUserRawId;

		public CManorVisitorInfo[] n_arrayManorVisitorInfo;

		public string m_nSerialKey;

		public uint m_nStealTimes;

		public ulong m_nStealTimesTimeStamp;

		public CManorVisitorOperationInfo[] m_vecManorVisitorOperationInfos;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
