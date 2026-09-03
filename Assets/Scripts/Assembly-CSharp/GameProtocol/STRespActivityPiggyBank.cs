using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STRespActivityPiggyBank : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nDailyTime;

		public ulong m_nBeginTime;

		public ulong m_nEndTime;

		public ushort m_nFreeRewardStatus;

		public uint[][] m_vecFreeRewards;

		public ushort m_nBuyBankID;

		public uint m_nTotalBattle;

		public STActivityPiggyBankData[] m_vecActivityPiggyBankDatas;

		public ushort m_nTag;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
