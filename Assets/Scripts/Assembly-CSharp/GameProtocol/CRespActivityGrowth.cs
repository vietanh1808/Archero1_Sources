using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityGrowth : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public bool m_bOpen;

		public ushort m_nLayerIndex;

		public bool m_bIsIAPNormal;

		public bool m_bIsIAPBig;

		public ulong m_nFreeRewardBits;

		public ulong m_nNormalRewardBits;

		public ulong m_nBigRewardBits;

		public uint m_nFundId;

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
