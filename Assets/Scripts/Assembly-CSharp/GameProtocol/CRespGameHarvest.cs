using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameHarvest : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nQuickStartTime;

		public uint m_nCoinPerMIn;

		public uint m_nExpPerMin;

		public CRewardItem[] m_vecRewardItem;

		public string m_strExtend;

		public ulong m_nBuyTimestamp;

		public ushort m_nDailyCnt;

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
