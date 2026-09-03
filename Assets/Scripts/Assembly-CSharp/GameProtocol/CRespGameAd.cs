using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameAd : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nHatchOpen;

		public ushort m_nHatchCnt;

		public ulong m_nHatchAdTime;

		public CMonsterEgg m_StHatchInfo;

		public ulong m_nTimestamp;

		public uint m_nStep;

		public ushort m_nBallonOpen;

		public ushort m_nBallonMaxCnt;

		public ushort m_nBallonCnt;

		public ulong m_nBallonAdTime;

		public ushort m_nAdId;

		public ushort m_nPurchaseId;

		public ushort m_nRewardIndex;

		public bool m_bBuyAd;

		public ushort m_nGiftShow;

		public ushort[] vecGiftIdxs;

		public ushort[] vecGiftBuyCnt;

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
