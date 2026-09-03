using System.IO;

namespace GameProtocol
{
	public sealed class CRespFirstCharge : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nStartTime;

		public ulong m_nEndTimestamp;

		public string m_strProductId;

		public string m_strRewards;

		public ulong m_nChargeTime;

		public ulong m_nBitRewards;

		public STFirstChargeItem[] m_vecFirstCharge;

		public ulong m_nBuyEndTime;

		public uint m_nPopupCount;

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
