using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityPirateTreasure : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nExchangeTime;

		public ulong m_nRefreshTime;

		public STActivityPirateTreasureVault m_stVault;

		public STActivityPirateTreasureGift m_stGift;

		public STActivityPirateTreasureExchange m_stExchange;

		public STActivityPirateTreasureTask[] m_vecTask;

		public uint m_nHitItemId;

		public uint m_nLastExchangeCount;

		public ushort m_nInitItemNum;

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
