using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityFifthAnniversary : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nRefreshTime;

		public STActivityFifthAnniversarySign m_stActivitySign;

		public STActivityFifthAnniversaryAward m_stAwardData;

		public STActivityFifthAnniversaryShop m_stActivityShop;

		public ulong m_nHikingOpenTime;

		public ulong m_nHikingEndTime;

		public ulong m_nLotteryOpenTime;

		public ulong m_nLotteryEndTime;

		public ulong m_nHuntingOpenTime;

		public ulong m_nHuntingEndTime;

		public ulong m_nGardenOpenTime;

		public ulong m_nGardenEndTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
