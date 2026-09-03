using System.IO;

namespace GameProtocol
{
	public sealed class STRespVip : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nBoxTime;

		public ulong m_nDailyTime;

		public ushort m_nVipLevel;

		public uint m_nVipScore;

		public ulong m_nLvRewardBits;

		public string strPurchaseCnt;

		public string strIapScoreConf;

		public ushort m_nBuyScoreCnt;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
