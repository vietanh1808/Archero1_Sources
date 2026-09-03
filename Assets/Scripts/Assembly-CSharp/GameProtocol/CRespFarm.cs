using System.IO;

namespace GameProtocol
{
	public sealed class CRespFarm : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public CFarmEvent[] m_vecFarmEvents;

		public ushort m_nGetRewardType;

		public CFarmSlot m_stFarmSlot;

		public ulong m_nTimestamp;

		public bool m_nIsRefresh;

		public ushort m_nEventUniqueId;

		public ushort m_nVisitCount;

		public ushort m_nAdVisitCount;

		public string m_nBeVisitedRecords;

		public ushort m_nIsOpenVisit;

		public ushort m_nMonthCardAddVisitCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
