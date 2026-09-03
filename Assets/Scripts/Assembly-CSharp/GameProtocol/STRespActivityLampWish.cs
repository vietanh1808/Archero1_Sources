using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityLampWish : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public uint m_nLayer;

		public uint m_nRound;

		public STActivityLampWishRewardProtoData[] m_vecLittleRewards;

		public STActivityLampWishRewardProtoData[] m_vecBigRewards;

		public uint[] m_nLittleId;

		public uint m_nBigId;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
