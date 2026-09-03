using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityAnniversary : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nRefreshTime;

		public STActivityAnniversarySign m_stActivitySign;

		public STActivityAnniversaryPuzzle m_stActivityPuzzle;

		public STActivityAnniversaryAward[] m_vecAwardData;

		public STActivityAnniversaryExchange m_stActivityExchange;

		public STActivityAnniversaryOpenBox m_stActivityOpenBox;

		public STActivityAnniversaryTowerDefence m_stTowerDefence;

		public ulong m_nRewardBits;

		public uint m_nLastExchangeCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
